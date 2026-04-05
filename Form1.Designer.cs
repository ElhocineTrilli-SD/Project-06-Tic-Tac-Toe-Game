namespace Tic_Tac_Toe_Game
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
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblTurnText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinnerText = new System.Windows.Forms.Label();
            this.buttonRestartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lblTurn.Location = new System.Drawing.Point(186, 110);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(79, 36);
            this.lblTurn.TabIndex = 33;
            this.lblTurn.Text = "Turn";
            // 
            // lblTurnText
            // 
            this.lblTurnText.AutoSize = true;
            this.lblTurnText.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTurnText.Location = new System.Drawing.Point(186, 161);
            this.lblTurnText.Name = "lblTurnText";
            this.lblTurnText.Size = new System.Drawing.Size(125, 36);
            this.lblTurnText.TabIndex = 34;
            this.lblTurnText.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(186, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "Winner";
            // 
            // lblWinnerText
            // 
            this.lblWinnerText.AutoSize = true;
            this.lblWinnerText.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerText.ForeColor = System.Drawing.Color.Lime;
            this.lblWinnerText.Location = new System.Drawing.Point(186, 285);
            this.lblWinnerText.Name = "lblWinnerText";
            this.lblWinnerText.Size = new System.Drawing.Size(168, 36);
            this.lblWinnerText.TabIndex = 36;
            this.lblWinnerText.Text = "In Progress";
            // 
            // buttonRestartGame
            // 
            this.buttonRestartGame.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestartGame.Location = new System.Drawing.Point(192, 368);
            this.buttonRestartGame.Name = "buttonRestartGame";
            this.buttonRestartGame.Size = new System.Drawing.Size(188, 68);
            this.buttonRestartGame.TabIndex = 37;
            this.buttonRestartGame.Text = "Restart Game";
            this.buttonRestartGame.UseVisualStyleBackColor = true;
            this.buttonRestartGame.Click += new System.EventHandler(this.buttonRestartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(279, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 42);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tic-Tac-Toe-Game";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button1.Location = new System.Drawing.Point(476, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 87);
            this.button1.TabIndex = 39;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button3.Location = new System.Drawing.Point(691, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 87);
            this.button3.TabIndex = 40;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button9.Location = new System.Drawing.Point(691, 363);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 87);
            this.button9.TabIndex = 41;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button6.Location = new System.Drawing.Point(691, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 87);
            this.button6.TabIndex = 42;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button2.Location = new System.Drawing.Point(583, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 87);
            this.button2.TabIndex = 43;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button7.Location = new System.Drawing.Point(483, 364);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 87);
            this.button7.TabIndex = 44;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button4.Location = new System.Drawing.Point(483, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 87);
            this.button4.TabIndex = 45;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button8.Location = new System.Drawing.Point(583, 363);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 87);
            this.button8.TabIndex = 46;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark;
            this.button5.Location = new System.Drawing.Point(583, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 87);
            this.button5.TabIndex = 47;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(827, 565);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRestartGame);
            this.Controls.Add(this.lblWinnerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTurnText);
            this.Controls.Add(this.lblTurn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblTurnText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWinnerText;
        private System.Windows.Forms.Button buttonRestartGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
    }
}

