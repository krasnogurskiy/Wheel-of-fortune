using System;

namespace app
{
    partial class GameForm
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
            this.answerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelBuy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScoreInt = new System.Windows.Forms.Label();
            this.alphabet_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.answer_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.check_button = new System.Windows.Forms.Button();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.question = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.round_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player1_current_score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player1_score = new System.Windows.Forms.Label();
            this.player1_name = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player2_current_score = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.player2_score = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.player2_name = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.player3_current_score = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.player3_score = new System.Windows.Forms.Label();
            this.player3_name = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status_lb = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.stop_game_bt = new System.Windows.Forms.Button();
            this.tool_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // answerBox
            // 
            this.answerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.answerBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBox.Location = new System.Drawing.Point(544, 7);
            this.answerBox.Margin = new System.Windows.Forms.Padding(4);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(187, 31);
            this.answerBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(326, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Знаєте повну відповідь?";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBuy.BackColor = System.Drawing.Color.Gold;
            this.buttonBuy.FlatAppearance.BorderSize = 0;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuy.Location = new System.Drawing.Point(159, 5);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(114, 32);
            this.buttonBuy.TabIndex = 37;
            this.buttonBuy.Text = "Купити";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelBuy
            // 
            this.labelBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBuy.AutoSize = true;
            this.labelBuy.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuy.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBuy.Location = new System.Drawing.Point(14, 14);
            this.labelBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(128, 19);
            this.labelBuy.TabIndex = 38;
            this.labelBuy.Text = "Голосна літера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(1058, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Бали:";
            // 
            // labelScoreInt
            // 
            this.labelScoreInt.AutoSize = true;
            this.labelScoreInt.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreInt.ForeColor = System.Drawing.Color.Gold;
            this.labelScoreInt.Location = new System.Drawing.Point(1158, 207);
            this.labelScoreInt.Name = "labelScoreInt";
            this.labelScoreInt.Size = new System.Drawing.Size(24, 25);
            this.labelScoreInt.TabIndex = 43;
            this.labelScoreInt.Text = "0";
            // 
            // alphabet_panel
            // 
            this.alphabet_panel.Location = new System.Drawing.Point(80, 309);
            this.alphabet_panel.Name = "alphabet_panel";
            this.alphabet_panel.Size = new System.Drawing.Size(648, 206);
            this.alphabet_panel.TabIndex = 45;
            // 
            // answer_panel
            // 
            this.answer_panel.Location = new System.Drawing.Point(80, 204);
            this.answer_panel.Name = "answer_panel";
            this.answer_panel.Size = new System.Drawing.Size(648, 58);
            this.answer_panel.TabIndex = 46;
            // 
            // check_button
            // 
            this.check_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_button.BackColor = System.Drawing.Color.Gold;
            this.check_button.FlatAppearance.BorderSize = 0;
            this.check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.check_button.Location = new System.Drawing.Point(566, 46);
            this.check_button.Margin = new System.Windows.Forms.Padding(4);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(140, 32);
            this.check_button.TabIndex = 47;
            this.check_button.Text = "Перевірити";
            this.check_button.UseVisualStyleBackColor = false;
            this.check_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tool_panel
            // 
            this.tool_panel.Controls.Add(this.labelBuy);
            this.tool_panel.Controls.Add(this.check_button);
            this.tool_panel.Controls.Add(this.buttonBuy);
            this.tool_panel.Controls.Add(this.label1);
            this.tool_panel.Controls.Add(this.answerBox);
            this.tool_panel.Location = new System.Drawing.Point(42, 555);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(783, 100);
            this.tool_panel.TabIndex = 48;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question.ForeColor = System.Drawing.Color.Gold;
            this.question.Location = new System.Drawing.Point(76, 99);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(306, 23);
            this.question.TabIndex = 49;
            this.question.Text = "Питання: Яка столиця Франції?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(76, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Відповідь:";
            // 
            // round_lb
            // 
            this.round_lb.AutoSize = true;
            this.round_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_lb.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.round_lb.ForeColor = System.Drawing.Color.Gold;
            this.round_lb.Location = new System.Drawing.Point(396, 34);
            this.round_lb.Name = "round_lb";
            this.round_lb.Size = new System.Drawing.Size(120, 33);
            this.round_lb.TabIndex = 51;
            this.round_lb.Text = "Раунд 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.player1_current_score);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.player1_score);
            this.panel1.Controls.Add(this.player1_name);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(870, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 135);
            this.panel1.TabIndex = 52;
            // 
            // player1_current_score
            // 
            this.player1_current_score.AutoSize = true;
            this.player1_current_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_current_score.ForeColor = System.Drawing.Color.White;
            this.player1_current_score.Location = new System.Drawing.Point(95, 101);
            this.player1_current_score.Name = "player1_current_score";
            this.player1_current_score.Size = new System.Drawing.Size(0, 16);
            this.player1_current_score.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = " рахунок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Поточний ";
            // 
            // player1_score
            // 
            this.player1_score.AutoSize = true;
            this.player1_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_score.ForeColor = System.Drawing.Color.White;
            this.player1_score.Location = new System.Drawing.Point(20, 74);
            this.player1_score.Name = "player1_score";
            this.player1_score.Size = new System.Drawing.Size(62, 16);
            this.player1_score.TabIndex = 55;
            this.player1_score.Text = "Рахунок";
            // 
            // player1_name
            // 
            this.player1_name.AutoSize = true;
            this.player1_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_name.ForeColor = System.Drawing.Color.White;
            this.player1_name.Location = new System.Drawing.Point(20, 58);
            this.player1_name.Name = "player1_name";
            this.player1_name.Size = new System.Drawing.Size(74, 16);
            this.player1_name.TabIndex = 54;
            this.player1_name.Text = "Гравець 1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::app.Properties.Resources._1;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(32, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.player2_current_score);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.player2_score);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.player2_name);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(1045, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 135);
            this.panel2.TabIndex = 53;
            // 
            // player2_current_score
            // 
            this.player2_current_score.AutoSize = true;
            this.player2_current_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_current_score.ForeColor = System.Drawing.Color.White;
            this.player2_current_score.Location = new System.Drawing.Point(94, 101);
            this.player2_current_score.Name = "player2_current_score";
            this.player2_current_score.Size = new System.Drawing.Size(0, 16);
            this.player2_current_score.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = " рахунок";
            // 
            // player2_score
            // 
            this.player2_score.AutoSize = true;
            this.player2_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_score.ForeColor = System.Drawing.Color.White;
            this.player2_score.Location = new System.Drawing.Point(20, 74);
            this.player2_score.Name = "player2_score";
            this.player2_score.Size = new System.Drawing.Size(62, 16);
            this.player2_score.TabIndex = 55;
            this.player2_score.Text = "Рахунок";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Поточний ";
            // 
            // player2_name
            // 
            this.player2_name.AutoSize = true;
            this.player2_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_name.ForeColor = System.Drawing.Color.White;
            this.player2_name.Location = new System.Drawing.Point(20, 58);
            this.player2_name.Name = "player2_name";
            this.player2_name.Size = new System.Drawing.Size(74, 16);
            this.player2_name.TabIndex = 54;
            this.player2_name.Text = "Гравець 2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::app.Properties.Resources._2;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(36, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.player3_current_score);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.player3_score);
            this.panel3.Controls.Add(this.player3_name);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(1202, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 135);
            this.panel3.TabIndex = 54;
            // 
            // player3_current_score
            // 
            this.player3_current_score.AutoSize = true;
            this.player3_current_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_current_score.ForeColor = System.Drawing.Color.White;
            this.player3_current_score.Location = new System.Drawing.Point(95, 101);
            this.player3_current_score.Name = "player3_current_score";
            this.player3_current_score.Size = new System.Drawing.Size(0, 16);
            this.player3_current_score.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = " рахунок";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(20, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Поточний ";
            // 
            // player3_score
            // 
            this.player3_score.AutoSize = true;
            this.player3_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_score.ForeColor = System.Drawing.Color.White;
            this.player3_score.Location = new System.Drawing.Point(20, 74);
            this.player3_score.Name = "player3_score";
            this.player3_score.Size = new System.Drawing.Size(62, 16);
            this.player3_score.TabIndex = 55;
            this.player3_score.Text = "Рахунок";
            // 
            // player3_name
            // 
            this.player3_name.AutoSize = true;
            this.player3_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_name.ForeColor = System.Drawing.Color.White;
            this.player3_name.Location = new System.Drawing.Point(20, 58);
            this.player3_name.Name = "player3_name";
            this.player3_name.Size = new System.Drawing.Size(74, 16);
            this.player3_name.TabIndex = 54;
            this.player3_name.Text = "Гравець 3";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::app.Properties.Resources._3;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(32, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 53;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::app.Properties.Resources.Red_Triangle;
            this.pictureBox2.Location = new System.Drawing.Point(1128, 235);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::app.Properties.Resources.kolo;
            this.pictureBox1.Location = new System.Drawing.Point(968, 270);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.status_lb.ForeColor = System.Drawing.Color.Gold;
            this.status_lb.Location = new System.Drawing.Point(990, 165);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(0, 25);
            this.status_lb.TabIndex = 55;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 56;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.MenuBar;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // stop_game_bt
            // 
            this.stop_game_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stop_game_bt.BackColor = System.Drawing.Color.Gold;
            this.stop_game_bt.FlatAppearance.BorderSize = 0;
            this.stop_game_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_game_bt.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop_game_bt.Location = new System.Drawing.Point(1083, 677);
            this.stop_game_bt.Margin = new System.Windows.Forms.Padding(4);
            this.stop_game_bt.Name = "stop_game_bt";
            this.stop_game_bt.Size = new System.Drawing.Size(140, 32);
            this.stop_game_bt.TabIndex = 57;
            this.stop_game_bt.Text = "Зупинити гру";
            this.stop_game_bt.UseVisualStyleBackColor = false;
            this.stop_game_bt.Click += new System.EventHandler(this.stop_game_bt_Click);
            // 
            // GameForm
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1354, 749);
            this.Controls.Add(this.stop_game_bt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.round_lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.question);
            this.Controls.Add(this.tool_panel);
            this.Controls.Add(this.answer_panel);
            this.Controls.Add(this.alphabet_panel);
            this.Controls.Add(this.labelScoreInt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Колесо Фортуни";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelBuy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScoreInt;
        private System.Windows.Forms.FlowLayoutPanel alphabet_panel;
        private System.Windows.Forms.FlowLayoutPanel answer_panel;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Panel tool_panel;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label round_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label player1_score;
        private System.Windows.Forms.Label player1_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label player2_score;
        private System.Windows.Forms.Label player2_name;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label player3_score;
        private System.Windows.Forms.Label player3_name;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.Label player1_current_score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label player2_current_score;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label player3_current_score;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button stop_game_bt;
    }
}

