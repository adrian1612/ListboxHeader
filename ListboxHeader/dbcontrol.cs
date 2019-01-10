using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ListboxHeader
{
    class dbcontrol
    {
        SqlConnection cn = new SqlConnection(@"Server = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|dbtest.mdf;Integrated Security = True");
        SqlCommand cm;
        public SqlDataAdapter da;
        public DataTable dt;
        List<SqlParameter> Params = new List<SqlParameter>();
        public int recordcount;
        public string exception;
        public dbcontrol()
        {

        }

        public dbcontrol(string connectionstring)
        {
            cn = new SqlConnection(connectionstring);
        }

        private void q(string name)
        {
            recordcount = 0;
            exception = null;
            try
            {
                cn.Open();
                cm = new SqlCommand(name, cn);
                Params.ForEach(p => cm.Parameters.Add(p));
                Params.Clear();
                dt = new DataTable();
                da = new SqlDataAdapter(cm);
                recordcount = da.Fill(dt);
            }
            catch (Exception e)
            {
                exception = "Error : " + e.Message;
            }finally
            {
                if (cn.State==ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void p(string name, object value)
        {
            SqlParameter newparam = new SqlParameter(name, value);
            Params.Add(newparam);
        }

        public bool checkError(bool err = false)
        {
            if (string.IsNullOrEmpty(exception))
            {
                return false;
            }
            if (err==true)
            {
                MessageBox.Show(exception,"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            return true;
        }

        public DataTable query(string command, Dictionary<string,object> parameters)
        {
            foreach (KeyValuePair<string,object> d in parameters)
            {
                p($"{d.Key}", d.Value);
            }
            q(command);
            return dt;
        }
    }
}
