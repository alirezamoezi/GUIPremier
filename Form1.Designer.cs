namespace GUIPremier
{
    partial class Form1
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
            this.picPremier = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lstPremiers = new System.Windows.Forms.ListBox();
            this.lblRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).BeginInit();
            this.SuspendLayout();
            // 
            // picPremier
            // 
            this.picPremier.Location = new System.Drawing.Point(24, 34);
            this.picPremier.Name = "picPremier";
            this.picPremier.Size = new System.Drawing.Size(100, 86);
            this.picPremier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPremier.TabIndex = 0;
            this.picPremier.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(21, 219);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(35, 13);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "label2";
            // 
            // lstPremiers
            // 
            this.lstPremiers.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstPremiers.FormattingEnabled = true;
            this.lstPremiers.Location = new System.Drawing.Point(242, 0);
            this.lstPremiers.Name = "lstPremiers";
            this.lstPremiers.Size = new System.Drawing.Size(72, 287);
            this.lstPremiers.TabIndex = 3;
            this.lstPremiers.SelectedValueChanged += new System.EventHandler(this.lstPremiers_SelectedValueChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(24, 236);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(35, 13);
            this.lblRange.TabIndex = 4;
            this.lblRange.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 287);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lstPremiers);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picPremier);
            this.Name = "Form1";
            this.Text = "Ontario\'s Premiers";
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPremier;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.ListBox lstPremiers;
        private System.Windows.Forms.Label lblRange;
    }
}

