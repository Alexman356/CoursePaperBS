
namespace Course_paper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКонтактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКонтактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search_name = new System.Windows.Forms.TextBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_contact_number = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.обToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.добавитьКонтактToolStripMenuItem,
            this.удалитьКонтактToolStripMenuItem,
            this.выходИзПрограммыToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // добавитьКонтактToolStripMenuItem
            // 
            this.добавитьКонтактToolStripMenuItem.Name = "добавитьКонтактToolStripMenuItem";
            this.добавитьКонтактToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.добавитьКонтактToolStripMenuItem.Text = "Добавить контакт";
            this.добавитьКонтактToolStripMenuItem.Click += new System.EventHandler(this.добавитьКонтактToolStripMenuItem_Click);
            // 
            // удалитьКонтактToolStripMenuItem
            // 
            this.удалитьКонтактToolStripMenuItem.Name = "удалитьКонтактToolStripMenuItem";
            this.удалитьКонтактToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.удалитьКонтактToolStripMenuItem.Text = "Удалить контакт";
            this.удалитьКонтактToolStripMenuItem.Click += new System.EventHandler(this.удалитьКонтактToolStripMenuItem_Click);
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // обToolStripMenuItem
            // 
            this.обToolStripMenuItem.Name = "обToolStripMenuItem";
            this.обToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.обToolStripMenuItem.Text = "О программе";
            this.обToolStripMenuItem.Click += new System.EventHandler(this.обToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск контактов:";
            // 
            // tb_search_name
            // 
            this.tb_search_name.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_search_name.Location = new System.Drawing.Point(200, 51);
            this.tb_search_name.Name = "tb_search_name";
            this.tb_search_name.Size = new System.Drawing.Size(232, 30);
            this.tb_search_name.TabIndex = 2;
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(12, 105);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(814, 313);
            this.DataTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(642, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Контактов:";
            // 
            // lbl_contact_number
            // 
            this.lbl_contact_number.AutoSize = true;
            this.lbl_contact_number.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_contact_number.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_contact_number.Location = new System.Drawing.Point(758, 54);
            this.lbl_contact_number.Name = "lbl_contact_number";
            this.lbl_contact_number.Size = new System.Drawing.Size(20, 22);
            this.lbl_contact_number.TabIndex = 5;
            this.lbl_contact_number.Text = "-";
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(460, 48);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(136, 34);
            this.Search.TabIndex = 7;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(838, 430);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.lbl_contact_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.tb_search_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(854, 469);
            this.MinimumSize = new System.Drawing.Size(854, 469);
            this.Name = "MainForm";
            this.Text = "Телефонный справочник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКонтактToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКонтактToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search_name;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_contact_number;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ToolStripMenuItem обToolStripMenuItem;
    }
}