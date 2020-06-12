namespace Spray_application_program
{
    partial class frmchemtypes1
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
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.chkdeleted = new System.Windows.Forms.CheckBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(85, 55);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(152, 20);
            this.txt_desc.TabIndex = 19;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(258, 115);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 27);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(135, 115);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(97, 27);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(20, 115);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(97, 27);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // chkdeleted
            // 
            this.chkdeleted.AutoSize = true;
            this.chkdeleted.Location = new System.Drawing.Point(85, 90);
            this.chkdeleted.Name = "chkdeleted";
            this.chkdeleted.Size = new System.Drawing.Size(66, 17);
            this.chkdeleted.TabIndex = 15;
            this.chkdeleted.Text = "Deleted:";
            this.chkdeleted.UseVisualStyleBackColor = true;
            // 
            // txt_code
            // 
            this.txt_code.Enabled = false;
            this.txt_code.Location = new System.Drawing.Point(85, 13);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 20);
            this.txt_code.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = " Code:";
            // 
            // frmchemtypes1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 161);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.chkdeleted);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmchemtypes1";
            this.Text = "frmchemtypes1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.CheckBox chkdeleted;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}