namespace CarParking
{
    partial class Customer_parking
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
            this.title_label = new System.Windows.Forms.Label();
            this.Display_current_ticket_button = new System.Windows.Forms.Button();
            this.Park_car_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(283, 24);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(201, 16);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Customer Park Car Management";
            // 
            // Display_current_ticket_button
            // 
            this.Display_current_ticket_button.Location = new System.Drawing.Point(29, 84);
            this.Display_current_ticket_button.Name = "Display_current_ticket_button";
            this.Display_current_ticket_button.Size = new System.Drawing.Size(140, 23);
            this.Display_current_ticket_button.TabIndex = 1;
            this.Display_current_ticket_button.Text = "Prinf current ticket";
            this.Display_current_ticket_button.UseVisualStyleBackColor = true;
            this.Display_current_ticket_button.Click += new System.EventHandler(this.Display_current_ticket_button_Click);
            // 
            // Park_car_button
            // 
            this.Park_car_button.Location = new System.Drawing.Point(29, 140);
            this.Park_car_button.Name = "Park_car_button";
            this.Park_car_button.Size = new System.Drawing.Size(140, 23);
            this.Park_car_button.TabIndex = 2;
            this.Park_car_button.Text = "Park car";
            this.Park_car_button.UseVisualStyleBackColor = true;
            this.Park_car_button.Click += new System.EventHandler(this.Park_car_button_Click);
            // 
            // Customer_parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Park_car_button);
            this.Controls.Add(this.Display_current_ticket_button);
            this.Controls.Add(this.title_label);
            this.Name = "Customer_parking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_parking";
            this.Load += new System.EventHandler(this.Customer_parking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button Display_current_ticket_button;
        private System.Windows.Forms.Button Park_car_button;
    }
}