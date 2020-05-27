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
            ((System.ComponentModel.ISupportInitialize)(this.grdhouses)).BeginInit();
            this.SuspendLayout();
            // 
            // grdhouses
            // 
            this.grdhouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdhouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.empnumb});
            this.grdhouses.Location = new System.Drawing.Point(2, 151);
            this.grdhouses.Name = "grdhouses";
            this.grdhouses.Size = new System.Drawing.Size(572, 213);
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
            // Housedetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 399);
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
    }
}