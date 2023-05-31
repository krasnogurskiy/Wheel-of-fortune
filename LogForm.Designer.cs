
namespace app
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.logs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.raund1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.raund2 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.raund3 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.general = new System.Windows.Forms.ListBox();
            this.save_as_bt = new System.Windows.Forms.Button();
            this.save_all_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.show_log = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.player3 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.logs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(182, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveToolStripMenuItem.Text = "&Зберегти все";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveAsToolStripMenuItem.Text = "Зберегти &як";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "&Вийти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.close_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.copyToolStripMenuItem,
            this.toolStripSeparator4});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.editToolStripMenuItem.Text = "&Інструменти";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Копіювати";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстові файли|*.txt|SOAP-файли|*.soap|Двійкові файли|*.bin";
            this.saveFileDialog1.Title = "Збереження журналу";
            // 
            // logs
            // 
            this.logs.Controls.Add(this.tabPage1);
            this.logs.Controls.Add(this.tabPage2);
            this.logs.Controls.Add(this.tabPage3);
            this.logs.Controls.Add(this.tabPage4);
            this.logs.Location = new System.Drawing.Point(0, 52);
            this.logs.Name = "logs";
            this.logs.SelectedIndex = 0;
            this.logs.Size = new System.Drawing.Size(569, 369);
            this.logs.TabIndex = 2;
            this.logs.Visible = false;
            this.logs.TabIndexChanged += new System.EventHandler(this.logs_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.raund1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Раунд 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // raund1
            // 
            this.raund1.FormattingEnabled = true;
            this.raund1.HorizontalScrollbar = true;
            this.raund1.Location = new System.Drawing.Point(3, 3);
            this.raund1.Name = "raund1";
            this.raund1.Size = new System.Drawing.Size(555, 368);
            this.raund1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.raund2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Раунд 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // raund2
            // 
            this.raund2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raund2.FormattingEnabled = true;
            this.raund2.HorizontalScrollbar = true;
            this.raund2.Location = new System.Drawing.Point(3, 3);
            this.raund2.Name = "raund2";
            this.raund2.Size = new System.Drawing.Size(555, 418);
            this.raund2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.raund3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(561, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Раунд 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // raund3
            // 
            this.raund3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raund3.FormattingEnabled = true;
            this.raund3.HorizontalScrollbar = true;
            this.raund3.Location = new System.Drawing.Point(3, 3);
            this.raund3.Name = "raund3";
            this.raund3.Size = new System.Drawing.Size(555, 418);
            this.raund3.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.general);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(561, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Загальний";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // general
            // 
            this.general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.general.FormattingEnabled = true;
            this.general.HorizontalScrollbar = true;
            this.general.Location = new System.Drawing.Point(3, 3);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(555, 337);
            this.general.TabIndex = 2;
            // 
            // save_as_bt
            // 
            this.save_as_bt.BackColor = System.Drawing.Color.Navy;
            this.save_as_bt.FlatAppearance.BorderSize = 0;
            this.save_as_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_as_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save_as_bt.ForeColor = System.Drawing.Color.White;
            this.save_as_bt.Location = new System.Drawing.Point(617, 74);
            this.save_as_bt.Name = "save_as_bt";
            this.save_as_bt.Size = new System.Drawing.Size(126, 39);
            this.save_as_bt.TabIndex = 3;
            this.save_as_bt.Text = "Зберегти";
            this.save_as_bt.UseVisualStyleBackColor = true;
            this.save_as_bt.Visible = false;
            this.save_as_bt.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // save_all_bt
            // 
            this.save_all_bt.BackColor = System.Drawing.Color.Navy;
            this.save_all_bt.FlatAppearance.BorderSize = 0;
            this.save_all_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_all_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save_all_bt.ForeColor = System.Drawing.Color.White;
            this.save_all_bt.Location = new System.Drawing.Point(617, 150);
            this.save_all_bt.Name = "save_all_bt";
            this.save_all_bt.Size = new System.Drawing.Size(126, 37);
            this.save_all_bt.TabIndex = 4;
            this.save_all_bt.Text = "Зберегти все";
            this.save_all_bt.UseVisualStyleBackColor = false;
            this.save_all_bt.Visible = false;
            this.save_all_bt.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.Navy;
            this.close_bt.FlatAppearance.BorderSize = 0;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(617, 401);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(126, 37);
            this.close_bt.TabIndex = 5;
            this.close_bt.Text = "Завершити";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Visible = false;
            this.close_bt.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.show_log);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.player3);
            this.panel1.Controls.Add(this.player2);
            this.panel1.Controls.Add(this.player1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(109, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 331);
            this.panel1.TabIndex = 3;
            // 
            // show_log
            // 
            this.show_log.BackColor = System.Drawing.Color.Navy;
            this.show_log.FlatAppearance.BorderSize = 0;
            this.show_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_log.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.show_log.ForeColor = System.Drawing.Color.White;
            this.show_log.Location = new System.Drawing.Point(311, 274);
            this.show_log.Name = "show_log";
            this.show_log.Size = new System.Drawing.Size(145, 37);
            this.show_log.TabIndex = 9;
            this.show_log.Text = "Показати журнал";
            this.show_log.UseVisualStyleBackColor = false;
            this.show_log.Click += new System.EventHandler(this.show_log_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Navy;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(118, 274);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(126, 37);
            this.close.TabIndex = 8;
            this.close.Text = "Завершити";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(99, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Третє місце: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(99, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Друге місце: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(99, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Перше місце: ";
            // 
            // player3
            // 
            this.player3.AutoSize = true;
            this.player3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3.Location = new System.Drawing.Point(213, 223);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(49, 16);
            this.player3.TabIndex = 4;
            this.player3.Text = "label3";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2.Location = new System.Drawing.Point(213, 190);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(49, 16);
            this.player2.TabIndex = 3;
            this.player2.Text = "label3";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1.Location = new System.Drawing.Point(213, 156);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(49, 16);
            this.player1.TabIndex = 2;
            this.player1.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(98, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "За підсумками раундів отримано такі результати";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(199, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Гру завершено!";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.copyToolStripButton,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Зберегти все";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Копіювати";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.save_all_bt);
            this.Controls.Add(this.save_as_bt);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogForm";
            this.Text = "Заершення гри";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.logs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl logs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox raund1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox raund2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox raund3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox general;
        private System.Windows.Forms.Button save_as_bt;
        private System.Windows.Forms.Button save_all_bt;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label player3;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Button show_log;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}