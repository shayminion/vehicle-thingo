namespace Vehicle_Renting
{
    partial class VehiclesForRent
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
            this.listBoxVehicles = new System.Windows.Forms.ListBox();
            this.btnViewVehicles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMakeYear = new System.Windows.Forms.TextBox();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.txtTotalKm = new System.Windows.Forms.TextBox();
            this.txtTotalServices = new System.Windows.Forms.TextBox();
            this.txtFuelEconomy = new System.Windows.Forms.TextBox();
            this.txtServiceRequired = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicles for Rent";
            // 
            // listBoxVehicles
            // 
            this.listBoxVehicles.FormattingEnabled = true;
            this.listBoxVehicles.Location = new System.Drawing.Point(130, 75);
            this.listBoxVehicles.Name = "listBoxVehicles";
            this.listBoxVehicles.Size = new System.Drawing.Size(262, 95);
            this.listBoxVehicles.TabIndex = 1;
            this.listBoxVehicles.SelectedIndexChanged += new System.EventHandler(this.listBoxVehicles_SelectedIndexChanged);
            // 
            // btnViewVehicles
            // 
            this.btnViewVehicles.Location = new System.Drawing.Point(12, 75);
            this.btnViewVehicles.Name = "btnViewVehicles";
            this.btnViewVehicles.Size = new System.Drawing.Size(102, 23);
            this.btnViewVehicles.TabIndex = 2;
            this.btnViewVehicles.Text = "View Vehicles";
            this.btnViewVehicles.UseVisualStyleBackColor = true;
            this.btnViewVehicles.Click += new System.EventHandler(this.btnViewVehicles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manufacturer:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(346, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(265, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(12, 406);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(247, 23);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin Settings - Currently Unavailable";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(108, 182);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(71, 20);
            this.txtManufacturer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(108, 208);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(71, 20);
            this.txtModel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Make Year:";
            // 
            // txtMakeYear
            // 
            this.txtMakeYear.Location = new System.Drawing.Point(108, 234);
            this.txtMakeYear.Name = "txtMakeYear";
            this.txtMakeYear.Size = new System.Drawing.Size(71, 20);
            this.txtMakeYear.TabIndex = 11;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Location = new System.Drawing.Point(108, 260);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationNo.TabIndex = 12;
            // 
            // txtTotalKm
            // 
            this.txtTotalKm.Location = new System.Drawing.Point(346, 208);
            this.txtTotalKm.Name = "txtTotalKm";
            this.txtTotalKm.Size = new System.Drawing.Size(71, 20);
            this.txtTotalKm.TabIndex = 13;
            // 
            // txtTotalServices
            // 
            this.txtTotalServices.Location = new System.Drawing.Point(346, 234);
            this.txtTotalServices.Name = "txtTotalServices";
            this.txtTotalServices.Size = new System.Drawing.Size(71, 20);
            this.txtTotalServices.TabIndex = 14;
            // 
            // txtFuelEconomy
            // 
            this.txtFuelEconomy.Location = new System.Drawing.Point(99, 340);
            this.txtFuelEconomy.Name = "txtFuelEconomy";
            this.txtFuelEconomy.Size = new System.Drawing.Size(100, 20);
            this.txtFuelEconomy.TabIndex = 15;
            // 
            // txtServiceRequired
            // 
            this.txtServiceRequired.Location = new System.Drawing.Point(346, 260);
            this.txtServiceRequired.Name = "txtServiceRequired";
            this.txtServiceRequired.Size = new System.Drawing.Size(71, 20);
            this.txtServiceRequired.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Registration No.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total KM Travelled:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Services:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fuel Economy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Requires a Service?:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Journey Details -------------------";
            // 
            // VehiclesForRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 496);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServiceRequired);
            this.Controls.Add(this.txtFuelEconomy);
            this.Controls.Add(this.txtTotalServices);
            this.Controls.Add(this.txtTotalKm);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.txtMakeYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewVehicles);
            this.Controls.Add(this.listBoxVehicles);
            this.Controls.Add(this.label1);
            this.Name = "VehiclesForRent";
            this.Text = "Vehicles For Rent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVehicles;
        private System.Windows.Forms.Button btnViewVehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMakeYear;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.TextBox txtTotalKm;
        private System.Windows.Forms.TextBox txtTotalServices;
        private System.Windows.Forms.TextBox txtFuelEconomy;
        private System.Windows.Forms.TextBox txtServiceRequired;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

