namespace Spray_application_program
{
    partial class frmHousedetails
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
            this.btnfind = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txthouse = new System.Windows.Forms.TextBox();
            this.txtphase = new System.Windows.Forms.TextBox();
            this.txtbays = new System.Windows.Forms.TextBox();
            this.txt_sprayarea = new System.Windows.Forms.TextBox();
            this.txtcrop = new System.Windows.Forms.TextBox();
            this.txtfog_area = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtp_planting = new System.Windows.Forms.DateTimePicker();
            this.lblhouse_no = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(29, 218);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(92, 23);
            this.btnfind.TabIndex = 1;
            this.btnfind.Text = "FIND";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(454, 217);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(242, 217);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(147, 217);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "House Desc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Crop:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Planting Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phase";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "No of Bays";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Spray Area";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fog Area:";
            // 
            // txthouse
            // 
            this.txthouse.Enabled = false;
            this.txthouse.Location = new System.Drawing.Point(83, 32);
            this.txthouse.Name = "txthouse";
            this.txthouse.Size = new System.Drawing.Size(161, 20);
            this.txthouse.TabIndex = 18;
            // 
            // txtphase
            // 
            this.txtphase.Location = new System.Drawing.Point(370, 128);
            this.txtphase.Name = "txtphase";
            this.txtphase.Size = new System.Drawing.Size(149, 20);
            this.txtphase.TabIndex = 22;
            // 
            // txtbays
            // 
            this.txtbays.Location = new System.Drawing.Point(370, 72);
            this.txtbays.Name = "txtbays";
            this.txtbays.Size = new System.Drawing.Size(149, 20);
            this.txtbays.TabIndex = 23;
            // 
            // txt_sprayarea
            // 
            this.txt_sprayarea.Location = new System.Drawing.Point(376, 29);
            this.txt_sprayarea.Name = "txt_sprayarea";
            this.txt_sprayarea.Size = new System.Drawing.Size(143, 20);
            this.txt_sprayarea.TabIndex = 24;
            // 
            // txtcrop
            // 
            this.txtcrop.Location = new System.Drawing.Point(83, 128);
            this.txtcrop.Name = "txtcrop";
            this.txtcrop.Size = new System.Drawing.Size(161, 20);
            this.txtcrop.TabIndex = 25;
            // 
            // txtfog_area
            // 
            this.txtfog_area.Location = new System.Drawing.Point(83, 72);
            this.txtfog_area.Name = "txtfog_area";
            this.txtfog_area.Size = new System.Drawing.Size(161, 20);
            this.txtfog_area.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(370, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Deleted";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtp_planting
            // 
            this.dtp_planting.Location = new System.Drawing.Point(90, 173);
            this.dtp_planting.Name = "dtp_planting";
            this.dtp_planting.Size = new System.Drawing.Size(154, 20);
            this.dtp_planting.TabIndex = 29;
            // 
            // lblhouse_no
            // 
            this.lblhouse_no.AutoSize = true;
            this.lblhouse_no.Location = new System.Drawing.Point(191, 9);
            this.lblhouse_no.Name = "lblhouse_no";
            this.lblhouse_no.Size = new System.Drawing.Size(0, 13);
            this.lblhouse_no.TabIndex = 30;
            this.lblhouse_no.Visible = false;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(340, 214);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(92, 26);
            this.btn_create.TabIndex = 31;
            this.btn_create.Text = "CREATE";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // frmHousedetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 253);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lblhouse_no);
            this.Controls.Add(this.dtp_planting);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtfog_area);
            this.Controls.Add(this.txtcrop);
            this.Controls.Add(this.txt_sprayarea);
            this.Controls.Add(this.txtbays);
            this.Controls.Add(this.txtphase);
            this.Controls.Add(this.txthouse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnfind);
            this.Name = "frmHousedetails";
            this.Text = "House Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtphase;
        private System.Windows.Forms.TextBox txtbays;
        private System.Windows.Forms.TextBox txt_sprayarea;
        private System.Windows.Forms.TextBox txtcrop;
        private System.Windows.Forms.TextBox txtfog_area;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txthouse;
        private System.Windows.Forms.DateTimePicker dtp_planting;
        private System.Windows.Forms.Label lblhouse_no;
        private System.Windows.Forms.Button btn_create;
    }
}