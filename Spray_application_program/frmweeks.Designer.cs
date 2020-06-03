namespace Spray_application_program
{
    partial class frmweeks
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tradeyear = new System.Windows.Forms.TextBox();
            this.txt_endwk = new System.Windows.Forms.TextBox();
            this.txt_startwk = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.grd_calendar = new System.Windows.Forms.DataGridView();
            this.Week_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trading Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trading Week Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Week No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Week No:";
            // 
            // txt_tradeyear
            // 
            this.txt_tradeyear.Location = new System.Drawing.Point(176, 10);
            this.txt_tradeyear.Name = "txt_tradeyear";
            this.txt_tradeyear.Size = new System.Drawing.Size(144, 20);
            this.txt_tradeyear.TabIndex = 4;
            // 
            // txt_endwk
            // 
            this.txt_endwk.Location = new System.Drawing.Point(176, 102);
            this.txt_endwk.Name = "txt_endwk";
            this.txt_endwk.Size = new System.Drawing.Size(144, 20);
            this.txt_endwk.TabIndex = 5;
            // 
            // txt_startwk
            // 
            this.txt_startwk.Location = new System.Drawing.Point(176, 76);
            this.txt_startwk.Name = "txt_startwk";
            this.txt_startwk.Size = new System.Drawing.Size(144, 20);
            this.txt_startwk.TabIndex = 6;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(176, 46);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(144, 20);
            this.dtp_date.TabIndex = 7;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(9, 144);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(113, 24);
            this.btn_generate.TabIndex = 8;
            this.btn_generate.Text = "Generate Calendar";
            this.btn_generate.UseVisualStyleBackColor = true;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(142, 144);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(113, 24);
            this.btn_view.TabIndex = 9;
            this.btn_view.Text = "View Calendar";
            this.btn_view.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(264, 144);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(113, 24);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // grd_calendar
            // 
            this.grd_calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_calendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Week_No,
            this.Start_Date,
            this.End_date,
            this.Year});
            this.grd_calendar.Location = new System.Drawing.Point(4, 185);
            this.grd_calendar.Name = "grd_calendar";
            this.grd_calendar.Size = new System.Drawing.Size(393, 238);
            this.grd_calendar.TabIndex = 11;
            // 
            // Week_No
            // 
            this.Week_No.HeaderText = "Week_No";
            this.Week_No.Name = "Week_No";
            this.Week_No.ReadOnly = true;
            // 
            // Start_Date
            // 
            this.Start_Date.HeaderText = "Start_Date";
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.ReadOnly = true;
            // 
            // End_date
            // 
            this.End_date.HeaderText = "End_date";
            this.End_date.Name = "End_date";
            this.End_date.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // frmweeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 435);
            this.Controls.Add(this.grd_calendar);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_startwk);
            this.Controls.Add(this.txt_endwk);
            this.Controls.Add(this.txt_tradeyear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmweeks";
            this.Text = "frmweeks";
            ((System.ComponentModel.ISupportInitialize)(this.grd_calendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tradeyear;
        private System.Windows.Forms.TextBox txt_endwk;
        private System.Windows.Forms.TextBox txt_startwk;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView grd_calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;

    }
}