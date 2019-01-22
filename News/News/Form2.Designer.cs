namespace News
{
    partial class Form2
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
            this.lblTextID = new System.Windows.Forms.Label();
            this.lblTextTitle = new System.Windows.Forms.Label();
            this.lblTextDetail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextID
            // 
            this.lblTextID.AutoSize = true;
            this.lblTextID.Location = new System.Drawing.Point(12, 33);
            this.lblTextID.Name = "lblTextID";
            this.lblTextID.Size = new System.Drawing.Size(18, 13);
            this.lblTextID.TabIndex = 0;
            this.lblTextID.Text = "ID";
            // 
            // lblTextTitle
            // 
            this.lblTextTitle.AutoSize = true;
            this.lblTextTitle.Location = new System.Drawing.Point(12, 76);
            this.lblTextTitle.Name = "lblTextTitle";
            this.lblTextTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTextTitle.TabIndex = 1;
            this.lblTextTitle.Text = "Title";
            // 
            // lblTextDetail
            // 
            this.lblTextDetail.AutoSize = true;
            this.lblTextDetail.Location = new System.Drawing.Point(12, 124);
            this.lblTextDetail.Name = "lblTextDetail";
            this.lblTextDetail.Size = new System.Drawing.Size(34, 13);
            this.lblTextDetail.TabIndex = 2;
            this.lblTextDetail.Text = "Detail";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "id berita";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(66, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "judul berita";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(66, 124);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(45, 13);
            this.lblDetail.TabIndex = 5;
            this.lblDetail.Text = "isi berita";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 300);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTextDetail);
            this.Controls.Add(this.lblTextTitle);
            this.Controls.Add(this.lblTextID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextID;
        private System.Windows.Forms.Label lblTextTitle;
        private System.Windows.Forms.Label lblTextDetail;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDetail;
    }
}