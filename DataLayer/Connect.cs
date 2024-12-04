using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public class Connect
    {
        //Đọc và truyền các thông tin về csdl vào entity
        //Lớp này lưu thông tin về server, username,.....
        private string servername;
        private string username;
        private string password;
        private string database;


        public string Servername { get => servername; set => servername = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Database { get => database; set => database = value; }

        public Connect(string _servername, string _username, string _password, string _database)
        {
            this.servername = _servername;
            this.username = _username;
            this.password = _password;
            this.database = _database;
        }

        public void ConnectData()
        {
            //Sử dụng các thư viện cần thiết
            if (File.Exists("connectdb.dba"))
                File.Delete("connectdb.dba");
            FileStream fs = File.Open("connectdb.dba", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
