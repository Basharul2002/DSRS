namespace DSRS
{
    partial class Form9
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
            this.customer_data_dgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger Information";
            // 
            // customer_data_dgv
            // 
            this.customer_data_dgv.AllowUserToAddRows = false;
            this.customer_data_dgv.AllowUserToDeleteRows = false;
            this.customer_data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_data_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.email,
            this.phoneNumber,
            this.dob,
            this.nid,
            this.password});
            this.customer_data_dgv.Location = new System.Drawing.Point(329, 50);
            this.customer_data_dgv.Name = "customer_data_dgv";
            this.customer_data_dgv.ReadOnly = true;
            this.customer_data_dgv.Size = new System.Drawing.Size(493, 306);
            this.customer_data_dgv.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.HeaderText = "DOB";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // nid
            // 
            this.nid.HeaderText = "NID";
            this.nid.Name = "nid";
            this.nid.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSRS.Properties.Resources.businessman_standing_with_setting_icon_on_yellow_background_project_management_and_processing_concept_business_planning_and_strategy_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 554);
            this.Controls.Add(this.customer_data_dgv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.customer_data_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customer_data_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}