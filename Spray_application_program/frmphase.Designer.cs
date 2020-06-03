namespace Spray_application_program
{
    partial class frmcurrency
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.cmb_grower = new System.Windows.Forms.ComboBox();
            this.chkdeleted = new System.Windows.Forms.CheckBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_phasedesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phase Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grower: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(75, 10);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 20);
            this.txt_code.TabIndex = 4;
            // 
            // cmb_grower
            // 
            this.cmb_grower.FormattingEnabled = true;
            this.cmb_grower.Location = new System.Drawing.Point(75, 100);
            this.cmb_grower.Name = "cmb_grower";
            this.cmb_grower.Size = new System.Drawing.Size(136, 21);
            this.cmb_grower.TabIndex = 6;
            // 
            // chkdeleted
            // 
            this.chkdeleted.AutoSize = true;
            this.chkdeleted.Location = new System.Drawing.Point(252, 103);
            this.chkdeleted.Name = "chkdeleted";
            this.chkdeleted.Size = new System.Drawing.Size(66, 17);
            this.chkdeleted.TabIndex = 7;
            this.chkdeleted.Text = "Deleted:";
            this.chkdeleted.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(14, 158);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(97, 27);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(129, 158);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(97, 27);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(252, 158);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 27);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // txt_phasedesc
            // 
            this.txt_phasedesc.Location = new System.Drawing.Point(74, 51);
            this.txt_phasedesc.Name = "txt_phasedesc";
            this.txt_phasedesc.Size = new System.Drawing.Size(136, 20);
            this.txt_phasedesc.TabIndex = 11;
            // 
            // frmphase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 219);
            this.Controls.Add(this.txt_phasedesc);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.chkdeleted);
            this.Controls.Add(this.cmb_grower);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmphase";
            this.Text = "Register Phase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_phase;
        private System.Windows.Forms.ComboBox cmb_grower;
        private System.Windows.Forms.CheckBox chkdeleted;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_phasedesc;
    }
}