namespace Spray_application_program
{
    partial class frmfilter1
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
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.btnapply = new System.Windows.Forms.Button();
            this.cmbfilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.lblfiltertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(250, 43);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(187, 20);
            this.txtfilter.TabIndex = 15;
            // 
            // btnapply
            // 
            this.btnapply.Location = new System.Drawing.Point(463, 41);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(75, 23);
            this.btnapply.TabIndex = 14;
            this.btnapply.Text = "Apply filter";
            this.btnapply.UseVisualStyleBackColor = true;
            // 
            // cmbfilter
            // 
            this.cmbfilter.FormattingEnabled = true;
            this.cmbfilter.Location = new System.Drawing.Point(52, 43);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(121, 21);
            this.cmbfilter.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter:";
            // 
            // lblfiltertext
            // 
            this.lblfiltertext.AutoSize = true;
            this.lblfiltertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltertext.Location = new System.Drawing.Point(203, 9);
            this.lblfiltertext.Name = "lblfiltertext";
            this.lblfiltertext.Size = new System.Drawing.Size(0, 13);
            this.lblfiltertext.TabIndex = 16;
            // 
            // frmfilter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 101);
            this.Controls.Add(this.lblfiltertext);
            this.Controls.Add(this.txtfilter);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.cmbfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmfilter1";
            this.Text = "frmfilter1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.ComboBox cmbfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblfiltertext;
    }
}