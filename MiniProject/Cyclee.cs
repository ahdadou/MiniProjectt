using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace MiniProject
{
    public partial class Cyclee : UserControl
    {
        //string id = "";
        BindingSource bs = new BindingSource();
        SqlDataAdapter da;

        public Cyclee()
        {
            InitializeComponent();
        }

        public void Cyclee_Load(object sender, EventArgs e)
        {
            active(false);
            lstBoxCycle.Items.Clear();
            Db.RemplissageListeBox("select * from cycle", "cycle", "nomCycle", "idCycle", ref bs, lstBoxCycle, ref da);
            lblErrorNom.Visible = false;

            txtid.DataBindings.Add("text", bs, "idCycle");
            txtNom.DataBindings.Add("text", bs, "NomCycle");
            txtNomarab.DataBindings.Add("Text", bs, "NomCycleArabe");

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            active(false);
            vide();
            bs.CancelEdit();

        }

        private void btnValide_Click(object sender, EventArgs e)
        {

            if (txtNom.Text != "")
            {
                //string cs = ConfigurationManager.ConnectionStrings["ecoleConnectionString"].ConnectionString;
                //SqlConnection cn = new SqlConnection(cs);
                //cn.Open();

                //if (id == "")
                //{
                //    string req = "insert into cycle values(@id,@nom,@nomArab)";
                //    SqlCommand com = new SqlCommand(req, cn);
                //    com.Parameters.Add(new SqlParameter("@id", Db.getId()));
                //    com.Parameters.Add(new SqlParameter("@nom", txtNom.Text));
                //    com.Parameters.Add(new SqlParameter("@nomArab", txtNomArab.Text));
                //    var dr = com.ExecuteScalar();
                //    dr = null;
                //    com = null;
                //}
                //else
                //{
                //    string req = "update cycle set nomCycle=@nom,nomCycleArabe=@nomArab where idCycle=@id";
                //    SqlCommand com = new SqlCommand(req, cn);
                //    com.Parameters.Add(new SqlParameter("@id", id));
                //    com.Parameters.Add(new SqlParameter("@nom", txtNom.Text));
                //    com.Parameters.Add(new SqlParameter("@nomArab", txtNomArab.Text));
                //    var dr = com.ExecuteScalar();
                //    dr = null;
                //    com = null;
                //    id = "";
                //}

                this.bs.EndEdit();
                this.da.Update(Db.ds,"Cycle");            
                vide();
                active(false);

            }
            else
            {
                lblErrorNom.Visible = true;
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (lstBoxCycle.Items.Count > 0)
            {
               // string cs = ConfigurationManager.ConnectionStrings["ecoleConnectionString"].ConnectionString;

                if (MessageBox.Show("Voulez Vous Supprimer Ce Cycle", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //SqlConnection cn = new SqlConnection(cs);
                    //cn.Open();
                    //string req = "delete from cycle where idCycle=@id";
                    //SqlCommand com = new SqlCommand(req, cn);
                    //com.Parameters.Add(new SqlParameter("@id", lstBoxCycle.SelectedValue));
                    //var dr = com.ExecuteScalar();

                    //// dr.Close();
                    //dr = null;
                    //com = null;
                    //Db.RemplissageListeBox("select * from cycle", "cycle", "nomCycle", "idCycle", ref bs, lstBoxCycle,ref da);

                    try{
                        bs.RemoveCurrent();
                        this.da.Update(Db.ds, "Cycle");
                    }catch(Exception ex)
                    {
                        
                    }

                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            active(true);
            //string cs = ConfigurationManager.ConnectionStrings["ecoleConnectionString"].ConnectionString;

            //SqlConnection cn = new SqlConnection(cs);
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("select * from cycle where idCycle=@id", cn);
            //cmd.Parameters.Add(new SqlParameter("@id", lstBoxCycle.SelectedValue));
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    txtNom.Text = dr["nomCycle"].ToString();
            //    txtNomArab.Text = dr["nomCyclearabe"].ToString();
            //    id = dr["idCycle"].ToString();
            //}
            //// dr.Close();
            //dr = null;
            //cmd = null;
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void vide()
        {
            
            lblErrorNom.Visible = false;
        }


        private void active(bool v)
        {
            btnAnnuler.Enabled = v;
            btnValide.Enabled = v;

            lstBoxCycle.Enabled = !v;
            btnsupprimer.Enabled = !v;
            btnModifier.Enabled = !v;
            btnAjouter.Enabled = !v;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            active(true);
            this.bs.AddNew();
            txtid.Text = Db.getId().ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
