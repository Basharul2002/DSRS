namespace DSRS
{
    partial class Form3
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
            this.registration_btn = new System.Windows.Forms.Button();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.dob_txt = new System.Windows.Forms.TextBox();
            this.nid_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.number_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirm_password_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gender_panel = new System.Windows.Forms.TextBox();
            this.male_rb = new System.Windows.Forms.RadioButton();
            this.female_rb = new System.Windows.Forms.RadioButton();
            this.others_rb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // registration_btn
            // 
            this.registration_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_btn.Location = new System.Drawing.Point(302, 443);
            this.registration_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registration_btn.Name = "registration_btn";
            this.registration_btn.Size = new System.Drawing.Size(168, 37);
            this.registration_btn.TabIndex = 0;
            this.registration_btn.Text = "Registration";
            this.registration_btn.UseVisualStyleBackColor = true;
            this.registration_btn.Click += new System.EventHandler(this.registration_btn_Click);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(407, 119);
            this.name_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_txt.Multiline = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(183, 24);
            this.name_txt.TabIndex = 2;
            // 
            // dob_txt
            // 
            this.dob_txt.Location = new System.Drawing.Point(407, 154);
            this.dob_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dob_txt.Multiline = true;
            this.dob_txt.Name = "dob_txt";
            this.dob_txt.Size = new System.Drawing.Size(183, 27);
            this.dob_txt.TabIndex = 3;
            // 
            // nid_txt
            // 
            this.nid_txt.Location = new System.Drawing.Point(407, 228);
            this.nid_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nid_txt.Multiline = true;
            this.nid_txt.Name = "nid_txt";
            this.nid_txt.Size = new System.Drawing.Size(183, 27);
            this.nid_txt.TabIndex = 4;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(407, 266);
            this.email_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_txt.Multiline = true;
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(183, 27);
            this.email_txt.TabIndex = 5;
            // 
            // number_txt
            // 
            this.number_txt.Location = new System.Drawing.Point(407, 302);
            this.number_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.number_txt.Multiline = true;
            this.number_txt.Name = "number_txt";
            this.number_txt.Size = new System.Drawing.Size(183, 27);
            this.number_txt.TabIndex = 6;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(407, 344);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_txt.Multiline = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(183, 27);
            this.password_txt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date of Birth";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "NID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 384);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Confirm Password";
            // 
            // confirm_password_txt
            // 
            this.confirm_password_txt.Location = new System.Drawing.Point(407, 382);
            this.confirm_password_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirm_password_txt.Multiline = true;
            this.confirm_password_txt.Name = "confirm_password_txt";
            this.confirm_password_txt.Size = new System.Drawing.Size(183, 27);
            this.confirm_password_txt.TabIndex = 15;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(84, 443);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(93, 37);
            this.login_btn.TabIndex = 16;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(9, 10);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(64, 32);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "<<";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(196, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Gender";
            // 
            // gender_panel
            // 
            this.gender_panel.Location = new System.Drawing.Point(407, 191);
            this.gender_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gender_panel.Multiline = true;
            this.gender_panel.Name = "gender_panel";
            this.gender_panel.Size = new System.Drawing.Size(183, 27);
            this.gender_panel.TabIndex = 19;
            // 
            // male_rb
            // 
            this.male_rb.AutoSize = true;
            this.male_rb.Location = new System.Drawing.Point(416, 196);
            this.male_rb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.male_rb.Name = "male_rb";
            this.male_rb.Size = new System.Drawing.Size(48, 17);
            this.male_rb.TabIndex = 20;
            this.male_rb.TabStop = true;
            this.male_rb.Text = "Male";
            this.male_rb.UseVisualStyleBackColor = true;
            // 
            // female_rb
            // 
            this.female_rb.AutoSize = true;
            this.female_rb.Location = new System.Drawing.Point(469, 196);
            this.female_rb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.female_rb.Name = "female_rb";
            this.female_rb.Size = new System.Drawing.Size(59, 17);
            this.female_rb.TabIndex = 21;
            this.female_rb.TabStop = true;
            this.female_rb.Text = "Female";
            this.female_rb.UseVisualStyleBackColor = true;
            // 
            // others_rb
            // 
            this.others_rb.AutoSize = true;
            this.others_rb.Location = new System.Drawing.Point(532, 196);
            this.others_rb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.others_rb.Name = "others_rb";
            this.others_rb.Size = new System.Drawing.Size(56, 17);
            this.others_rb.TabIndex = 22;
            this.others_rb.TabStop = true;
            this.others_rb.Text = "Others";
            this.others_rb.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DSRS.Properties.Resources.Media;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 554);
            this.Controls.Add(this.others_rb);
            this.Controls.Add(this.female_rb);
            this.Controls.Add(this.male_rb);
            this.Controls.Add(this.gender_panel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.confirm_password_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.number_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.nid_txt);
            this.Controls.Add(this.dob_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.registration_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registration_btn;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox dob_txt;
        private System.Windows.Forms.TextBox nid_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox number_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox confirm_password_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gender_panel;
        private System.Windows.Forms.RadioButton male_rb;
        private System.Windows.Forms.RadioButton female_rb;
        private System.Windows.Forms.RadioButton others_rb;
    }
}