namespace Tik_Tak_Toe
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
            this.label1 = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.lbl_Turn = new System.Windows.Forms.Label();
            this.lbl_Winnerls = new System.Windows.Forms.Label();
            this.lbl_Winner = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 77);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tik Tak To Game";
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.ForeColor = System.Drawing.Color.Yellow;
            this.labl.Location = new System.Drawing.Point(68, 130);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(137, 58);
            this.labl.TabIndex = 10;
            this.labl.Text = "Trun";
            // 
            // lbl_Turn
            // 
            this.lbl_Turn.AutoSize = true;
            this.lbl_Turn.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turn.ForeColor = System.Drawing.Color.White;
            this.lbl_Turn.Location = new System.Drawing.Point(36, 212);
            this.lbl_Turn.Name = "lbl_Turn";
            this.lbl_Turn.Size = new System.Drawing.Size(209, 58);
            this.lbl_Turn.TabIndex = 11;
            this.lbl_Turn.Text = "Player1";
            // 
            // lbl_Winnerls
            // 
            this.lbl_Winnerls.AutoSize = true;
            this.lbl_Winnerls.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Winnerls.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Winnerls.Location = new System.Drawing.Point(36, 309);
            this.lbl_Winnerls.Name = "lbl_Winnerls";
            this.lbl_Winnerls.Size = new System.Drawing.Size(200, 58);
            this.lbl_Winnerls.TabIndex = 12;
            this.lbl_Winnerls.Text = "Winner";
            // 
            // lbl_Winner
            // 
            this.lbl_Winner.AutoSize = true;
            this.lbl_Winner.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Winner.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Winner.Location = new System.Drawing.Point(12, 389);
            this.lbl_Winner.Name = "lbl_Winner";
            this.lbl_Winner.Size = new System.Drawing.Size(292, 58);
            this.lbl_Winner.TabIndex = 13;
            this.lbl_Winner.Text = "InProgress";
            // 
            // btn_Restart
            // 
            this.btn_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restart.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.ForeColor = System.Drawing.Color.White;
            this.btn_Restart.Location = new System.Drawing.Point(12, 490);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(258, 80);
            this.btn_Restart.TabIndex = 14;
            this.btn_Restart.Text = "Restart Game";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button1.Location = new System.Drawing.Point(437, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 92);
            this.button1.TabIndex = 15;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button2.Location = new System.Drawing.Point(582, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 92);
            this.button2.TabIndex = 16;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button3.Location = new System.Drawing.Point(727, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 92);
            this.button3.TabIndex = 17;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button4.Location = new System.Drawing.Point(437, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 92);
            this.button4.TabIndex = 18;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button5.Location = new System.Drawing.Point(582, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 92);
            this.button5.TabIndex = 19;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button6.Location = new System.Drawing.Point(727, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 92);
            this.button6.TabIndex = 20;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button7.Location = new System.Drawing.Point(437, 463);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 92);
            this.button7.TabIndex = 21;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button8.Location = new System.Drawing.Point(582, 463);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 92);
            this.button8.TabIndex = 22;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Tik_Tak_Toe.Properties.Resources.question_mark_961;
            this.button9.Location = new System.Drawing.Point(727, 463);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 92);
            this.button9.TabIndex = 23;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1028, 672);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.lbl_Winner);
            this.Controls.Add(this.lbl_Winnerls);
            this.Controls.Add(this.lbl_Turn);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.button_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label lbl_Turn;
        private System.Windows.Forms.Label lbl_Winnerls;
        private System.Windows.Forms.Label lbl_Winner;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

