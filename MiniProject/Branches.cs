using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace MiniProject
{
    public partial class Branches : UserControl
    {
        string id = "";
        BindingSource bsC = new BindingSource();
        BindingSource bsB = new BindingSource();
        SqlDataAdapter daC;
        SqlDataAdapter daB;
        public Branches()
        {
            InitializeComponent();
        }

        private void Branches_Load(object sender, EventArgs e)
        {
            Db.RemplissageListeBox("select * from Cycle", "Cycle", "nomCycle", "idCycle", ref bsC, comboBox1,ref daC);
            try
            {
                string req = "select * from branche where idCycle='" + comboBox1.SelectedValue + "'";
                Db.RemplissageListeBox(req, "branche", "nomBranche", "idBranche", ref bsB, lstBoxBranche, ref daB);
                txtIdCycle.Text = comboBox1.SelectedValue.ToString();


            }
            catch (Exception ex) { }
            // Db.RemplissageListeBoxRelation("select * from branche", "Cycle", "branche", "idCycle", "nomBranche", "idBranche", ref bsC, ref bsB, lstBoxBranche, ref daB);


            txtBranche.DataBindings.Add("text", bsB, "nombranche");
            txtArabe.DataBindings.Add("text", bsB, "nombrancheArabe");
            txtid.DataBindings.Add("text", bsB, "idBranche");
            txtCode.DataBindings.Add("text", bsB, "codeBranche");
            //txtIdCycle.DataBindings.Add("text", bsB, "idCycle");
            lblErrorCode.Visible = false;
            lblErrorNom.Visible = false;
            active(false);
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBranche_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorNom_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                try
                {
                    if(comboBox1.SelectedIndex>0)
                    txtIdCycle.Text = comboBox1.SelectedValue.ToString();
                    //MessageBox.Show(comboBox1.SelectedValue.ToString());
                    string req = "select * from branche where idCycle='" + comboBox1.SelectedValue + "'";
                    Db.RemplissageListeBox(req, "branche", "nomBranche", "idBranche", ref bsB, lstBoxBranche, ref daB);


                }
                catch (Exception ex) { }
            }
        }


        private void vide()
        {

            lblErrorNom.Visible = false;
            lblErrorCode.Visible = false;
        }


        private void active(bool v)
        {
            btnAnnuler.Enabled = v;
            btnValide.Enabled = v;  

            lstBoxBranche.Enabled = !v;
            btnsupprimer.Enabled = !v;
            btnModifier.Enabled = !v;
            btnAjouter.Enabled = !v;
            comboBox1.Enabled = !v;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            active(true);
            this.bsB.AddNew();
            txtid.Text = Db.getId().ToString();
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            if (txtBranche.Text == "")
            {
                lblErrorNom.Visible = true;
                return;
            }
            if (txtCode.Text == "")
            {
                lblErrorCode.Visible = true;
                return;
            }



            int idBranche = Convert.ToInt32(txtid.Text);
            string nomBranche = txtBranche.Text;
            string nomBranchearabe = txtArabe.Text;
            string codeBranche = txtCode.Text;
            string idCycle = comboBox1.SelectedValue.ToString();
            //bsB.AddNew();
            DataRowView dr = (DataRowView)bsB.Current;
            dr.Row["idBranche"] = idBranche;
            dr.Row["nomBranche"] = nomBranche;
            dr.Row["nomBranchearabe"] = nomBranchearabe;
            dr.Row["codeBranche"] = codeBranche;
            dr.Row["idCycle"] = idCycle;

        
            this.bsB.EndEdit();
            this.daB.Update(Db.ds, "Branche");
            active(false);
            lblErrorNom.Visible = false;
            lblErrorCode.Visible = false;


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            active(false);
            vide();
            bsB.CancelEdit();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (lstBoxBranche.Items.Count > 0)
            {
                // string cs = ConfigurationManager.ConnectionStrings["ecoleConnectionString"].ConnectionString;

                if (MessageBox.Show("Voulez Vous Supprimer Ce Branche", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bsB.RemoveCurrent();
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            active(true);

        }

        private void btncycle_Click(object sender, EventArgs e)
        {
            FormCycle f = new FormCycle();
            f.ShowDialog();
            Db.RemplissageListeBox("select * from Cycle", "Cycle", "nomCycle", "idCycle", ref bsC, comboBox1, ref daC);
            try
            {
                string req = "select * from branche where idCycle='" + comboBox1.SelectedValue + "'";
                Db.RemplissageListeBox(req, "branche", "nomBranche", "idBranche", ref bsB, lstBoxBranche, ref daB);
                txtIdCycle.Text = comboBox1.SelectedValue.ToString();


            }
            catch (Exception ex) { }





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
