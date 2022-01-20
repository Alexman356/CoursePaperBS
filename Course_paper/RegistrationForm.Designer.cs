
namespace CoursePaper
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.RegistrationLabel = new System.Windows.Forms.LinkLabel();
            this.TextAutorization = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.ButtonRegistration = new System.Windows.Forms.Button();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.Text_Down1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline);
            this.RegistrationLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RegistrationLabel.LinkColor = System.Drawing.SystemColors.ScrollBar;
            this.RegistrationLabel.Location = new System.Drawing.Point(223, 583);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(46, 18);
            this.RegistrationLabel.TabIndex = 0;
            this.RegistrationLabel.TabStop = true;
            this.RegistrationLabel.Text = "Войти";
            this.RegistrationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToRegistrationClick);
            // 
            // TextAutorization
            // 
            this.TextAutorization.Font = new System.Drawing.Font("Candara Light", 30F);
            this.TextAutorization.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TextAutorization.Location = new System.Drawing.Point(58, 27);
            this.TextAutorization.Name = "TextAutorization";
            this.TextAutorization.Size = new System.Drawing.Size(248, 49);
            this.TextAutorization.TabIndex = 10;
            this.TextAutorization.Text = "Регистрация";
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Calibri", 14F);
            this.PassField.Location = new System.Drawing.Point(67, 356);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(215, 30);
            this.PassField.TabIndex = 4;
            this.PassField.Enter += new System.EventHandler(this.PassFieldEnter);
            this.PassField.Leave += new System.EventHandler(this.PassFieldLeave);
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Calibri", 14F);
            this.NameField.Location = new System.Drawing.Point(67, 126);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(215, 30);
            this.NameField.TabIndex = 1;
            this.NameField.Enter += new System.EventHandler(this.NameFieldEnter);
            this.NameField.Leave += new System.EventHandler(this.NameFieldLeave);
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegistration.FlatAppearance.BorderSize = 0;
            this.ButtonRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.ButtonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegistration.Font = new System.Drawing.Font("Candara Light", 14F);
            this.ButtonRegistration.Location = new System.Drawing.Point(67, 428);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(215, 41);
            this.ButtonRegistration.TabIndex = 5;
            this.ButtonRegistration.Text = "Зарегистрироваться";
            this.ButtonRegistration.UseVisualStyleBackColor = false;
            this.ButtonRegistration.Click += new System.EventHandler(this.BtnRegistrationClick);
            // 
            // SurnameField
            // 
            this.SurnameField.Font = new System.Drawing.Font("Calibri", 14F);
            this.SurnameField.Location = new System.Drawing.Point(67, 201);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(215, 30);
            this.SurnameField.TabIndex = 2;
            this.SurnameField.Enter += new System.EventHandler(this.SurnameFieldEnter);
            this.SurnameField.Leave += new System.EventHandler(this.SurnameFieldLeave);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Calibri", 14F);
            this.LoginField.Location = new System.Drawing.Point(67, 278);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(215, 30);
            this.LoginField.TabIndex = 3;
            this.LoginField.Enter += new System.EventHandler(this.LoginFieldEnter);
            this.LoginField.Leave += new System.EventHandler(this.LoginFieldLeave);
            // 
            // Text_Down1
            // 
            this.Text_Down1.AutoSize = true;
            this.Text_Down1.Font = new System.Drawing.Font("Calibri", 11F);
            this.Text_Down1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Text_Down1.Location = new System.Drawing.Point(64, 583);
            this.Text_Down1.Name = "Text_Down1";
            this.Text_Down1.Size = new System.Drawing.Size(162, 18);
            this.Text_Down1.TabIndex = 0;
            this.Text_Down1.Text = "Уже зарегистрированы?";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Candara Light", 14F);
            this.ExitButton.Location = new System.Drawing.Point(67, 507);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(215, 41);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(349, 648);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.Text_Down1);
            this.Controls.Add(this.TextAutorization);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.ButtonRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(365, 687);
            this.MinimumSize = new System.Drawing.Size(365, 687);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextAutorization;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Button ButtonRegistration;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox LoginField;
        public System.Windows.Forms.LinkLabel RegistrationLabel;
        private System.Windows.Forms.Label Text_Down1;
        private System.Windows.Forms.Button ExitButton;
    }
}