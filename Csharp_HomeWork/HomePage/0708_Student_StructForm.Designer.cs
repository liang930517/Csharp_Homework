
namespace HomePage
{
    partial class _0708_Student_StructForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ScoreList = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ShowScore = new System.Windows.Forms.Button();
            this.SaveScore = new System.Windows.Forms.Button();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkScore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ScoreList);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(351, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 298);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(10, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "-----------------------------------";
            // 
            // ScoreList
            // 
            this.ScoreList.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScoreList.Location = new System.Drawing.Point(13, 31);
            this.ScoreList.Name = "ScoreList";
            this.ScoreList.Size = new System.Drawing.Size(216, 115);
            this.ScoreList.TabIndex = 0;
            this.ScoreList.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox2.Location = new System.Drawing.Point(13, 169);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(216, 111);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // ShowScore
            // 
            this.ShowScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowScore.Location = new System.Drawing.Point(155, 251);
            this.ShowScore.Name = "ShowScore";
            this.ShowScore.Size = new System.Drawing.Size(136, 55);
            this.ShowScore.TabIndex = 21;
            this.ShowScore.Text = "顯示儲存內容";
            this.ShowScore.UseVisualStyleBackColor = true;
            this.ShowScore.Click += new System.EventHandler(this.ShowScore_Click);
            // 
            // SaveScore
            // 
            this.SaveScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveScore.Location = new System.Drawing.Point(37, 251);
            this.SaveScore.Name = "SaveScore";
            this.SaveScore.Size = new System.Drawing.Size(100, 55);
            this.SaveScore.TabIndex = 20;
            this.SaveScore.Text = "儲存";
            this.SaveScore.UseVisualStyleBackColor = true;
            this.SaveScore.Click += new System.EventHandler(this.SaveScore_Click);
            // 
            // textBoxMath
            // 
            this.textBoxMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxMath.Location = new System.Drawing.Point(100, 195);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(191, 32);
            this.textBoxMath.TabIndex = 19;
            this.textBoxMath.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "數學：";
            // 
            // textBoxEng
            // 
            this.textBoxEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEng.Location = new System.Drawing.Point(100, 143);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(191, 32);
            this.textBoxEng.TabIndex = 17;
            this.textBoxEng.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "英文：";
            // 
            // textBoxChi
            // 
            this.textBoxChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxChi.Location = new System.Drawing.Point(100, 95);
            this.textBoxChi.Name = "textBoxChi";
            this.textBoxChi.Size = new System.Drawing.Size(191, 32);
            this.textBoxChi.TabIndex = 15;
            this.textBoxChi.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "國文：";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.Location = new System.Drawing.Point(100, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 32);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "姓名：";
            // 
            // checkScore
            // 
            this.checkScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkScore.Location = new System.Drawing.Point(351, 331);
            this.checkScore.Name = "checkScore";
            this.checkScore.Size = new System.Drawing.Size(246, 55);
            this.checkScore.TabIndex = 23;
            this.checkScore.Text = "最高分/最低分科目";
            this.checkScore.UseVisualStyleBackColor = true;
            this.checkScore.Click += new System.EventHandler(this.checkScore_Click);
            // 
            // _0708_Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShowScore);
            this.Controls.Add(this.SaveScore);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkScore);
            this.Name = "_0708_Student_StructForm";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ScoreList;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button ShowScore;
        private System.Windows.Forms.Button SaveScore;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkScore;
    }
}