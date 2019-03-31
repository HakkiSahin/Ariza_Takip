namespace ArizaTakip.UI.WinForm
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtISlemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(907, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 25);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giriş Yap";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSonuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSorgula);
            this.groupBox1.Controls.Add(this.txtISlemNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 192);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arıza Takip Sorgulama";
            // 
            // txtSonuc
            // 
            this.txtSonuc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSonuc.Location = new System.Drawing.Point(637, 48);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(306, 105);
            this.txtSonuc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sonuç : ";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(166, 95);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(343, 37);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtISlemNo
            // 
            this.txtISlemNo.Location = new System.Drawing.Point(166, 47);
            this.txtISlemNo.Name = "txtISlemNo";
            this.txtISlemNo.Size = new System.Drawing.Size(343, 30);
            this.txtISlemNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "İşlem No :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArizaTakip.UI.WinForm.Properties.Resources.repair_logo_png_3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 315);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(889, 12);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 25);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "İşlemler";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 597);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Oklid Teknik Arıza Takip";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.TextBox txtISlemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}