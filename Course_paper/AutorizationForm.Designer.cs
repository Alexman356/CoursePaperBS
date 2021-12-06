
namespace Course_paper
{
    partial class AutorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.ButtonAutorization = new System.Windows.Forms.Button();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.TextAutorization = new System.Windows.Forms.Label();
            this.Text_Down1 = new System.Windows.Forms.Label();
            this.RegistrationLabel = new System.Windows.Forms.LinkLabel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAutorization
            // 
            this.ButtonAutorization.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonAutorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAutorization.FlatAppearance.BorderSize = 0;
            this.ButtonAutorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.ButtonAutorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAutorization.Font = new System.Drawing.Font("Candara Light", 14F);
            this.ButtonAutorization.Location = new System.Drawing.Point(89, 261);
            this.ButtonAutorization.Name = "ButtonAutorization";
            this.ButtonAutorization.Size = new System.Drawing.Size(176, 44);
            this.ButtonAutorization.TabIndex = 3;
            this.ButtonAutorization.Text = "Авторизоваться";
            this.ButtonAutorization.UseVisualStyleBackColor = false;
            this.ButtonAutorization.Click += new System.EventHandler(this.ButtonAutorization_Click);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Calibri", 14F);
            this.LoginField.Location = new System.Drawing.Point(68, 111);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(215, 30);
            this.LoginField.TabIndex = 1;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Calibri", 14F);
            this.PassField.Location = new System.Drawing.Point(68, 183);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(215, 30);
            this.PassField.TabIndex = 2;
            this.PassField.Enter += new System.EventHandler(this.PassField_Enter);
            this.PassField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // TextAutorization
            // 
            this.TextAutorization.Font = new System.Drawing.Font("Candara Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAutorization.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TextAutorization.Location = new System.Drawing.Point(50, 24);
            this.TextAutorization.Name = "TextAutorization";
            this.TextAutorization.Size = new System.Drawing.Size(248, 49);
            this.TextAutorization.TabIndex = 0;
            this.TextAutorization.Text = "Авторизация";
            // 
            // Text_Down1
            // 
            this.Text_Down1.AutoSize = true;
            this.Text_Down1.Font = new System.Drawing.Font("Calibri", 11F);
            this.Text_Down1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Text_Down1.Location = new System.Drawing.Point(86, 419);
            this.Text_Down1.Name = "Text_Down1";
            this.Text_Down1.Size = new System.Drawing.Size(97, 18);
            this.Text_Down1.TabIndex = 4;
            this.Text_Down1.Text = "Нет аккаунта?";
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline);
            this.RegistrationLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RegistrationLabel.LinkColor = System.Drawing.SystemColors.ScrollBar;
            this.RegistrationLabel.Location = new System.Drawing.Point(181, 419);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(87, 18);
            this.RegistrationLabel.TabIndex = 0;
            this.RegistrationLabel.TabStop = true;
            this.RegistrationLabel.Text = "Регистрация";
            this.RegistrationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationLabel_LinkClicked);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Candara Light", 14F);
            this.ExitButton.Location = new System.Drawing.Point(89, 338);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(176, 44);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(347, 468);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.Text_Down1);
            this.Controls.Add(this.TextAutorization);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.ButtonAutorization);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 507);
            this.MinimumSize = new System.Drawing.Size(363, 507);
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorizationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAutorization;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Label TextAutorization;
        private System.Windows.Forms.Label Text_Down1;
        private System.Windows.Forms.LinkLabel RegistrationLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

