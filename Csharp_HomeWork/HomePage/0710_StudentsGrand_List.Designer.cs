
namespace HomePage
{
    partial class _0710_StudentsGrand_List
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.HeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderTotalScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderAverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.BtnSubjectCount = new System.Windows.Forms.Button();
            this.addScore = new System.Windows.Forms.Button();
            this.randomScore = new System.Windows.Forms.Button();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(241, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(573, 178);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderName,
            this.HeaderChi,
            this.HeaderEnglish,
            this.HeaderMath,
            this.HeaderTotalScore,
            this.HeaderAverage,
            this.HeaderMax,
            this.HeaderMin});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(241, 32);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(573, 235);
            this.listView.TabIndex = 36;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // HeaderName
            // 
            this.HeaderName.Text = "姓名";
            // 
            // HeaderChi
            // 
            this.HeaderChi.Text = "國文";
            // 
            // HeaderEnglish
            // 
            this.HeaderEnglish.Text = "英文";
            // 
            // HeaderMath
            // 
            this.HeaderMath.Text = "數學";
            // 
            // HeaderTotalScore
            // 
            this.HeaderTotalScore.Text = "總分";
            // 
            // HeaderAverage
            // 
            this.HeaderAverage.Text = "平均";
            // 
            // HeaderMax
            // 
            this.HeaderMax.Text = "最高";
            // 
            // HeaderMin
            // 
            this.HeaderMin.Text = "最低";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(50, 376);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(159, 37);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "清除所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // BtnSubjectCount
            // 
            this.BtnSubjectCount.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSubjectCount.Location = new System.Drawing.Point(50, 333);
            this.BtnSubjectCount.Name = "BtnSubjectCount";
            this.BtnSubjectCount.Size = new System.Drawing.Size(159, 37);
            this.BtnSubjectCount.TabIndex = 33;
            this.BtnSubjectCount.Text = "移除資料";
            this.BtnSubjectCount.UseVisualStyleBackColor = true;
            this.BtnSubjectCount.Click += new System.EventHandler(this.BtnSubjectCount_Click);
            // 
            // addScore
            // 
            this.addScore.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addScore.Location = new System.Drawing.Point(50, 247);
            this.addScore.Name = "addScore";
            this.addScore.Size = new System.Drawing.Size(159, 37);
            this.addScore.TabIndex = 32;
            this.addScore.Text = "加入學生資料";
            this.addScore.UseVisualStyleBackColor = true;
            this.addScore.Click += new System.EventHandler(this.addScore_Click);
            // 
            // randomScore
            // 
            this.randomScore.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.randomScore.Location = new System.Drawing.Point(50, 290);
            this.randomScore.Name = "randomScore";
            this.randomScore.Size = new System.Drawing.Size(159, 37);
            this.randomScore.TabIndex = 31;
            this.randomScore.Text = "插入儲存資料";
            this.randomScore.UseVisualStyleBackColor = true;
            this.randomScore.Click += new System.EventHandler(this.randomScore_Click_1);
            // 
            // textBoxMath
            // 
            this.textBoxMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxMath.Location = new System.Drawing.Point(113, 184);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(96, 32);
            this.textBoxMath.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(45, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "數學：";
            // 
            // textBoxEng
            // 
            this.textBoxEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEng.Location = new System.Drawing.Point(113, 131);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(96, 32);
            this.textBoxEng.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(45, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "英文：";
            // 
            // textBoxChi
            // 
            this.textBoxChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxChi.Location = new System.Drawing.Point(113, 84);
            this.textBoxChi.Name = "textBoxChi";
            this.textBoxChi.Size = new System.Drawing.Size(96, 32);
            this.textBoxChi.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "國文：";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.Location = new System.Drawing.Point(113, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(96, 32);
            this.textBoxName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "姓名：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(50, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 38;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 460);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 24);
            this.textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 460);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 24);
            this.textBox2.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(43, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "搜尋國文成績範圍:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(120, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "－";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(655, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 37);
            this.button2.TabIndex = 43;
            this.button2.Text = "各科統計";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _0710_StudentsGrand_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.BtnSubjectCount);
            this.Controls.Add(this.addScore);
            this.Controls.Add(this.randomScore);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "_0710_StudentsGrand_List";
            this.Text = "_0710_StudentsGrand_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader HeaderName;
        private System.Windows.Forms.ColumnHeader HeaderChi;
        private System.Windows.Forms.ColumnHeader HeaderEnglish;
        private System.Windows.Forms.ColumnHeader HeaderMath;
        private System.Windows.Forms.ColumnHeader HeaderTotalScore;
        private System.Windows.Forms.ColumnHeader HeaderAverage;
        private System.Windows.Forms.ColumnHeader HeaderMax;
        private System.Windows.Forms.ColumnHeader HeaderMin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button BtnSubjectCount;
        private System.Windows.Forms.Button addScore;
        private System.Windows.Forms.Button randomScore;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}