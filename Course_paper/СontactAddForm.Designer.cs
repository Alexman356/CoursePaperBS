
namespace CoursePaper
{
    partial class ContactAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactAddForm));
            this.nameField = new System.Windows.Forms.TextBox();
            this.numberField = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.nameField.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.nameField.Location = new System.Drawing.Point(66, 119);
            this.nameField.Name = "tb_name";
            this.nameField.Size = new System.Drawing.Size(186, 33);
            this.nameField.TabIndex = 0;
            this.nameField.Enter += new System.EventHandler(this.NameEnter);
            this.nameField.Leave += new System.EventHandler(this.NameLeave);
            // 
            // tb_number
            // 
            this.numberField.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.numberField.Location = new System.Drawing.Point(66, 199);
            this.numberField.Name = "tb_number";
            this.numberField.Size = new System.Drawing.Size(186, 33);
            this.numberField.TabIndex = 1;
            this.numberField.Enter += new System.EventHandler(this.NumberEnter);
            this.numberField.Leave += new System.EventHandler(this.NumberLeave);
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Candara Light", 14F);
            this.Add.Location = new System.Drawing.Point(93, 287);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(132, 34);
            this.Add.TabIndex = 7;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Candara Light", 14F);
            this.Back.Location = new System.Drawing.Point(93, 364);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(132, 34);
            this.Back.TabIndex = 8;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.BtnBackClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Создание контакта";
            // 
            // AddСontactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(321, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.numberField);
            this.Controls.Add(this.nameField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(337, 475);
            this.MinimumSize = new System.Drawing.Size(337, 475);
            this.Name = "AddСontactForm";
            this.Text = "Создание контакта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.СontactAddFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox numberField;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}