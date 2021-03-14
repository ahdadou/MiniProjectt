using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        //tesssst
        static Form1 _obj;
        private Button currentBtn;
        private Panel leftBorderBtn;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }


        public Panel panelBody
        {
            get { return pnlBody; }
            set { pnlBody = value; }
        }

        public PictureBox backButton
        {
            get { return pBoxBack; }
            set { pBoxBack = value; }
        }

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(2, 50);
            panel1.Controls.Add(leftBorderBtn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pBoxBack.Visible = false;
            pBoxForward.Visible = false;
            _obj = this;
            //Platform uc = new Platform();
            FirstPage uc = new FirstPage();
            uc.Dock = DockStyle.Fill;
            panelBody.Controls.Add(uc);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.panelBody.Controls.ContainsKey("Platform"))
            {
                Platform un = new Platform();
                un.Dock = DockStyle.Fill;
                Form1.Instance.panelBody.Controls.Add(un);
            }
            Form1.Instance.panelBody.Controls["Platform"].BringToFront();
            Form1.Instance.backButton.Visible = true;
            ActivateButton(sender, Color.FromArgb(0, 0, 0, 0));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelBody.Controls["FirstPage"].BringToFront();
            backButton.Visible = false;
            ActivateButton(sender, Color.FromArgb(0, 0, 0, 0));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 0, 0, 0));
            if (!Form1.Instance.panelBody.Controls.ContainsKey("Scolarite"))
            {
                Scolarite un = new Scolarite();
                un.Dock = DockStyle.Fill;
                Form1.Instance.panelBody.Controls.Add(un);
            }
            Form1.Instance.panelBody.Controls["Scolarite"].BringToFront();
            Form1.Instance.backButton.Visible = true;

        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 140, 201, 12);
                currentBtn.ForeColor = Color.DarkGray;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button;

                leftBorderBtn.BackColor = Color.FromArgb(69, 76, 121);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
               // iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(240, 240, 240);
                currentBtn.ForeColor = Color.Gray;
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
               // currentBtn.IconColor = Color.Gainsboro;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 0, 0, 0));

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelBody.Controls["FirstPage"].BringToFront();
            pBoxBack.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 0, 0, 0));
            if (!Form1.Instance.panelBody.Controls.ContainsKey("FirstPage"))
            {
                FirstPage un = new FirstPage();
                un.Dock = DockStyle.Fill;
                Form1.Instance.panelBody.Controls.Add(un);
            }
            Form1.Instance.panelBody.Controls["FirstPage"].BringToFront();
            Form1.Instance.backButton.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
