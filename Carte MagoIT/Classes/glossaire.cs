using DevExpress.XtraGrid;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carte_MagoIT.Classes
{
    class glossaire
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        //Connection cnx;
        MySqlDataAdapter dt = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adpr = null;
        DataSet dste;
        private string server;
        private string database;
        private string uid;
        private string password;
        //clsDatebaseBackupRestor bd = new clsDatebaseBackupRestor();
        private string port;
        // private string str, code_isn;
        private static glossaire _instance = null;


        public static glossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new glossaire();
                return _instance;
            }
        }
 

        public void InitializeConnection()
        {
            try
            {

                //server = "192.168.1.2";
                server = "localhost";
                database = "magoit_db2";
               // uid = "rootroot";
                uid = "root";
                password = "root";
                port = "3306";
                string co = "Server=" + server + ";UserId=" + uid + ";Port=" + port + ";Password=" + password + ";Database=" + database;
                con = new MySqlConnection(co);
                con.Open();

                if (!con.State.ToString().ToLower().Equals("open"))
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Impossible de se connecter a un serveur!! contactez Administrateur  si le probleme persiste /n" + ex);
                //Application.Exit();
            }
        }
        public void InitializeConnectionReplique()
        {

            try
            {
                //try
                //{
                //    cnx = new Connection(); cnx.Connect();
                //    con = new MySqlConnection(cnx.path);
                //    con.Open();
                //}
                //catch (Exception)
                //{
                //    throw new Exception("l'un de vos fichiers de configuration est incorrect");
                //}
                //string co = "Data Source=zakuuza.com;Initial Catalog=c1144147c_boutique_db; User Id=c1144147c_admin; Password=!KVKhL93o&XZ;";
                //con = new MySqlConnection(co);
                //con.Open();
                ////MessageBox.Show("CONNECT OK");


                //if (!con.State.ToString().ToLower().Equals("open"))
                //{
                //    con.Open();
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show("Impossible de se connecter a un serveur!! contactez Administrateur");
                Application.Exit();
            }
        }

        private void SetParameter(IDbCommand cmd, string name, DbType type, int length, object value)
        {
            IDbDataParameter param = cmd.CreateParameter();

            param.ParameterName = name;
            param.DbType = type;
            param.Size = length;

            if (value == null)
            {
                if (!param.IsNullable)
                {
                    param.DbType = DbType.String;
                }

                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = value;
            }

            cmd.Parameters.Add(param);
        }

        public void GetDatas(GridControl grid, string field, string table)
        {
            InitializeConnection();

            try
            {
                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = " SELECT " + field + " FROM " + table + "";
                    dt = new MySqlDataAdapter((MySqlCommand)cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);
                    grid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        public DataSet sortiEnregistrement()
        {

            try
            {
                InitializeConnection();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new MySqlCommand("select * from afficheconducteur", con);
                adpr = new MySqlDataAdapter(cmd);
                dste = new DataSet();
                adpr.Fill(dste, "afficheconducteur");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dste;
        }
    }
}
