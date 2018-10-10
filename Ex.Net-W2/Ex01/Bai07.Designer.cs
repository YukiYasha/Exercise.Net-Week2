namespace Ex01
{
    partial class Bai07
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
            this.cboDisk = new System.Windows.Forms.ComboBox();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.lstvShow = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cboDisk
            // 
            this.cboDisk.FormattingEnabled = true;
            this.cboDisk.Location = new System.Drawing.Point(12, 12);
            this.cboDisk.Name = "cboDisk";
            this.cboDisk.Size = new System.Drawing.Size(72, 21);
            this.cboDisk.TabIndex = 0;
            this.cboDisk.Text = "D:\\";
            // 
            // cboView
            // 
            this.cboView.FormattingEnabled = true;
            this.cboView.Location = new System.Drawing.Point(206, 12);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(84, 21);
            this.cboView.TabIndex = 1;
            this.cboView.Text = "Details";
            // 
            // lstvShow
            // 
            this.lstvShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvShow.Location = new System.Drawing.Point(12, 51);
            this.lstvShow.Name = "lstvShow";
            this.lstvShow.Size = new System.Drawing.Size(735, 437);
            this.lstvShow.TabIndex = 2;
            this.lstvShow.UseCompatibleStateImageBehavior = false;
            // 
            // Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 500);
            this.Controls.Add(this.lstvShow);
            this.Controls.Add(this.cboView);
            this.Controls.Add(this.cboDisk);
            this.Name = "Bai07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DemoListview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDisk;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.ListView lstvShow;
    }
}