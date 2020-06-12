namespace Spray_application_program
{
    partial class frmchemtargets
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.chk_deleted = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.cbotarget = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbochem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsttargets = new System.Windows.Forms.ListView();
            this.TARGET = new System.Windows.Forms.ColumnHeader();
            this.targettext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.chk_deleted);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_desc);
            this.panel1.Controls.Add(this.txt_code);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 144);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(207, 113);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(71, 28);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(105, 112);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(71, 28);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(14, 115);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(71, 28);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // chk_deleted
            // 
            this.chk_deleted.AutoSize = true;
            this.chk_deleted.Location = new System.Drawing.Point(96, 89);
            this.chk_deleted.Name = "chk_deleted";
            this.chk_deleted.Size = new System.Drawing.Size(63, 17);
            this.chk_deleted.TabIndex = 5;
            this.chk_deleted.Text = "Deleted";
            this.chk_deleted.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Target Name";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(96, 62);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(153, 20);
            this.txt_desc.TabIndex = 3;
            // 
            // txt_code
            // 
            this.txt_code.Enabled = false;
            this.txt_code.Location = new System.Drawing.Point(96, 29);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(153, 20);
            this.txt_code.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Target ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD TARGET";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_retrieve);
            this.panel2.Controls.Add(this.cbotarget);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbochem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 144);
            this.panel2.TabIndex = 1;
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(97, 111);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(56, 27);
            this.btn_retrieve.TabIndex = 11;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // cbotarget
            // 
            this.cbotarget.FormattingEnabled = true;
            this.cbotarget.Location = new System.Drawing.Point(104, 68);
            this.cbotarget.Name = "cbotarget";
            this.cbotarget.Size = new System.Drawing.Size(144, 21);
            this.cbotarget.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(166, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 28);
            this.button5.TabIndex = 10;
            this.button5.Text = "Delete Target";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 28);
            this.button6.TabIndex = 9;
            this.button6.Text = "Add Target";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Target";
            // 
            // cbochem
            // 
            this.cbochem.FormattingEnabled = true;
            this.cbochem.Location = new System.Drawing.Point(104, 30);
            this.cbochem.Name = "cbochem";
            this.cbochem.Size = new System.Drawing.Size(144, 21);
            this.cbochem.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chemical";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHEMICAL TARGETS";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsttargets);
            this.panel3.Controls.Add(this.targettext);
            this.panel3.Location = new System.Drawing.Point(293, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 291);
            this.panel3.TabIndex = 1;
            // 
            // lsttargets
            // 
            this.lsttargets.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lsttargets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TARGET});
            this.lsttargets.Location = new System.Drawing.Point(3, 19);
            this.lsttargets.Name = "lsttargets";
            this.lsttargets.Size = new System.Drawing.Size(177, 267);
            this.lsttargets.TabIndex = 1;
            this.lsttargets.UseCompatibleStateImageBehavior = false;
            this.lsttargets.SelectedIndexChanged += new System.EventHandler(this.lsttargets_SelectedIndexChanged);
            // 
            // targettext
            // 
            this.targettext.AutoSize = true;
            this.targettext.Location = new System.Drawing.Point(13, 3);
            this.targettext.Name = "targettext";
            this.targettext.Size = new System.Drawing.Size(0, 13);
            this.targettext.TabIndex = 2;
            // 
            // frmchemtargets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 298);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmchemtargets";
            this.Text = "frmchemtargets";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label targettext;
        private System.Windows.Forms.ListView lsttargets;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.CheckBox chk_deleted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbotarget;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbochem;
        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.ColumnHeader TARGET;
    }
}