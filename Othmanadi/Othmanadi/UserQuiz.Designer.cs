namespace Othmanadi
{
    partial class UserQuiz
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
            this.lbquestion = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.op4 = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbscore = new System.Windows.Forms.Label();
            this.lbnumber = new System.Windows.Forms.Label();
            this.lbmsg = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbquestion
            // 
            this.lbquestion.AutoSize = true;
            this.lbquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquestion.Location = new System.Drawing.Point(72, 78);
            this.lbquestion.Name = "lbquestion";
            this.lbquestion.Size = new System.Drawing.Size(109, 17);
            this.lbquestion.TabIndex = 0;
            this.lbquestion.Text = "Question Text";
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.Location = new System.Drawing.Point(75, 205);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(71, 19);
            this.op1.TabIndex = 1;
            this.op1.TabStop = true;
            this.op1.Text = "Option 1";
            this.op1.UseVisualStyleBackColor = true;
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.Location = new System.Drawing.Point(450, 205);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(71, 19);
            this.op2.TabIndex = 2;
            this.op2.TabStop = true;
            this.op2.Text = "Option 2";
            this.op2.UseVisualStyleBackColor = true;
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3.Location = new System.Drawing.Point(75, 288);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(71, 19);
            this.op3.TabIndex = 3;
            this.op3.TabStop = true;
            this.op3.Text = "Option 3";
            this.op3.UseVisualStyleBackColor = true;
            // 
            // op4
            // 
            this.op4.AutoSize = true;
            this.op4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op4.Location = new System.Drawing.Point(450, 288);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(71, 19);
            this.op4.TabIndex = 4;
            this.op4.TabStop = true;
            this.op4.Text = "Option 4";
            this.op4.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(450, 370);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(95, 23);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score:";
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbscore.Location = new System.Drawing.Point(718, 45);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(19, 20);
            this.lbscore.TabIndex = 7;
            this.lbscore.Text = "0";
            // 
            // lbnumber
            // 
            this.lbnumber.AutoSize = true;
            this.lbnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumber.Location = new System.Drawing.Point(72, 31);
            this.lbnumber.Name = "lbnumber";
            this.lbnumber.Size = new System.Drawing.Size(17, 17);
            this.lbnumber.TabIndex = 8;
            this.lbnumber.Text = "0";
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmsg.Location = new System.Drawing.Point(72, 376);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(0, 17);
            this.lbmsg.TabIndex = 9;
            // 
            // btnMenu
            // 
            this.btnMenu.Enabled = false;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(655, 370);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(95, 23);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(494, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // UserQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.lbnumber);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.op4);
            this.Controls.Add(this.op3);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.lbquestion);
            this.Name = "UserQuiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbquestion;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op4;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Label lbnumber;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}