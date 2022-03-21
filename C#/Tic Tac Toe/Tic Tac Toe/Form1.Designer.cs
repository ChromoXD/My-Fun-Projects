namespace Tic_Tac_Toe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.CkBx_Score_On = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Bx_O = new System.Windows.Forms.TextBox();
            this.Txt_Bx_X = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Scor_O = new System.Windows.Forms.Label();
            this.Scor_X = new System.Windows.Forms.Label();
            this.lbl_O = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.Tab_0 = new System.Windows.Forms.Panel();
            this.Tab_8 = new System.Windows.Forms.Panel();
            this.Tab_7 = new System.Windows.Forms.Panel();
            this.Tab_4 = new System.Windows.Forms.Panel();
            this.Tab_3 = new System.Windows.Forms.Panel();
            this.Tab_2 = new System.Windows.Forms.Panel();
            this.Tab_5 = new System.Windows.Forms.Panel();
            this.Tab_6 = new System.Windows.Forms.Panel();
            this.Tab_1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MsgX = new System.Windows.Forms.Panel();
            this.lbl_Winner = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WonText = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.roundButton3 = new Tic_Tac_Toe.RoundButton();
            this.roundButton1 = new Tic_Tac_Toe.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.MsgX.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.roundButton3);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousePressedDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formPosition);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MousePressedUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tic Tac Toe";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousePressedDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formPosition);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MousePressedUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.panel2.Controls.Add(this.MsgX);
            this.panel2.Controls.Add(this.pnl_Menu);
            this.panel2.Controls.Add(this.Scor_O);
            this.panel2.Controls.Add(this.Scor_X);
            this.panel2.Controls.Add(this.lbl_O);
            this.panel2.Controls.Add(this.lbl_X);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 411);
            this.panel2.TabIndex = 1;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Menu.Controls.Add(this.CkBx_Score_On);
            this.pnl_Menu.Controls.Add(this.label3);
            this.pnl_Menu.Controls.Add(this.label2);
            this.pnl_Menu.Controls.Add(this.Txt_Bx_O);
            this.pnl_Menu.Controls.Add(this.Txt_Bx_X);
            this.pnl_Menu.Controls.Add(this.btn);
            this.pnl_Menu.Controls.Add(this.label6);
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(800, 411);
            this.pnl_Menu.TabIndex = 27;
            // 
            // CkBx_Score_On
            // 
            this.CkBx_Score_On.AutoSize = true;
            this.CkBx_Score_On.Checked = true;
            this.CkBx_Score_On.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkBx_Score_On.FlatAppearance.BorderSize = 0;
            this.CkBx_Score_On.Font = new System.Drawing.Font("Tourney Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CkBx_Score_On.Location = new System.Drawing.Point(3, 385);
            this.CkBx_Score_On.Name = "CkBx_Score_On";
            this.CkBx_Score_On.Size = new System.Drawing.Size(72, 23);
            this.CkBx_Score_On.TabIndex = 6;
            this.CkBx_Score_On.Text = "Score";
            this.CkBx_Score_On.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 1";
            // 
            // Txt_Bx_O
            // 
            this.Txt_Bx_O.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Bx_O.Location = new System.Drawing.Point(575, 192);
            this.Txt_Bx_O.Name = "Txt_Bx_O";
            this.Txt_Bx_O.Size = new System.Drawing.Size(133, 13);
            this.Txt_Bx_O.TabIndex = 3;
            // 
            // Txt_Bx_X
            // 
            this.Txt_Bx_X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Bx_X.Location = new System.Drawing.Point(72, 192);
            this.Txt_Bx_X.Name = "Txt_Bx_X";
            this.Txt_Bx_X.Size = new System.Drawing.Size(133, 13);
            this.Txt_Bx_X.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn.BackColor = System.Drawing.Color.DarkGray;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Orbitron", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.Control;
            this.btn.Location = new System.Drawing.Point(349, 188);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "OK!";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 42);
            this.label6.TabIndex = 0;
            // 
            // Scor_O
            // 
            this.Scor_O.AutoSize = true;
            this.Scor_O.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scor_O.Location = new System.Drawing.Point(690, 180);
            this.Scor_O.Name = "Scor_O";
            this.Scor_O.Size = new System.Drawing.Size(31, 32);
            this.Scor_O.TabIndex = 26;
            this.Scor_O.Text = "12";
            // 
            // Scor_X
            // 
            this.Scor_X.AutoSize = true;
            this.Scor_X.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scor_X.Location = new System.Drawing.Point(81, 179);
            this.Scor_X.Name = "Scor_X";
            this.Scor_X.Size = new System.Drawing.Size(31, 32);
            this.Scor_X.TabIndex = 25;
            this.Scor_X.Text = "12";
            // 
            // lbl_O
            // 
            this.lbl_O.AutoSize = true;
            this.lbl_O.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_O.Location = new System.Drawing.Point(669, 147);
            this.lbl_O.Name = "lbl_O";
            this.lbl_O.Size = new System.Drawing.Size(24, 32);
            this.lbl_O.TabIndex = 24;
            this.lbl_O.Text = "O";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.Location = new System.Drawing.Point(76, 147);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(23, 32);
            this.lbl_X.TabIndex = 23;
            this.lbl_X.Text = "X";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 5);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Declare);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Board;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.Tab_0);
            this.panel4.Controls.Add(this.Tab_8);
            this.panel4.Controls.Add(this.Tab_7);
            this.panel4.Controls.Add(this.Tab_4);
            this.panel4.Controls.Add(this.Tab_3);
            this.panel4.Controls.Add(this.Tab_2);
            this.panel4.Controls.Add(this.Tab_5);
            this.panel4.Controls.Add(this.Tab_6);
            this.panel4.Controls.Add(this.Tab_1);
            this.panel4.Location = new System.Drawing.Point(211, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 387);
            this.panel4.TabIndex = 22;
            // 
            // Tab_0
            // 
            this.Tab_0.AutoSize = true;
            this.Tab_0.BackColor = System.Drawing.Color.Transparent;
            this.Tab_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_0.Location = new System.Drawing.Point(9, 9);
            this.Tab_0.Name = "Tab_0";
            this.Tab_0.Size = new System.Drawing.Size(116, 116);
            this.Tab_0.TabIndex = 29;
            this.Tab_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zero);
            // 
            // Tab_8
            // 
            this.Tab_8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Tab_8.AutoSize = true;
            this.Tab_8.BackColor = System.Drawing.Color.Transparent;
            this.Tab_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_8.Location = new System.Drawing.Point(263, 262);
            this.Tab_8.Name = "Tab_8";
            this.Tab_8.Size = new System.Drawing.Size(116, 116);
            this.Tab_8.TabIndex = 25;
            this.Tab_8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Eight);
            // 
            // Tab_7
            // 
            this.Tab_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_7.AutoSize = true;
            this.Tab_7.BackColor = System.Drawing.Color.Transparent;
            this.Tab_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_7.Location = new System.Drawing.Point(135, 262);
            this.Tab_7.Name = "Tab_7";
            this.Tab_7.Size = new System.Drawing.Size(116, 116);
            this.Tab_7.TabIndex = 28;
            this.Tab_7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Seven);
            // 
            // Tab_4
            // 
            this.Tab_4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tab_4.AutoSize = true;
            this.Tab_4.BackColor = System.Drawing.Color.Transparent;
            this.Tab_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_4.Location = new System.Drawing.Point(135, 135);
            this.Tab_4.Name = "Tab_4";
            this.Tab_4.Size = new System.Drawing.Size(116, 116);
            this.Tab_4.TabIndex = 27;
            this.Tab_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Four);
            // 
            // Tab_3
            // 
            this.Tab_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Tab_3.AutoSize = true;
            this.Tab_3.BackColor = System.Drawing.Color.Transparent;
            this.Tab_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_3.Location = new System.Drawing.Point(9, 135);
            this.Tab_3.Name = "Tab_3";
            this.Tab_3.Size = new System.Drawing.Size(116, 116);
            this.Tab_3.TabIndex = 26;
            this.Tab_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Three);
            // 
            // Tab_2
            // 
            this.Tab_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_2.AutoSize = true;
            this.Tab_2.BackColor = System.Drawing.Color.Transparent;
            this.Tab_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_2.Location = new System.Drawing.Point(263, 9);
            this.Tab_2.Name = "Tab_2";
            this.Tab_2.Size = new System.Drawing.Size(116, 116);
            this.Tab_2.TabIndex = 22;
            this.Tab_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Two);
            // 
            // Tab_5
            // 
            this.Tab_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tab_5.AutoSize = true;
            this.Tab_5.BackColor = System.Drawing.Color.Transparent;
            this.Tab_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_5.Location = new System.Drawing.Point(263, 135);
            this.Tab_5.Name = "Tab_5";
            this.Tab_5.Size = new System.Drawing.Size(116, 116);
            this.Tab_5.TabIndex = 24;
            this.Tab_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Five);
            // 
            // Tab_6
            // 
            this.Tab_6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tab_6.AutoSize = true;
            this.Tab_6.BackColor = System.Drawing.Color.Transparent;
            this.Tab_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_6.Location = new System.Drawing.Point(9, 262);
            this.Tab_6.Name = "Tab_6";
            this.Tab_6.Size = new System.Drawing.Size(116, 116);
            this.Tab_6.TabIndex = 23;
            this.Tab_6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Six);
            // 
            // Tab_1
            // 
            this.Tab_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tab_1.AutoSize = true;
            this.Tab_1.BackColor = System.Drawing.Color.Transparent;
            this.Tab_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_1.Location = new System.Drawing.Point(135, 9);
            this.Tab_1.Name = "Tab_1";
            this.Tab_1.Size = new System.Drawing.Size(116, 116);
            this.Tab_1.TabIndex = 21;
            this.Tab_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.One);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Tic_Tac_Toe1;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(372, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(26, 26);
            this.panel5.TabIndex = 4;
            // 
            // MsgX
            // 
            this.MsgX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(194)))), ((int)(((byte)(160)))));
            this.MsgX.Controls.Add(this.lbl_Winner);
            this.MsgX.Controls.Add(this.button2);
            this.MsgX.Controls.Add(this.button1);
            this.MsgX.Controls.Add(this.WonText);
            this.MsgX.Controls.Add(this.panel6);
            this.MsgX.Location = new System.Drawing.Point(158, 108);
            this.MsgX.Name = "MsgX";
            this.MsgX.Size = new System.Drawing.Size(510, 173);
            this.MsgX.TabIndex = 7;
            this.MsgX.Visible = false;
            // 
            // lbl_Winner
            // 
            this.lbl_Winner.AutoSize = true;
            this.lbl_Winner.Font = new System.Drawing.Font("Tourney Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Winner.Location = new System.Drawing.Point(169, 20);
            this.lbl_Winner.Name = "lbl_Winner";
            this.lbl_Winner.Size = new System.Drawing.Size(0, 19);
            this.lbl_Winner.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tourney Black", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(253, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tourney Black", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Reset);
            // 
            // WonText
            // 
            this.WonText.AutoSize = true;
            this.WonText.Font = new System.Drawing.Font("Tourney Black", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WonText.Location = new System.Drawing.Point(121, 39);
            this.WonText.Name = "WonText";
            this.WonText.Size = new System.Drawing.Size(145, 73);
            this.WonText.TabIndex = 5;
            this.WonText.Text = "Won";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.TicTacToeBackground;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(336, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(174, 173);
            this.panel6.TabIndex = 4;
            // 
            // roundButton3
            // 
            this.roundButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Location = new System.Drawing.Point(737, 8);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(23, 23);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Location = new System.Drawing.Point(766, 8);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(23, 23);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.MsgX.ResumeLayout(false);
            this.MsgX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundButton roundButton3;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel Tab_0;
        private System.Windows.Forms.Panel Tab_8;
        private System.Windows.Forms.Panel Tab_7;
        private System.Windows.Forms.Panel Tab_4;
        private System.Windows.Forms.Panel Tab_3;
        private System.Windows.Forms.Panel Tab_2;
        private System.Windows.Forms.Panel Tab_5;
        private System.Windows.Forms.Panel Tab_6;
        private System.Windows.Forms.Panel Tab_1;
        private System.Windows.Forms.Label Scor_O;
        private System.Windows.Forms.Label Scor_X;
        private System.Windows.Forms.Label lbl_O;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Txt_Bx_O;
        private System.Windows.Forms.TextBox Txt_Bx_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CkBx_Score_On;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel MsgX;
        private System.Windows.Forms.Label lbl_Winner;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WonText;
        private System.Windows.Forms.Panel panel6;
    }
}

