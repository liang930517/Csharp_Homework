
namespace HomePage
{
    partial class Guess
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
            this.BtnShowAns = new System.Windows.Forms.Button();
            this.dialogButton = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnShowAns
            // 
            this.BtnShowAns.Font = new System.Drawing.Font("Arial", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowAns.Location = new System.Drawing.Point(389, 206);
            this.BtnShowAns.Name = "BtnShowAns";
            this.BtnShowAns.Size = new System.Drawing.Size(281, 70);
            this.BtnShowAns.TabIndex = 5;
            this.BtnShowAns.Text = "Show Answer";
            this.BtnShowAns.UseVisualStyleBackColor = true;
            this.BtnShowAns.Click += new System.EventHandler(this.BtnShowAns_Click);
            // 
            // dialogButton
            // 
            this.dialogButton.Font = new System.Drawing.Font("Arial", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogButton.Location = new System.Drawing.Point(76, 206);
            this.dialogButton.Name = "dialogButton";
            this.dialogButton.Size = new System.Drawing.Size(281, 70);
            this.dialogButton.TabIndex = 4;
            this.dialogButton.Text = "Guess";
            this.dialogButton.UseVisualStyleBackColor = true;
            this.dialogButton.Click += new System.EventHandler(this.dialogButton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(70, 126);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(621, 36);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Please Select A Number Between 1 to 100!";
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnShowAns);
            this.Controls.Add(this.dialogButton);
            this.Controls.Add(this.labelTitle);
            this.Name = "Guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowAns;
        private System.Windows.Forms.Button dialogButton;
        private System.Windows.Forms.Label labelTitle;
    }
}