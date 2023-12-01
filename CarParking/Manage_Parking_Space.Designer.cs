namespace CarParking
{
    partial class Manage_Parking_Space
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title_in4_label = new System.Windows.Forms.Label();
            this.pakingDataSet = new CarParking.pakingDataSet();
            this.parkingSpaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingSpaceTableAdapter = new CarParking.pakingDataSetTableAdapters.ParkingSpaceTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCarusingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateComeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.iDCarusingDataGridViewTextBoxColumn,
            this.dateComeDataGridViewTextBoxColumn,
            this.dateLeaveDataGridViewTextBoxColumn,
            this.revenueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parkingSpaceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // Title_in4_label
            // 
            this.Title_in4_label.AutoSize = true;
            this.Title_in4_label.Location = new System.Drawing.Point(13, 230);
            this.Title_in4_label.Name = "Title_in4_label";
            this.Title_in4_label.Size = new System.Drawing.Size(265, 16);
            this.Title_in4_label.TabIndex = 1;
            this.Title_in4_label.Text = "Information about the current parking space:";
            // 
            // pakingDataSet
            // 
            this.pakingDataSet.DataSetName = "pakingDataSet";
            this.pakingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingSpaceBindingSource
            // 
            this.parkingSpaceBindingSource.DataMember = "ParkingSpace";
            this.parkingSpaceBindingSource.DataSource = this.pakingDataSet;
            // 
            // parkingSpaceTableAdapter
            // 
            this.parkingSpaceTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCarusingDataGridViewTextBoxColumn
            // 
            this.iDCarusingDataGridViewTextBoxColumn.DataPropertyName = "ID_Car_using";
            this.iDCarusingDataGridViewTextBoxColumn.HeaderText = "ID_Car_using";
            this.iDCarusingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCarusingDataGridViewTextBoxColumn.Name = "iDCarusingDataGridViewTextBoxColumn";
            this.iDCarusingDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateComeDataGridViewTextBoxColumn
            // 
            this.dateComeDataGridViewTextBoxColumn.DataPropertyName = "Date_Come";
            this.dateComeDataGridViewTextBoxColumn.HeaderText = "Date_Come";
            this.dateComeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateComeDataGridViewTextBoxColumn.Name = "dateComeDataGridViewTextBoxColumn";
            this.dateComeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateLeaveDataGridViewTextBoxColumn
            // 
            this.dateLeaveDataGridViewTextBoxColumn.DataPropertyName = "Date_Leave";
            this.dateLeaveDataGridViewTextBoxColumn.HeaderText = "Date_Leave";
            this.dateLeaveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateLeaveDataGridViewTextBoxColumn.Name = "dateLeaveDataGridViewTextBoxColumn";
            this.dateLeaveDataGridViewTextBoxColumn.Width = 125;
            // 
            // revenueDataGridViewTextBoxColumn
            // 
            this.revenueDataGridViewTextBoxColumn.DataPropertyName = "Revenue";
            this.revenueDataGridViewTextBoxColumn.HeaderText = "Revenue";
            this.revenueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.revenueDataGridViewTextBoxColumn.Name = "revenueDataGridViewTextBoxColumn";
            this.revenueDataGridViewTextBoxColumn.Width = 125;
            // 
            // Manage_Parking_Space
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title_in4_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manage_Parking_Space";
            this.Text = "Manage_Parking_Space";
            this.Load += new System.EventHandler(this.Manage_Parking_Space_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSpaceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Title_in4_label;
        private pakingDataSet pakingDataSet;
        private System.Windows.Forms.BindingSource parkingSpaceBindingSource;
        private pakingDataSetTableAdapters.ParkingSpaceTableAdapter parkingSpaceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCarusingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateComeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenueDataGridViewTextBoxColumn;
    }
}