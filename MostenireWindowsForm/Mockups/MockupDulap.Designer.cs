namespace MostenireWindowsForm.Mockups
{
    partial class MockupDulap
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
            this.lblOglinda = new System.Windows.Forms.Label();
            this.lblInaltime = new System.Windows.Forms.Label();
            this.lblLung = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOglinda
            // 
            this.lblOglinda.AutoSize = true;
            this.lblOglinda.Location = new System.Drawing.Point(46, 151);
            this.lblOglinda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOglinda.Name = "lblOglinda";
            this.lblOglinda.Size = new System.Drawing.Size(119, 30);
            this.lblOglinda.TabIndex = 18;
            this.lblOglinda.Text = "Oglinda? :";
            // 
            // lblInaltime
            // 
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.Location = new System.Drawing.Point(46, 219);
            this.lblInaltime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInaltime.Name = "lblInaltime";
            this.lblInaltime.Size = new System.Drawing.Size(100, 30);
            this.lblInaltime.TabIndex = 17;
            this.lblInaltime.Text = "Inaltime:";
            // 
            // lblLung
            // 
            this.lblLung.AutoSize = true;
            this.lblLung.Location = new System.Drawing.Point(46, 279);
            this.lblLung.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLung.Name = "lblLung";
            this.lblLung.Size = new System.Drawing.Size(108, 30);
            this.lblLung.TabIndex = 16;
            this.lblLung.Text = "Lungime:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(46, 88);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 30);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id:";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(46, 29);
            this.lbltype.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(70, 30);
            this.lbltype.TabIndex = 14;
            this.lbltype.Text = "Type:";
            // 
            // MockupDulap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.lblOglinda);
            this.Controls.Add(this.lblInaltime);
            this.Controls.Add(this.lblLung);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbltype);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MockupDulap";
            this.Text = "MockupDulap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOglinda;
        private System.Windows.Forms.Label lblInaltime;
        private System.Windows.Forms.Label lblLung;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbltype;
    }
}