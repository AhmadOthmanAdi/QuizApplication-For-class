namespace Othmanadi
{
    partial class QuizType
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
            this.btnCoutry = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnCapitals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Quiz Type To Guess";
            // 
            // btnCoutry
            // 
            this.btnCoutry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoutry.Location = new System.Drawing.Point(50, 94);
            this.btnCoutry.Name = "btnCoutry";
            this.btnCoutry.Size = new System.Drawing.Size(140, 35);
            this.btnCoutry.TabIndex = 1;
            this.btnCoutry.Text = "Coutries";
            this.btnCoutry.UseVisualStyleBackColor = true;
            this.btnCoutry.Click += new System.EventHandler(this.btnCoutry_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlag.Location = new System.Drawing.Point(259, 94);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(140, 35);
            this.btnFlag.TabIndex = 2;
            this.btnFlag.Text = "Flags";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnCapitals
            // 
            this.btnCapitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapitals.Location = new System.Drawing.Point(468, 94);
            this.btnCapitals.Name = "btnCapitals";
            this.btnCapitals.Size = new System.Drawing.Size(140, 35);
            this.btnCapitals.TabIndex = 3;
            this.btnCapitals.Text = "Capitals";
            this.btnCapitals.UseVisualStyleBackColor = true;
            this.btnCapitals.Click += new System.EventHandler(this.btnCapitals_Click);
            // 
            // QuizType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 268);
            this.Controls.Add(this.btnCapitals);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnCoutry);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizType";
            this.Text = "Select Quiz Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCoutry;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnCapitals;
    }
}