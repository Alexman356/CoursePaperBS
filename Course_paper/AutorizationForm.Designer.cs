
namespace CoursePaper
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
            this.btnAutorization = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.lblAutorization = new System.Windows.Forms.Label();
            this.linkToRegistration = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutorization
            // 
            this.btnAutorization.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAutorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutorization.FlatAppearance.BorderSize = 0;
            this.btnAutorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.btnAutorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorization.Font = new System.Drawing.Font("Candara Light", 14F);
            this.btnAutorization.Location = new System.Drawing.Point(89, 261);
            this.btnAutorization.Name = "btnAutorization";
            this.btnAutorization.Size = new System.Drawing.Size(176, 44);
            this.btnAutorization.TabIndex = 3;
            this.btnAutorization.Text = "Авторизоваться";
            this.btnAutorization.UseVisualStyleBackColor = false;
            this.btnAutorization.Click += new System.EventHandler(this.BtnAutorizationClick);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Calibri", 14F);
            this.loginField.Location = new System.Drawing.Point(68, 111);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(215, 30);
            this.loginField.TabIndex = 1;
            this.loginField.Enter += new System.EventHandler(this.LoginFieldEnter);
            this.loginField.Leave += new System.EventHandler(this.LoginFieldLeave);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Calibri", 14F);
            this.passField.Location = new System.Drawing.Point(68, 183);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(215, 30);
            this.passField.TabIndex = 2;
            this.passField.Enter += new System.EventHandler(this.PassFieldEnter);
            this.passField.Leave += new System.EventHandler(this.PassFieldLeave);
            // 
            // lblAutorization
            // 
            this.lblAutorization.Font = new System.Drawing.Font("Candara Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAutorization.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblAutorization.Location = new System.Drawing.Point(50, 24);
            this.lblAutorization.Name = "lblAutorization";
            this.lblAutorization.Size = new System.Drawing.Size(248, 49);
            this.lblAutorization.TabIndex = 0;
            this.lblAutorization.Text = "Авторизация";
            // 
            // linkToRegistration
            // 
            this.linkToRegistration.AutoSize = true;
            this.linkToRegistration.Font = new System.Drawing.Font("Calibri", 11F);
            this.linkToRegistration.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.linkToRegistration.Location = new System.Drawing.Point(86, 419);
            this.linkToRegistration.Name = "linkToRegistration";
            this.linkToRegistration.Size = new System.Drawing.Size(97, 18);
            this.linkToRegistration.TabIndex = 4;
            this.linkToRegistration.Text = "Нет аккаунта?";
            // 
            // lblRegistration
            // 
            this.lblRegistration.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistration.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline);
            this.lblRegistration.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblRegistration.LinkColor = System.Drawing.SystemColors.ScrollBar;
            this.lblRegistration.Location = new System.Drawing.Point(181, 419);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(87, 18);
            this.lblRegistration.TabIndex = 0;
            this.lblRegistration.TabStop = true;
            this.lblRegistration.Text = "Регистрация";
            this.lblRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToRegistrationClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Candara Light", 14F);
            this.btnExit.Location = new System.Drawing.Point(89, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(347, 468);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.linkToRegistration);
            this.Controls.Add(this.lblAutorization);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.btnAutorization);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 507);
            this.MinimumSize = new System.Drawing.Size(363, 507);
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.VisibleChanged += new System.EventHandler(this.AutorizationFormVisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutorization;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label lblAutorization;
        private System.Windows.Forms.Label linkToRegistration;
        private System.Windows.Forms.LinkLabel lblRegistration;
        private System.Windows.Forms.Button btnExit;
    }
}