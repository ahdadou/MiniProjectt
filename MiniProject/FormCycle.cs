using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MiniProject
{
    public partial class FormCycle : Form
    {
        public FormCycle()
        {
            InitializeComponent();
        }

        private void FormCycle_Load(object sender, EventArgs e)
        {
            lblErrorNom.Visible = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {
                string cs = ConfigurationManager.ConnectionStrings["ecoleConnectionString"].ConnectionString;
                SqlConnection cn = new SqlConnection(cs);
                cn.Open();


                string req = "insert into cycle values(@id,@nom,@nomArab)";
                SqlCommand com = new SqlCommand(req, cn);
                com.Parameters.Add(new SqlParameter("@id", Db.getId()));
                com.Parameters.Add(new SqlParameter("@nom", txtNom.Text));
                com.Parameters.Add(new SqlParameter("@nomArab", txtNomarab.Text));
                var dr = com.ExecuteScalar();
                dr = null;
                com = null;
                cn.Close();

                this.Close();

            }
            else
            {
                lblErrorNom.Visible = true;
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
