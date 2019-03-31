namespace ArizaTakip.UI.WinForm
{
    partial class frmYeniIslem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAriza = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri :";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(145, 25);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(266, 33);
            this.cmbMusteri.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arıza :";
            // 
            // cmbAriza
            // 
            this.cmbAriza.FormattingEnabled = true;
            this.cmbAriza.Location = new System.Drawing.Point(145, 87);
            this.cmbAriza.Name = "cmbAriza";
            this.cmbAriza.Size = new System.Drawing.Size(266, 33);
            this.cmbAriza.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(145, 140);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(266, 47);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmYeniIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 221);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbAriza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmYeniIslem";
            this.Text = "frmYeniIslem";
            this.Load += new System.EventHandler(this.frmYeniIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAriza;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKaydet;
    }
}