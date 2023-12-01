namespace CarParking
{
    partial class Ticket
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
            this.label_ticket = new System.Windows.Forms.Label();
            this.label_owner = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label_in = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ticket
            // 
            this.label_ticket.AutoSize = true;
            this.label_ticket.Location = new System.Drawing.Point(34, 43);
            this.label_ticket.Name = "label_ticket";
            this.label_ticket.Size = new System.Drawing.Size(60, 16);
            this.label_ticket.TabIndex = 0;
            this.label_ticket.Text = "ID Ticket";
            // 
            // label_owner
            // 
            this.label_owner.AutoSize = true;
            this.label_owner.Location = new System.Drawing.Point(34, 94);
            this.label_owner.Name = "label_owner";
            this.label_owner.Size = new System.Drawing.Size(61, 16);
            this.label_owner.TabIndex = 1;
            this.label_owner.Text = "ID Owner";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(213, 94);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 16);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Name";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(37, 148);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(58, 16);
            this.label_location.TabIndex = 3;
            this.label_location.Text = "Location";
            // 
            // label_in
            // 
            this.label_in.AutoSize = true;
            this.label_in.Location = new System.Drawing.Point(37, 206);
            this.label_in.Name = "label_in";
            this.label_in.Size = new System.Drawing.Size(45, 16);
            this.label_in.TabIndex = 4;
            this.label_in.Text = "time in";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(213, 148);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(33, 16);
            this.label_type.TabIndex = 5;
            this.label_type.Text = "type";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(469, 148);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(37, 16);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "price";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_in);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_owner);
            this.Controls.Add(this.label_ticket);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ticket;
        private System.Windows.Forms.Label label_owner;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label_in;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_price;
    }
}