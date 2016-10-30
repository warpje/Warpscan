namespace WarpScan
{
    partial class frmBasis
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
            this.reconForm1 = new CS_ClassLibraryTester.ReconForm();
            this.btnSluit = new CS_ClassLibraryTester.ReconButton();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvScan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.btnBestand = new CS_ClassLibraryTester.ReconButton();
            this.txtBestand = new CS_ClassLibraryTester.TxtBox();
            this.reconForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reconForm1
            // 
            this.reconForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.reconForm1.Controls.Add(this.btnSluit);
            this.reconForm1.Controls.Add(this.lblLink);
            this.reconForm1.Controls.Add(this.label2);
            this.reconForm1.Controls.Add(this.label1);
            this.reconForm1.Controls.Add(this.lvScan);
            this.reconForm1.Controls.Add(this.lblUitkomst);
            this.reconForm1.Controls.Add(this.btnBestand);
            this.reconForm1.Controls.Add(this.txtBestand);
            this.reconForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reconForm1.ForeColor = System.Drawing.Color.Olive;
            this.reconForm1.Image = null;
            this.reconForm1.Location = new System.Drawing.Point(0, 0);
            this.reconForm1.MoveHeight = 30;
            this.reconForm1.Name = "reconForm1";
            this.reconForm1.Resizable = true;
            this.reconForm1.ShowIcon = false;
            this.reconForm1.Size = new System.Drawing.Size(463, 411);
            this.reconForm1.TabIndex = 0;
            this.reconForm1.Text = "WaRp Poison Scanner Credits to Lexus!";
            this.reconForm1.TextAlignment = CS_ClassLibraryTester.ReconForm.TextAlign.Left;
            this.reconForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            // 
            // btnSluit
            // 
            this.btnSluit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSluit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSluit.Image = null;
            this.btnSluit.Location = new System.Drawing.Point(437, 3);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.NoRounding = false;
            this.btnSluit.Size = new System.Drawing.Size(23, 23);
            this.btnSluit.TabIndex = 19;
            this.btnSluit.Text = "X";
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.LinkColor = System.Drawing.Color.Olive;
            this.lblLink.Location = new System.Drawing.Point(9, 389);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(55, 13);
            this.lblLink.TabIndex = 18;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Pscan.xyz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "File to scan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Detection rate:";
            // 
            // lvScan
            // 
            this.lvScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lvScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvScan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvScan.ForeColor = System.Drawing.Color.Olive;
            this.lvScan.Location = new System.Drawing.Point(12, 114);
            this.lvScan.Name = "lvScan";
            this.lvScan.Size = new System.Drawing.Size(439, 263);
            this.lvScan.TabIndex = 15;
            this.lvScan.UseCompatibleStateImageBehavior = false;
            this.lvScan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Anti Virus";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Result";
            this.columnHeader2.Width = 264;
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.AutoSize = true;
            this.lblUitkomst.Location = new System.Drawing.Point(92, 98);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(30, 13);
            this.lblUitkomst.TabIndex = 2;
            this.lblUitkomst.Text = "0/35";
            // 
            // btnBestand
            // 
            this.btnBestand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBestand.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBestand.Image = null;
            this.btnBestand.Location = new System.Drawing.Point(376, 60);
            this.btnBestand.Name = "btnBestand";
            this.btnBestand.NoRounding = false;
            this.btnBestand.Size = new System.Drawing.Size(75, 23);
            this.btnBestand.TabIndex = 1;
            this.btnBestand.Text = "File..";
            this.btnBestand.Click += new System.EventHandler(this.btnBestand_Click);
            // 
            // txtBestand
            // 
            this.txtBestand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtBestand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtBestand.ForeColor = System.Drawing.Color.Black;
            this.txtBestand.Location = new System.Drawing.Point(12, 63);
            this.txtBestand.Name = "txtBestand";
            this.txtBestand.Size = new System.Drawing.Size(346, 20);
            this.txtBestand.TabIndex = 0;
            // 
            // frmBasis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 411);
            this.Controls.Add(this.reconForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBasis";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.reconForm1.ResumeLayout(false);
            this.reconForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.ReconForm reconForm1;
        private System.Windows.Forms.Label lblUitkomst;
        private CS_ClassLibraryTester.ReconButton btnBestand;
        private CS_ClassLibraryTester.TxtBox txtBestand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvScan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label label2;
        private CS_ClassLibraryTester.ReconButton btnSluit;
    }
}

