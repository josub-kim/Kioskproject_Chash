namespace Kiosk_project
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            btnbuy = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(751, 862);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButton1.Location = new System.Drawing.Point(67, 356);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(14, 13);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButton2.Location = new System.Drawing.Point(67, 395);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(14, 13);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButton3.Location = new System.Drawing.Point(67, 437);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(14, 13);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButton4.Location = new System.Drawing.Point(67, 474);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(14, 13);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // btnbuy
            // 
            btnbuy.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnbuy.Image = (System.Drawing.Image)resources.GetObject("btnbuy.Image");
            btnbuy.Location = new System.Drawing.Point(135, 802);
            btnbuy.Name = "btnbuy";
            btnbuy.Size = new System.Drawing.Size(154, 36);
            btnbuy.TabIndex = 16;
            btnbuy.UseVisualStyleBackColor = true;
            btnbuy.Click += btnbuy_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.Color.Khaki;
            textBox1.Location = new System.Drawing.Point(319, 607);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(78, 27);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox2.ForeColor = System.Drawing.Color.Khaki;
            textBox2.Location = new System.Drawing.Point(319, 640);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(78, 27);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox3.ForeColor = System.Drawing.Color.Khaki;
            textBox3.Location = new System.Drawing.Point(319, 718);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(78, 27);
            textBox3.TabIndex = 20;
            // 
            // Form12
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(750, 860);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnbuy);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Name = "Form12";
            Text = "Form12";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}