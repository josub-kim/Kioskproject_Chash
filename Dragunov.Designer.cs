namespace Kiosk_project
{
    partial class Dragunov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dragunov));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnm4buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(511, 313);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnm4buy
            // 
            btnm4buy.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnm4buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnm4buy.Image = (System.Drawing.Image)resources.GetObject("btnm4buy.Image");
            btnm4buy.Location = new System.Drawing.Point(191, 260);
            btnm4buy.Name = "btnm4buy";
            btnm4buy.Size = new System.Drawing.Size(134, 39);
            btnm4buy.TabIndex = 6;
            btnm4buy.UseVisualStyleBackColor = true;
            btnm4buy.Click += btnm4buy_Click;
            // 
            // Dragunov
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(512, 311);
            Controls.Add(btnm4buy);
            Controls.Add(pictureBox1);
            Name = "Dragunov";
            Text = "Dragunov";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnm4buy;
    }
}