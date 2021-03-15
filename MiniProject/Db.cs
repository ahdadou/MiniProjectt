using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace MiniProject
{
    static class  Db
    {
        static string cs;
        static public DataSet ds = new DataSet();
        static SqlConnection cn = new SqlConnection();
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlCommandBuilder comBuild;



        //Open Connection
        static private void openConnection()
        {
            if (cn.State !=ConnectionState.Open)
            {
                cs = ConfigurationManager.ConnectionStrings["ecoleConnectionString"].ConnectionString;
                cn = new SqlConnection(cs);
                cn.Open();
            }

        }

        //fermer Connection
        static private void fermerConnection()
        {
            if (cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }


        //Remplire ListBox  without any relation

        static public void RemplissageListeBox(string requet,string table, string display, string value, ref BindingSource bindingSource,ListBox listBox)
        {
            openConnection();
            cmd = new SqlCommand(requet, cn);
            da = new SqlDataAdapter(cmd);
            try
            {
                if (ds.Tables[table] != null)
                    ds.Tables[table].Clear();
            }
            catch(Exception ex) { }
            da.Fill(ds, table);
            bindingSource.DataSource = ds;
            bindingSource.DataMember = table;

            listBox.DataSource = bindingSource;
            listBox.DisplayMember = display;
            listBox.ValueMember = value;
        }




        //genere ID
        static public int getId()
        {
            int id;
            Random r = new Random();
            int i = Math.Abs(r.Next() * 1000);
            id = Convert.ToInt32(DateTime.Now.ToString("ddmmss")) + i;

            return id;
        }


    }
}
