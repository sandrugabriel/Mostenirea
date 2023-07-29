namespace MostenireWindowsForm.Mockups
{
    partial class MockupBirou
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
            this.lblLagime = new System.Windows.Forms.Label();
            this.lblLung = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblInaltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLagime
            // 
            this.lblLagime.AutoSize = true;
            this.lblLagime.Location = new System.Drawing.Point(30, 279);
            this.lblLagime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLagime.Name = "lblLagime";
            this.lblLagime.Size = new System.Drawing.Size(94, 30);
            this.lblLagime.TabIndex = 7;
            this.lblLagime.Text = "Lagime:";
            // 
            // lblLung
            // 
            this.lblLung.AutoSize = true;
            this.lblLung.Location = new System.Drawing.Point(30, 217);
            this.lblLung.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLung.Name = "lblLung";
            this.lblLung.Size = new System.Drawing.Size(108, 30);
            this.lblLung.TabIndex = 6;
            this.lblLung.Text = "Lungime:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 94);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 30);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id:";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(30, 35);
            this.lbltype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(70, 30);
            this.lbltype.TabIndex = 4;
            this.lbltype.Text = "Type:";
            // 
            // lblInaltime
            // 
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.Location = new System.Drawing.Point(30, 157);
            this.lblInaltime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInaltime.Name = "lblInaltime";
            this.lblInaltime.Size = new System.Drawing.Size(100, 30);
            this.lblInaltime.TabIndex = 8;
            this.lblInaltime.Text = "Inaltime:";
            // 
            // MockupBirou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.lblInaltime);
            this.Controls.Add(this.lblLagime);
            this.Controls.Add(this.lblLung);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbltype);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MockupBirou";
            this.Text = "MockupBirou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLagime;
        private System.Windows.Forms.Label lblLung;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblInaltime;
    }
}