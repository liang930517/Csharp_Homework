
namespace HomePage
{
    partial class _0711_MyClac
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
            this.btnDivided = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAddUp = new System.Windows.Forms.Button();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDivided
            // 
            this.btnDivided.Location = new System.Drawing.Point(329, 152);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(66, 21);
            this.btnDivided.TabIndex = 21;
            this.btnDivided.Text = "除";
            this.btnDivided.UseVisualStyleBackColor = true;
            this.btnDivided.Click += new System.EventHandler(this.btnDivided_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(248, 152);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(66, 21);
            this.btnMultiply.TabIndex = 20;
            this.btnMultiply.Text = "乘";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(168, 152);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(66, 21);
            this.btnSubtract.TabIndex = 19;
            this.btnSubtract.Text = "減";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAddUp
            // 
            this.btnAddUp.Location = new System.Drawing.Point(86, 152);
            this.btnAddUp.Name = "btnAddUp";
            this.btnAddUp.Size = new System.Drawing.Size(66, 21);
            this.btnAddUp.TabIndex = 18;
            this.btnAddUp.Text = "加";
            this.btnAddUp.UseVisualStyleBackColor = true;
            this.btnAddUp.Click += new System.EventHandler(this.btnAddUp_Click);
            // 
            // textBoxAns
            // 
            this.textBoxAns.Location = new System.Drawing.Point(190, 216);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.ReadOnly = true;
            this.textBoxAns.Size = new System.Drawing.Size(205, 24);
            this.textBoxAns.TabIndex = 17;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(190, 111);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(205, 24);
            this.textBoxNum2.TabIndex = 16;
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(190, 67);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(205, 24);
            this.textBoxNum1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "------------------------------------------------------------------------";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAnswer.Location = new System.Drawing.Point(82, 215);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(87, 28);
            this.labelAnswer.TabIndex = 13;
            this.labelAnswer.Text = "Answer";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNum2.Location = new System.Drawing.Point(82, 107);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(76, 28);
            this.labelNum2.TabIndex = 12;
            this.labelNum2.Text = "Num2";
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNum1.Location = new System.Drawing.Point(82, 67);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(76, 28);
            this.labelNum1.TabIndex = 11;
            this.labelNum1.Text = "Num1";
            // 
            // _0711_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 319);
            this.Controls.Add(this.btnDivided);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAddUp);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Name = "_0711_MyClac";
            this.Text = "_0711_MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDivided;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAddUp;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelNum1;
    }
}