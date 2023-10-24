namespace Kiosk_project
{
    partial class Ak47
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ak47));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_ak47 = new System.Windows.Forms.Button();
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
            // btn_ak47
            // 
            btn_ak47.DialogResult = System.Windows.Forms.DialogResult.OK;
            btn_ak47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_ak47.Image = (System.Drawing.Image)resources.GetObject("btn_ak47.Image");
            btn_ak47.Location = new System.Drawing.Point(189, 261);
            btn_ak47.Name = "btn_ak47";
            btn_ak47.Size = new System.Drawing.Size(134, 39);
            btn_ak47.TabIndex = 2;
            btn_ak47.UseVisualStyleBackColor = true;
            btn_ak47.Click += btn_ak47_Click;
            // 
            // Ak47
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(513, 312);
            Controls.Add(btn_ak47);
            Controls.Add(pictureBox1);
            Name = "Ak47";
            Text = "Ak47";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_ak47;
    }
}