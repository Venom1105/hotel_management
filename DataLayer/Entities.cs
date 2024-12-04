using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public partial class Entities
    {
        //Thao tác vs entity
        private Entities(DbConnection connectionString, bool contextOwnConnection = true) 
            : base(connectionString, contextOwnConnection) { }
        public static Entities CreateEntities(bool contextOwnConnection = true) 
        { 
            //Đọc file connect
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            Connect conn = (Connect)bf.Deserialize(fs);

            //Decrypt nội dung
            string servername = Encryptor.Decrypt(conn.Servername, "qwertyiop", true);
            string username = Encryptor.Decrypt(conn.Username, "qwertyiop", true);
            string password = Encryptor.Decrypt(conn.Password, "qwertyiop", true);
            string database = Encryptor.Decrypt(conn.Database, "qwertyiop", true);

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();   
            SqlConnectionStringBuilder sqlConnectBuilder = new SqlConnectionStringBuilder();
            sqlConnectBuilder.DataSource = servername;
            sqlConnectBuilder.InitialCatalog = database;
            sqlConnectBuilder.UserID = username;
            sqlConnectBuilder.Password = password;

            string sqlConnectionString = sqlConnectBuilder.ConnectionString;

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectionString;

            entityBuilder.Metadata = @"res://*/KHACHSAN.csdl|res://*/KHACHSAN.ssdl|res://*/KHACHSAN.msl";

            EntityConnection connection = new EntityConnection(entityBuilder.ConnectionString);

            fs.Close();

            return new Entities(connection);
        }
    }
}
