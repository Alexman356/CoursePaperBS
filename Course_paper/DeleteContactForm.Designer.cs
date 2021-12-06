
namespace Course_paper
{
    partial class DeleteContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteContactForm));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Удаление контакта";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(80, 131);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(194, 33);
            this.name.TabIndex = 10;
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Candara Light", 14F);
            this.Back.Location = new System.Drawing.Point(107, 305);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(132, 34);
            this.Back.TabIndex = 16;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Font = new System.Drawing.Font("Candara Light", 14F);
            this.Delete.Location = new System.Drawing.Point(107, 228);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 34);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(349, 386);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(365, 425);
            this.MinimumSize = new System.Drawing.Size(365, 425);
            this.Name = "DeleteContactForm";
            this.Text = "Удаление контакта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteContactForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
    }
}