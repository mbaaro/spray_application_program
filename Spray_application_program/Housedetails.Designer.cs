namespace Spray_application_program
{
    partial class Housedetails
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
            this.grdhouses = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.empnumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdhouses)).BeginInit();
            this.SuspendLayout();
            // 
            // grdhouses
            // 
            this.grdhouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdhouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.empnumb});
            this.grdhouses.Location = new System.Drawing.Point(2, 1);
            this.grdhouses.Name = "grdhouses";
            this.grdhouses.Size = new System.Drawing.Size(566, 331);
            this.grdhouses.TabIndex = 0;
            this.grdhouses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdhouses_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "name1";
            this.name.Name = "name";
            // 
            // empnumb
            // 
            this.empnumb.HeaderText = "empnumb";
            this.empnumb.Name = "empnumb";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(13, 350);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(92, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "ADD ROW";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(179, 350);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(340, 350);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(464, 350);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "button4";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // Housedetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 399);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.grdhouses);
            this.Name = "Housedetails";
            this.Text = "Housedetails";
            ((System.ComponentModel.ISupportInitialize)(this.grdhouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdhouses;
        private System.Windows.Forms.DataGridViewComboBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnumb;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclose;
    }
}