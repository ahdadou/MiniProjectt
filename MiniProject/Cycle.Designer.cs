namespace MiniProject
{
    partial class Cycle
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNomArabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numTxtDure = new System.Windows.Forms.NumericUpDown();
            this.btnValide = new System.Windows.Forms.Button();
            this.btnImprime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtDure)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(169, 88);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(176, 20);
            this.txtNom.TabIndex = 0;
            // 
            // txtNomArabe
            // 
            this.txtNomArabe.Location = new System.Drawing.Point(169, 181);
            this.txtNomArabe.Name = "txtNomArabe";
            this.txtNomArabe.Size = new System.Drawing.Size(176, 20);
            this.txtNomArabe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du cycle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Durée :\t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom du cycle en arabe :";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "testt1",
            "test2",
            "test3",
            "test4",
            "test5",
            "test56"});
            this.listBox1.Location = new System.Drawing.Point(0, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 216);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cycle";
            // 
            // numTxtDure
            // 
            this.numTxtDure.Location = new System.Drawing.Point(169, 136);
            this.numTxtDure.Name = "numTxtDure";
            this.numTxtDure.Size = new System.Drawing.Size(176, 20);
            this.numTxtDure.TabIndex = 8;
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(43, 220);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(152, 36);
            this.btnValide.TabIndex = 9;
            this.btnValide.Text = "Valide";
            this.btnValide.UseVisualStyleBackColor = true;
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(468, 346);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(149, 36);
            this.btnImprime.TabIndex = 10;
            this.btnImprime.Text = "Imprimer les cycles";
            this.btnImprime.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(468, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 272);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 48);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Liste des Cycles";
            // 
            // Cycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.numTxtDure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomArabe);
            this.Controls.Add(this.txtNom);
            this.Name = "Cycle";
            this.Size = new System.Drawing.Size(817, 397);
            ((System.ComponentModel.ISupportInitialize)(this.numTxtDure)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNomArabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTxtDure;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}
