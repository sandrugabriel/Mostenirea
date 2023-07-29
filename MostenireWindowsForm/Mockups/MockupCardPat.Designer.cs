namespace MostenireWindowsForm.Mockups
{
    partial class MockupCardPat
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
            this.lbltype = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLung = new System.Windows.Forms.Label();
            this.lblLagime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(14, 43);
            this.lbltype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(70, 30);
            this.lbltype.TabIndex = 0;
            this.lbltype.Text = "Type:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 102);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 30);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id:";
            // 
            // lblLung
            // 
            this.lblLung.AutoSize = true;
            this.lblLung.Location = new System.Drawing.Point(14, 156);
            this.lblLung.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLung.Name = "lblLung";
            this.lblLung.Size = new System.Drawing.Size(108, 30);
            this.lblLung.TabIndex = 2;
            this.lblLung.Text = "Lungime:";
            // 
            // lblLagime
            // 
            this.lblLagime.AutoSize = true;
            this.lblLagime.Location = new System.Drawing.Point(14, 208);
            this.lblLagime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLagime.Name = "lblLagime";
            this.lblLagime.Size = new System.Drawing.Size(94, 30);
            this.lblLagime.TabIndex = 3;
            this.lblLagime.Text = "Lagime:";
            // 
            // MockupCardPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.lblLagime);
            this.Controls.Add(this.lblLung);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbltype);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MockupCardPat";
            this.Text = "MockupCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLung;
        private System.Windows.Forms.Label lblLagime;
    }
}