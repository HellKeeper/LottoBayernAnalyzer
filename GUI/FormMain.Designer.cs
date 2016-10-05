namespace LottoBayernAnalyzer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ImgType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgType)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgType
            // 
            this.ImgType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgType.BackColor = System.Drawing.Color.White;
            this.ImgType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgType.Image = global::LottoBayernAnalyzer.Properties.Resources.Lotto6from49;
            this.ImgType.Location = new System.Drawing.Point(12, 12);
            this.ImgType.Name = "ImgType";
            this.ImgType.Size = new System.Drawing.Size(522, 50);
            this.ImgType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgType.TabIndex = 0;
            this.ImgType.TabStop = false;
            this.ImgType.Click += new System.EventHandler(this.ImgType_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 498);
            this.Controls.Add(this.ImgType);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgType;
    }
}

