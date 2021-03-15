using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Platform : UserControl
    {
        private Button currentBtn;
        private Panel leftBorderBtn;


        public Panel panelBody
        {
            get { return pnlBody; }
            set { pnlBody = value; }
        }




        public Platform()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(77, 2);
            panel1.Controls.Add(leftBorderBtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (!Form1.Instance.panelBody.Controls.ContainsKey("Cycle"))
            //{
            //    //Cycle un = new Cycle();
            //    un.Dock = DockStyle.Fill;
            //    Form1.Instance.panelBody.Controls.Add(un);
            //}
            //Form1.Instance.panelBody.Controls["Cycle"].BringToFront();
            //Form1.Instance.backButton.Visible = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.ForeColor = Color.DarkGray;
                leftBorderBtn.BackColor = Color.FromArgb(69, 76, 121);
                leftBorderBtn.Location = new Point(currentBtn.Location.X, 45);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(240, 240, 240);
                currentBtn.ForeColor = Color.Gray;
            }
        }

        private void btnEcoles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cyclee1.BringToFront();
            cyclee1.Show();

            branches1.Hide();
            niveau1.Hide();
            classes1.Hide();
            // panelBody.backButton.Visible = true;
            ActivateButton(sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            branches1.BringToFront();
            cyclee1.Hide();
            branches1.Show();
            niveau1.Hide();
            classes1.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            niveau1.BringToFront();
            cyclee1.Hide();
            branches1.Hide();
            niveau1.Show();
            classes1.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            classes1.BringToFront();
            cyclee1.Hide();
            branches1.Hide();
            niveau1.Hide();
            classes1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Platform_Load(object sender, EventArgs e)
        {
            cyclee1.Hide();
            branches1.Hide();
            niveau1.Hide();
            classes1.Hide();
        }
    }
}
