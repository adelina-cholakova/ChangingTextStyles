namespace TextChanger
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
            this.addTextTb = new System.Windows.Forms.TextBox();
            this.boldChB = new System.Windows.Forms.CheckBox();
            this.italicChB = new System.Windows.Forms.CheckBox();
            this.firstChoiceRb = new System.Windows.Forms.RadioButton();
            this.secondChoiceRb = new System.Windows.Forms.RadioButton();
            this.thirdChoiceRb = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведете текст:";
            // 
            // addTextTb
            // 
            this.addTextTb.Location = new System.Drawing.Point(85, 102);
            this.addTextTb.Multiline = true;
            this.addTextTb.Name = "addTextTb";
            this.addTextTb.Size = new System.Drawing.Size(284, 168);
            this.addTextTb.TabIndex = 1;
            // 
            // boldChB
            // 
            this.boldChB.AutoSize = true;
            this.boldChB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boldChB.Location = new System.Drawing.Point(571, 109);
            this.boldChB.Name = "boldChB";
            this.boldChB.Size = new System.Drawing.Size(69, 24);
            this.boldChB.TabIndex = 2;
            this.boldChB.Text = "Bold";
            this.boldChB.UseVisualStyleBackColor = true;
            this.boldChB.CheckedChanged += new System.EventHandler(this.boldChB_CheckedChanged);
            // 
            // italicChB
            // 
            this.italicChB.AutoSize = true;
            this.italicChB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italicChB.Location = new System.Drawing.Point(575, 160);
            this.italicChB.Name = "italicChB";
            this.italicChB.Size = new System.Drawing.Size(66, 24);
            this.italicChB.TabIndex = 3;
            this.italicChB.Text = "Italic";
            this.italicChB.UseVisualStyleBackColor = true;
            this.italicChB.CheckedChanged += new System.EventHandler(this.italicChB_CheckedChanged);
            // 
            // firstChoiceRb
            // 
            this.firstChoiceRb.AutoSize = true;
            this.firstChoiceRb.Location = new System.Drawing.Point(85, 310);
            this.firstChoiceRb.Name = "firstChoiceRb";
            this.firstChoiceRb.Size = new System.Drawing.Size(100, 21);
            this.firstChoiceRb.TabIndex = 4;
            this.firstChoiceRb.TabStop = true;
            this.firstChoiceRb.Text = "Arial + blue";
            this.firstChoiceRb.UseVisualStyleBackColor = true;
            this.firstChoiceRb.CheckedChanged += new System.EventHandler(this.firstChoiceRb_CheckedChanged);
            // 
            // secondChoiceRb
            // 
            this.secondChoiceRb.AutoSize = true;
            this.secondChoiceRb.Location = new System.Drawing.Point(85, 350);
            this.secondChoiceRb.Name = "secondChoiceRb";
            this.secondChoiceRb.Size = new System.Drawing.Size(149, 21);
            this.secondChoiceRb.TabIndex = 5;
            this.secondChoiceRb.TabStop = true;
            this.secondChoiceRb.Text = "Alex Brush + green";
            this.secondChoiceRb.UseVisualStyleBackColor = true;
            this.secondChoiceRb.CheckedChanged += new System.EventHandler(this.secondChoiceRb_CheckedChanged);
            // 
            // thirdChoiceRb
            // 
            this.thirdChoiceRb.AutoSize = true;
            this.thirdChoiceRb.Location = new System.Drawing.Point(85, 395);
            this.thirdChoiceRb.Name = "thirdChoiceRb";
            this.thirdChoiceRb.Size = new System.Drawing.Size(118, 21);
            this.thirdChoiceRb.TabIndex = 6;
            this.thirdChoiceRb.TabStop = true;
            this.thirdChoiceRb.Text = "Algerian + red";
            this.thirdChoiceRb.UseVisualStyleBackColor = true;
            this.thirdChoiceRb.CheckedChanged += new System.EventHandler(this.thirdChoiceRb_CheckedChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(544, 326);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(119, 45);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Изход";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.thirdChoiceRb);
            this.Controls.Add(this.secondChoiceRb);
            this.Controls.Add(this.firstChoiceRb);
            this.Controls.Add(this.italicChB);
            this.Controls.Add(this.boldChB);
            this.Controls.Add(this.addTextTb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addTextTb;
        private System.Windows.Forms.CheckBox boldChB;
        private System.Windows.Forms.CheckBox italicChB;
        private System.Windows.Forms.RadioButton firstChoiceRb;
        private System.Windows.Forms.RadioButton secondChoiceRb;
        private System.Windows.Forms.RadioButton thirdChoiceRb;
        private System.Windows.Forms.Button exitBtn;
    }
}

