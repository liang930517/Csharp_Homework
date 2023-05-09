
namespace HomePage
{
    partial class _0709_StudentsGrand
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
            this.HeandMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeadChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatisticlistView = new System.Windows.Forms.ListView();
            this.HeadEng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderAverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderTotalScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView = new System.Windows.Forms.ListView();
            this.HeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRandomTwenty = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // HeandMath
            // 
            this.HeandMath.Text = "數學";
            // 
            // HeadChi
            // 
            this.HeadChi.Text = "國文";
            this.HeadChi.Width = 58;
            // 
            // HeaderItem
            // 
            this.HeaderItem.Text = "項目";
            this.HeaderItem.Width = 59;
            // 
            // StatisticlistView
            // 
            this.StatisticlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderItem,
            this.HeadChi,
            this.HeadEng,
            this.HeandMath});
            this.StatisticlistView.HideSelection = false;
            this.StatisticlistView.Location = new System.Drawing.Point(229, 294);
            this.StatisticlistView.Name = "StatisticlistView";
            this.StatisticlistView.Size = new System.Drawing.Size(573, 176);
            this.StatisticlistView.TabIndex = 37;
            this.StatisticlistView.UseCompatibleStateImageBehavior = false;
            this.StatisticlistView.View = System.Windows.Forms.View.Details;
            // 
            // HeadEng
            // 
            this.HeadEng.Text = "英文";
            // 
            // HeaderMin
            // 
            this.HeaderMin.Text = "最低";
            // 
            // HeaderMax
            // 
            this.HeaderMax.Text = "最高";
            // 
            // HeaderAverage
            // 
            this.HeaderAverage.Text = "平均";
            // 
            // HeaderTotalScore
            // 
            this.HeaderTotalScore.Text = "總分";
            // 
            // HeaderMath
            // 
            this.HeaderMath.Text = "數學";
            // 
            // HeaderEnglish
            // 
            this.HeaderEnglish.Text = "英文";
            // 
            // HeaderChi
            // 
            this.HeaderChi.Text = "國文";
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
            this.listView.Location = new System.Drawing.Point(229, 42);
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
            // btnRandomTwenty
            // 
            this.btnRandomTwenty.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomTwenty.Location = new System.Drawing.Point(37, 433);
            this.btnRandomTwenty.Name = "btnRandomTwenty";
            this.btnRandomTwenty.Size = new System.Drawing.Size(159, 37);
            this.btnRandomTwenty.TabIndex = 35;
            this.btnRandomTwenty.Text = "隨機加入20筆";
            this.btnRandomTwenty.UseVisualStyleBackColor = true;
            this.btnRandomTwenty.Click += new System.EventHandler(this.btnRandomTwenty_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(37, 391);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(159, 37);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BtnSubjectCount
            // 
            this.BtnSubjectCount.Enabled = false;
            this.BtnSubjectCount.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSubjectCount.Location = new System.Drawing.Point(37, 326);
            this.BtnSubjectCount.Name = "BtnSubjectCount";
            this.BtnSubjectCount.Size = new System.Drawing.Size(159, 37);
            this.BtnSubjectCount.TabIndex = 33;
            this.BtnSubjectCount.Text = "各科統計";
            this.BtnSubjectCount.UseVisualStyleBackColor = true;
            this.BtnSubjectCount.Click += new System.EventHandler(this.BtnSubjectCount_Click);
            // 
            // addScore
            // 
            this.addScore.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addScore.Location = new System.Drawing.Point(37, 240);
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
            this.randomScore.Location = new System.Drawing.Point(37, 283);
            this.randomScore.Name = "randomScore";
            this.randomScore.Size = new System.Drawing.Size(159, 37);
            this.randomScore.TabIndex = 31;
            this.randomScore.Text = "隨機儲存資料";
            this.randomScore.UseVisualStyleBackColor = true;
            this.randomScore.Click += new System.EventHandler(this.randomScore_Click);
            // 
            // textBoxMath
            // 
            this.textBoxMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxMath.Location = new System.Drawing.Point(101, 194);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(96, 32);
            this.textBoxMath.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(33, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "數學：";
            // 
            // textBoxEng
            // 
            this.textBoxEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxEng.Location = new System.Drawing.Point(101, 141);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(96, 32);
            this.textBoxEng.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(33, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "英文：";
            // 
            // textBoxChi
            // 
            this.textBoxChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxChi.Location = new System.Drawing.Point(101, 94);
            this.textBoxChi.Name = "textBoxChi";
            this.textBoxChi.Size = new System.Drawing.Size(96, 32);
            this.textBoxChi.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "國文：";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.Location = new System.Drawing.Point(101, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(96, 32);
            this.textBoxName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "姓名：";
            // 
            // _0709_StudentsGrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 512);
            this.Controls.Add(this.StatisticlistView);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnRandomTwenty);
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
            this.Name = "_0709_StudentsGrand";
            this.Text = "_0709_StudentsGrand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader HeandMath;
        private System.Windows.Forms.ColumnHeader HeadChi;
        private System.Windows.Forms.ColumnHeader HeaderItem;
        private System.Windows.Forms.ListView StatisticlistView;
        private System.Windows.Forms.ColumnHeader HeadEng;
        private System.Windows.Forms.ColumnHeader HeaderMin;
        private System.Windows.Forms.ColumnHeader HeaderMax;
        private System.Windows.Forms.ColumnHeader HeaderAverage;
        private System.Windows.Forms.ColumnHeader HeaderTotalScore;
        private System.Windows.Forms.ColumnHeader HeaderMath;
        private System.Windows.Forms.ColumnHeader HeaderEnglish;
        private System.Windows.Forms.ColumnHeader HeaderChi;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader HeaderName;
        private System.Windows.Forms.Button btnRandomTwenty;
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
    }
}