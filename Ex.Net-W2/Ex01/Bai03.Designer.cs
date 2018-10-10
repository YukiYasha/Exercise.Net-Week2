namespace Ex01
{
    partial class Bai03
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.rdoOK = new System.Windows.Forms.RadioButton();
            this.rdoOKC = new System.Windows.Forms.RadioButton();
            this.rdoARI = new System.Windows.Forms.RadioButton();
            this.rdoYNC = new System.Windows.Forms.RadioButton();
            this.rdoRC = new System.Windows.Forms.RadioButton();
            this.rdoYN = new System.Windows.Forms.RadioButton();
            this.grpIcon = new System.Windows.Forms.GroupBox();
            this.rdoQue = new System.Windows.Forms.RadioButton();
            this.rdoErr = new System.Windows.Forms.RadioButton();
            this.rdoInf = new System.Windows.Forms.RadioButton();
            this.rdoExc = new System.Windows.Forms.RadioButton();
            this.grpButton.SuspendLayout();
            this.grpIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the type of MessageBox you would like to display!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cancel was pressed.";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(240, 248);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(160, 57);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.rdoOK);
            this.grpButton.Controls.Add(this.rdoOKC);
            this.grpButton.Controls.Add(this.rdoARI);
            this.grpButton.Controls.Add(this.rdoYNC);
            this.grpButton.Controls.Add(this.rdoRC);
            this.grpButton.Controls.Add(this.rdoYN);
            this.grpButton.Location = new System.Drawing.Point(30, 57);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(173, 284);
            this.grpButton.TabIndex = 3;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "Button Type";
            // 
            // rdoOK
            // 
            this.rdoOK.AutoSize = true;
            this.rdoOK.Location = new System.Drawing.Point(15, 31);
            this.rdoOK.Name = "rdoOK";
            this.rdoOK.Size = new System.Drawing.Size(40, 17);
            this.rdoOK.TabIndex = 5;
            this.rdoOK.TabStop = true;
            this.rdoOK.Text = "OK";
            this.rdoOK.UseVisualStyleBackColor = true;
            // 
            // rdoOKC
            // 
            this.rdoOKC.AutoSize = true;
            this.rdoOKC.Location = new System.Drawing.Point(15, 71);
            this.rdoOKC.Name = "rdoOKC";
            this.rdoOKC.Size = new System.Drawing.Size(73, 17);
            this.rdoOKC.TabIndex = 6;
            this.rdoOKC.TabStop = true;
            this.rdoOKC.Text = "OKCancel";
            this.rdoOKC.UseVisualStyleBackColor = true;
            // 
            // rdoARI
            // 
            this.rdoARI.AutoSize = true;
            this.rdoARI.Location = new System.Drawing.Point(15, 111);
            this.rdoARI.Name = "rdoARI";
            this.rdoARI.Size = new System.Drawing.Size(105, 17);
            this.rdoARI.TabIndex = 7;
            this.rdoARI.TabStop = true;
            this.rdoARI.Text = "AbortRetryIgnore";
            this.rdoARI.UseVisualStyleBackColor = true;
            // 
            // rdoYNC
            // 
            this.rdoYNC.AutoSize = true;
            this.rdoYNC.Location = new System.Drawing.Point(15, 151);
            this.rdoYNC.Name = "rdoYNC";
            this.rdoYNC.Size = new System.Drawing.Size(90, 17);
            this.rdoYNC.TabIndex = 9;
            this.rdoYNC.TabStop = true;
            this.rdoYNC.Text = "YesNoCancel";
            this.rdoYNC.UseVisualStyleBackColor = true;
            // 
            // rdoRC
            // 
            this.rdoRC.AutoSize = true;
            this.rdoRC.Location = new System.Drawing.Point(15, 231);
            this.rdoRC.Name = "rdoRC";
            this.rdoRC.Size = new System.Drawing.Size(83, 17);
            this.rdoRC.TabIndex = 10;
            this.rdoRC.TabStop = true;
            this.rdoRC.Text = "RetryCancel";
            this.rdoRC.UseVisualStyleBackColor = true;
            // 
            // rdoYN
            // 
            this.rdoYN.AutoSize = true;
            this.rdoYN.Location = new System.Drawing.Point(15, 191);
            this.rdoYN.Name = "rdoYN";
            this.rdoYN.Size = new System.Drawing.Size(57, 17);
            this.rdoYN.TabIndex = 8;
            this.rdoYN.TabStop = true;
            this.rdoYN.Text = "YesNo";
            this.rdoYN.UseVisualStyleBackColor = true;
            // 
            // grpIcon
            // 
            this.grpIcon.Controls.Add(this.rdoQue);
            this.grpIcon.Controls.Add(this.rdoErr);
            this.grpIcon.Controls.Add(this.rdoInf);
            this.grpIcon.Controls.Add(this.rdoExc);
            this.grpIcon.Location = new System.Drawing.Point(240, 57);
            this.grpIcon.Name = "grpIcon";
            this.grpIcon.Size = new System.Drawing.Size(160, 182);
            this.grpIcon.TabIndex = 4;
            this.grpIcon.TabStop = false;
            this.grpIcon.Text = "Icon";
            // 
            // rdoQue
            // 
            this.rdoQue.AutoSize = true;
            this.rdoQue.Location = new System.Drawing.Point(18, 151);
            this.rdoQue.Name = "rdoQue";
            this.rdoQue.Size = new System.Drawing.Size(67, 17);
            this.rdoQue.TabIndex = 14;
            this.rdoQue.TabStop = true;
            this.rdoQue.Text = "Question";
            this.rdoQue.UseVisualStyleBackColor = true;
            // 
            // rdoErr
            // 
            this.rdoErr.AutoSize = true;
            this.rdoErr.Location = new System.Drawing.Point(18, 31);
            this.rdoErr.Name = "rdoErr";
            this.rdoErr.Size = new System.Drawing.Size(47, 17);
            this.rdoErr.TabIndex = 11;
            this.rdoErr.TabStop = true;
            this.rdoErr.Text = "Error";
            this.rdoErr.UseVisualStyleBackColor = true;
            // 
            // rdoInf
            // 
            this.rdoInf.AutoSize = true;
            this.rdoInf.Location = new System.Drawing.Point(18, 111);
            this.rdoInf.Name = "rdoInf";
            this.rdoInf.Size = new System.Drawing.Size(77, 17);
            this.rdoInf.TabIndex = 13;
            this.rdoInf.TabStop = true;
            this.rdoInf.Text = "Information";
            this.rdoInf.UseVisualStyleBackColor = true;
            // 
            // rdoExc
            // 
            this.rdoExc.AutoSize = true;
            this.rdoExc.Location = new System.Drawing.Point(18, 71);
            this.rdoExc.Name = "rdoExc";
            this.rdoExc.Size = new System.Drawing.Size(82, 17);
            this.rdoExc.TabIndex = 12;
            this.rdoExc.TabStop = true;
            this.rdoExc.Text = "Exclamation";
            this.rdoExc.UseVisualStyleBackColor = true;
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(439, 359);
            this.Controls.Add(this.grpIcon);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Bai03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai03";
            this.grpButton.ResumeLayout(false);
            this.grpButton.PerformLayout();
            this.grpIcon.ResumeLayout(false);
            this.grpIcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.GroupBox grpIcon;
        private System.Windows.Forms.RadioButton rdoOK;
        private System.Windows.Forms.RadioButton rdoOKC;
        private System.Windows.Forms.RadioButton rdoARI;
        private System.Windows.Forms.RadioButton rdoYN;
        private System.Windows.Forms.RadioButton rdoYNC;
        private System.Windows.Forms.RadioButton rdoRC;
        private System.Windows.Forms.RadioButton rdoErr;
        private System.Windows.Forms.RadioButton rdoExc;
        private System.Windows.Forms.RadioButton rdoInf;
        private System.Windows.Forms.RadioButton rdoQue;
    }
}