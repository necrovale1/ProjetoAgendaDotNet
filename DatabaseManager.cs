using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

public static class DatabaseManager
{
    // Nomes das connection strings definidas no App.config
    private const string EscolaConnectionStringName = "ProjetoAgendaDotNet.Properties.Settings.ConnectionString";
    private const string LocalConnectionStringName = "LocalDB";

    public static SqlConnection GetConnection(bool preferLocalIfAvailable = false)
    {
        // Tenta primeiro o banco local se preferido
        if (preferLocalIfAvailable)
        {
            var localConn = GetLocalConnection();
            if (localConn != null) return localConn;
        }

        // Tenta a conexão com o banco da escola
        try
        {
            var escolaConn = new SqlConnection(GetConnectionString(EscolaConnectionStringName));
            escolaConn.Open();

            // Testa uma consulta simples para validar
            using (var cmd = new SqlCommand("SELECT 1", escolaConn))
            {
                cmd.ExecuteScalar();
            }

            return escolaConn;
        }
        catch
        {
            // Fallback para LocalDB
            return GetLocalConnection();
        }
    }

    private static SqlConnection GetLocalConnection()
    {
        try
        {
            var localConn = new SqlConnection(GetConnectionString(LocalConnectionStringName));
            localConn.Open();
            return localConn;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao conectar ao LocalDB: {ex.Message}\n\n" +
                           "Verifique se o SQL Server LocalDB está instalado e funcionando.",
                           "Erro de Conexão",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            return null;
        }
    }

    private static string GetConnectionString(string name)
    {
        try
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        catch
        {
            // Fallback para strings hardcoded caso o ConfigurationManager falhe
            if (name == EscolaConnectionStringName)
                return "Data Source=172.16.255.252;User ID=241162;Password=K@keki506070;Encrypt=False";

            return @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=dsPessoa_Local;";
        }
    }

    public static void InitializeLocalDatabase()
    {
        try
        {
            // Conexão master para criar o banco se necessário
            using (var masterConn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;"))
            {
                masterConn.Open();

                // Cria o banco se não existir
                var cmdCreateDb = new SqlCommand(
                    @"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'dsPessoa_Local')
                  BEGIN
                    CREATE DATABASE dsPessoa_Local;
                    PRINT 'Banco dsPessoa_Local criado com sucesso.';
                  END", masterConn);
                cmdCreateDb.ExecuteNonQuery();

                // Cria a tabela
                var cmdCreateTable = new SqlCommand(
                    @"USE dsPessoa_Local;
                  IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Pessoas')
                  BEGIN
                    CREATE TABLE Pessoas (
                        ID INT PRIMARY KEY IDENTITY(1,1),
                        Name NVARCHAR(100) NOT NULL,
                        Endereco NVARCHAR(200),
                        Cidade NVARCHAR(50),
                        Email NVARCHAR(100),
                        DataNasc DATE,
                        Telefone NVARCHAR(20)
                    );
                    PRINT 'Tabela Pessoas criada com sucesso.';
                  END", masterConn);
                cmdCreateTable.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao inicializar banco local: {ex.Message}\n\n" +
                          "Execute o seguinte comando como administrador:\n" +
                          "sqllocaldb create MSSQLLocalDB",
                          "Erro Crítico",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
        }
    }
    public static void SyncLocalToServer(DataSet dataSetLocal)
    {
        try
        {
            using (var localConn = GetLocalConnection())
            using (var serverConn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProjetoAgendaDotNet.Properties.Settings.ConnectionString"].ConnectionString))
            {
                serverConn.Open();

                // Para cada tabela que precisa ser sincronizada
                foreach (DataRow row in dataSetLocal.Tables["DSPessoa"].Rows)
                {
                    // Implemente a lógica de upsert (insert ou update)
                    var cmd = new SqlCommand(@"
                    IF EXISTS (SELECT 1 FROM DSPessoa WHERE ID = @ID)
                        UPDATE DSPessoa SET 
                            Name = @Name, 
                            Endereco = @Endereco,
                            /* outros campos */
                        WHERE ID = @ID
                    ELSE
                        INSERT INTO DSPessoa (Name, Endereco, /* outros campos */)
                        VALUES (@Name, @Endereco, /* outros valores */)", serverConn);

                    // Adicione os parâmetros
                    cmd.Parameters.AddWithValue("@ID", row["ID"]);
                    // ... outros parâmetros

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Falha na sincronização: " + ex.Message);
        }
    }
    public static bool LocalDbExists()
    {
        try
        {
            using (var conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;"))
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM sys.databases WHERE name = 'dsPessoa_Local'", conn);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
        catch
        {
            return false;
        }
    }
}