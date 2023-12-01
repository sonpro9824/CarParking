namespace CarParking
{
    partial class Attendant_Parking
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
            this.data121DataSet = new CarParking.Data121DataSet();
            this.waitingTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waiting_TicketTableAdapter = new CarParking.Data121DataSetTableAdapters.Waiting_TicketTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ticket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.data121DataSet1 = new CarParking.Data121DataSet1();
            this.waitingTicketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.waiting_TicketTableAdapter1 = new CarParking.Data121DataSet1TableAdapters.Waiting_TicketTableAdapter();
            this.data121DataSet2 = new CarParking.Data121DataSet2();
            this.waitingTicketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.waiting_TicketTableAdapter2 = new CarParking.Data121DataSet2TableAdapters.Waiting_TicketTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.button_xuatVe = new System.Windows.Forms.Button();
            this.textBox_owner = new System.Windows.Forms.TextBox();
            this.textBox_car = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox5_In = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data121DataSet3 = new CarParking.Data121DataSet3();
            this.waitingTicketBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.waiting_TicketTableAdapter3 = new CarParking.Data121DataSet3TableAdapters.Waiting_TicketTableAdapter();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickettypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEntryTicketDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data121DataSet4 = new CarParking.Data121DataSet4();
            this.waitingTicketBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.waiting_TicketTableAdapter4 = new CarParking.Data121DataSet4TableAdapters.Waiting_TicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // data121DataSet
            // 
            this.data121DataSet.DataSetName = "Data121DataSet";
            this.data121DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waitingTicketBindingSource
            // 
            this.waitingTicketBindingSource.DataMember = "Waiting_Ticket";
            this.waitingTicketBindingSource.DataSource = this.data121DataSet;
            // 
            // waiting_TicketTableAdapter
            // 
            this.waiting_TicketTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Ticket";
            // 
            // textBox_ticket
            // 
            this.textBox_ticket.Location = new System.Drawing.Point(111, 32);
            this.textBox_ticket.Name = "textBox_ticket";
            this.textBox_ticket.Size = new System.Drawing.Size(153, 22);
            this.textBox_ticket.TabIndex = 2;
            this.textBox_ticket.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ticket_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ticket type";
            // 
            // data121DataSet1
            // 
            this.data121DataSet1.DataSetName = "Data121DataSet1";
            this.data121DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waitingTicketBindingSource1
            // 
            this.waitingTicketBindingSource1.DataMember = "Waiting_Ticket";
            this.waitingTicketBindingSource1.DataSource = this.data121DataSet1;
            // 
            // waiting_TicketTableAdapter1
            // 
            this.waiting_TicketTableAdapter1.ClearBeforeFill = true;
            // 
            // data121DataSet2
            // 
            this.data121DataSet2.DataSetName = "Data121DataSet2";
            this.data121DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waitingTicketBindingSource2
            // 
            this.waitingTicketBindingSource2.DataMember = "Waiting_Ticket";
            this.waitingTicketBindingSource2.DataSource = this.data121DataSet2;
            // 
            // waiting_TicketTableAdapter2
            // 
            this.waiting_TicketTableAdapter2.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Time In";
            // 
            // button_xuatVe
            // 
            this.button_xuatVe.Location = new System.Drawing.Point(729, 57);
            this.button_xuatVe.Name = "button_xuatVe";
            this.button_xuatVe.Size = new System.Drawing.Size(96, 37);
            this.button_xuatVe.TabIndex = 13;
            this.button_xuatVe.Text = "Xuất";
            this.button_xuatVe.UseVisualStyleBackColor = true;
            this.button_xuatVe.Click += new System.EventHandler(this.button_xuatVe_Click);
            // 
            // textBox_owner
            // 
            this.textBox_owner.Location = new System.Drawing.Point(111, 72);
            this.textBox_owner.Name = "textBox_owner";
            this.textBox_owner.Size = new System.Drawing.Size(153, 22);
            this.textBox_owner.TabIndex = 14;
            // 
            // textBox_car
            // 
            this.textBox_car.Location = new System.Drawing.Point(111, 113);
            this.textBox_car.Name = "textBox_car";
            this.textBox_car.Size = new System.Drawing.Size(153, 22);
            this.textBox_car.TabIndex = 15;
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(111, 157);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(153, 22);
            this.textBox_type.TabIndex = 16;
            // 
            // textBox5_In
            // 
            this.textBox5_In.Location = new System.Drawing.Point(431, 75);
            this.textBox5_In.Name = "textBox5_In";
            this.textBox5_In.Size = new System.Drawing.Size(153, 22);
            this.textBox5_In.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Location";
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(431, 125);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(153, 22);
            this.textBox_location.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.ownerIDDataGridViewTextBoxColumn,
            this.carIDDataGridViewTextBoxColumn,
            this.tickettypeDataGridViewTextBoxColumn,
            this.isEntryTicketDataGridViewCheckBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.locationIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.waitingTicketBindingSource4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(903, 315);
            this.dataGridView1.TabIndex = 20;
            // 
            // data121DataSet3
            // 
            this.data121DataSet3.DataSetName = "Data121DataSet3";
            this.data121DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waitingTicketBindingSource3
            // 
            this.waitingTicketBindingSource3.DataMember = "Waiting_Ticket";
            this.waitingTicketBindingSource3.DataSource = this.data121DataSet3;
            // 
            // waiting_TicketTableAdapter3
            // 
            this.waiting_TicketTableAdapter3.ClearBeforeFill = true;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "Ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ownerIDDataGridViewTextBoxColumn
            // 
            this.ownerIDDataGridViewTextBoxColumn.DataPropertyName = "Owner_ID";
            this.ownerIDDataGridViewTextBoxColumn.HeaderText = "Owner_ID";
            this.ownerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerIDDataGridViewTextBoxColumn.Name = "ownerIDDataGridViewTextBoxColumn";
            this.ownerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "Car_ID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "Car_ID";
            this.carIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tickettypeDataGridViewTextBoxColumn
            // 
            this.tickettypeDataGridViewTextBoxColumn.DataPropertyName = "Ticket_type";
            this.tickettypeDataGridViewTextBoxColumn.HeaderText = "Ticket_type";
            this.tickettypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tickettypeDataGridViewTextBoxColumn.Name = "tickettypeDataGridViewTextBoxColumn";
            this.tickettypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isEntryTicketDataGridViewCheckBoxColumn
            // 
            this.isEntryTicketDataGridViewCheckBoxColumn.DataPropertyName = "Is_Entry_Ticket";
            this.isEntryTicketDataGridViewCheckBoxColumn.HeaderText = "Is_Entry_Ticket";
            this.isEntryTicketDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isEntryTicketDataGridViewCheckBoxColumn.Name = "isEntryTicketDataGridViewCheckBoxColumn";
            this.isEntryTicketDataGridViewCheckBoxColumn.Width = 125;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "Time_In";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "Time_In";
            this.timeInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "Time_Out";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "Time_Out";
            this.timeOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            this.locationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // data121DataSet4
            // 
            this.data121DataSet4.DataSetName = "Data121DataSet4";
            this.data121DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waitingTicketBindingSource4
            // 
            this.waitingTicketBindingSource4.DataMember = "Waiting_Ticket";
            this.waitingTicketBindingSource4.DataSource = this.data121DataSet4;
            // 
            // waiting_TicketTableAdapter4
            // 
            this.waiting_TicketTableAdapter4.ClearBeforeFill = true;
            // 
            // Attendant_Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5_In);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.textBox_car);
            this.Controls.Add(this.textBox_owner);
            this.Controls.Add(this.button_xuatVe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ticket);
            this.Controls.Add(this.label1);
            this.Name = "Attendant_Parking";
            this.Text = "Attendant_Parking";
            this.Load += new System.EventHandler(this.Attendant_Parking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data121DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitingTicketBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Data121DataSet data121DataSet;
        private System.Windows.Forms.BindingSource waitingTicketBindingSource;
        private Data121DataSetTableAdapters.Waiting_TicketTableAdapter waiting_TicketTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ticket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Data121DataSet1 data121DataSet1;
        private System.Windows.Forms.BindingSource waitingTicketBindingSource1;
        private Data121DataSet1TableAdapters.Waiting_TicketTableAdapter waiting_TicketTableAdapter1;
        private Data121DataSet2 data121DataSet2;
        private System.Windows.Forms.BindingSource waitingTicketBindingSource2;
        private Data121DataSet2TableAdapters.Waiting_TicketTableAdapter waiting_TicketTableAdapter2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_xuatVe;
        private System.Windows.Forms.TextBox textBox_owner;
        private System.Windows.Forms.TextBox textBox_car;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.TextBox textBox5_In;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Data121DataSet3 data121DataSet3;
        private System.Windows.Forms.BindingSource waitingTicketBindingSource3;
        private Data121DataSet3TableAdapters.Waiting_TicketTableAdapter waiting_TicketTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickettypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEntryTicketDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Data121DataSet4 data121DataSet4;
        private System.Windows.Forms.BindingSource waitingTicketBindingSource4;
        private Data121DataSet4TableAdapters.Waiting_TicketTableAdapter waiting_TicketTableAdapter4;
    }
}