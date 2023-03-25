namespace MovingLabel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.Buttoni = new System.Windows.Forms.Panel();
            this.btnDole = new System.Windows.Forms.Button();
            this.btnGore = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.btnLevo = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerlbl = new System.Windows.Forms.Label();
            this.brTekst = new System.Windows.Forms.Label();
            this.brojac = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.Buttoni.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Buttoni
            // 
            this.Buttoni.BackColor = System.Drawing.Color.Tomato;
            this.Buttoni.Controls.Add(this.btnDole);
            this.Buttoni.Controls.Add(this.btnGore);
            this.Buttoni.Controls.Add(this.btnDesno);
            this.Buttoni.Controls.Add(this.btnLevo);
            this.Buttoni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buttoni.Location = new System.Drawing.Point(0, 449);
            this.Buttoni.Name = "Buttoni";
            this.Buttoni.Size = new System.Drawing.Size(1003, 149);
            this.Buttoni.TabIndex = 0;
            this.Buttoni.Paint += new System.Windows.Forms.PaintEventHandler(this.Buttoni_Paint);
            // 
            // btnDole
            // 
            this.btnDole.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDole.Location = new System.Drawing.Point(462, 88);
            this.btnDole.Name = "btnDole";
            this.btnDole.Size = new System.Drawing.Size(75, 23);
            this.btnDole.TabIndex = 3;
            this.btnDole.Text = "DOLE";
            this.btnDole.UseVisualStyleBackColor = false;
            this.btnDole.Click += new System.EventHandler(this.btnDole_Click);
            // 
            // btnGore
            // 
            this.btnGore.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGore.Location = new System.Drawing.Point(462, 30);
            this.btnGore.Name = "btnGore";
            this.btnGore.Size = new System.Drawing.Size(75, 23);
            this.btnGore.TabIndex = 2;
            this.btnGore.Text = "GORE";
            this.btnGore.UseVisualStyleBackColor = false;
            this.btnGore.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDesno.Location = new System.Drawing.Point(533, 59);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 23);
            this.btnDesno.TabIndex = 1;
            this.btnDesno.Text = "DESNO";
            this.btnDesno.UseVisualStyleBackColor = false;
            this.btnDesno.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLevo
            // 
            this.btnLevo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLevo.Location = new System.Drawing.Point(389, 59);
            this.btnLevo.Name = "btnLevo";
            this.btnLevo.Size = new System.Drawing.Size(75, 23);
            this.btnLevo.TabIndex = 0;
            this.btnLevo.Text = "LEVO";
            this.btnLevo.UseVisualStyleBackColor = false;
            this.btnLevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Location = new System.Drawing.Point(462, 254);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(80, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "LABELA";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 449);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.timerlbl);
            this.panel2.Controls.Add(this.brTekst);
            this.panel2.Controls.Add(this.brojac);
            this.panel2.Location = new System.Drawing.Point(693, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 112);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vreme od pocetka:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timerlbl
            // 
            this.timerlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerlbl.Location = new System.Drawing.Point(187, 51);
            this.timerlbl.Name = "timerlbl";
            this.timerlbl.Size = new System.Drawing.Size(120, 45);
            this.timerlbl.TabIndex = 2;
            this.timerlbl.Text = "Tajmer";
            this.timerlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brTekst
            // 
            this.brTekst.BackColor = System.Drawing.Color.Transparent;
            this.brTekst.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brTekst.Location = new System.Drawing.Point(59, 13);
            this.brTekst.Name = "brTekst";
            this.brTekst.Size = new System.Drawing.Size(164, 45);
            this.brTekst.TabIndex = 1;
            this.brTekst.Text = "Broj pomeranja:";
            // 
            // brojac
            // 
            this.brojac.BackColor = System.Drawing.Color.Transparent;
            this.brojac.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brojac.Location = new System.Drawing.Point(187, 6);
            this.brojac.Name = "brojac";
            this.brojac.Size = new System.Drawing.Size(120, 45);
            this.brojac.TabIndex = 0;
            this.brojac.Text = "Brojac";
            this.brojac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 598);
            this.Controls.Add(this.Buttoni);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1014, 635);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Buttoni.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Buttoni;
        private Button btnDole;
        private Button btnGore;
        private Button btnDesno;
        private Button btnLevo;
        private Label lbl1;
        private Panel panel1;
        private Panel panel2;
        private Label brojac;
        private Label brTekst;
        private Label timerlbl;
        private Label label1;
    }
}