namespace Kiosk_project
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            btnbuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(765, 857);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButton1.Location = new System.Drawing.Point(69, 352);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(14, 13);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButton2.Location = new System.Drawing.Point(69, 392);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(14, 13);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButton3.Location = new System.Drawing.Point(69, 431);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(14, 13);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButton4.Location = new System.Drawing.Point(69, 472);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(14, 13);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // btnbuy
            // 
            btnbuy.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnbuy.Image = (System.Drawing.Image)resources.GetObject("btnbuy.Image");
            btnbuy.Location = new System.Drawing.Point(140, 795);
            btnbuy.Name = "btnbuy";
            btnbuy.Size = new System.Drawing.Size(154, 36);
            btnbuy.TabIndex = 16;
            btnbuy.UseVisualStyleBackColor = true;
            // 
            // Form11
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(763, 856);
            Controls.Add(btnbuy);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Name = "Form11";
            Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.Button btnbuy;
    }
}