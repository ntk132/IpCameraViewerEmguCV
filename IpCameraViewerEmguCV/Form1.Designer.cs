namespace IpCameraViewerEmguCV
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
            this.components = new System.ComponentModel.Container();
            this.btStart = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.imageBox6 = new Emgu.CV.UI.ImageBox();
            this.btTakePhoto = new System.Windows.Forms.Button();
            this.imageBox7 = new Emgu.CV.UI.ImageBox();
            this.imageBox8 = new Emgu.CV.UI.ImageBox();
            this.btCompare = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStart.Location = new System.Drawing.Point(12, 626);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 9;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(300, 215);
            this.imageBox1.TabIndex = 10;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox2.Location = new System.Drawing.Point(12, 274);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(300, 215);
            this.imageBox2.TabIndex = 10;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox3.Location = new System.Drawing.Point(318, 12);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(300, 215);
            this.imageBox3.TabIndex = 11;
            this.imageBox3.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox4.Location = new System.Drawing.Point(318, 274);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(300, 215);
            this.imageBox4.TabIndex = 11;
            this.imageBox4.TabStop = false;
            // 
            // imageBox5
            // 
            this.imageBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox5.Location = new System.Drawing.Point(624, 12);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(300, 215);
            this.imageBox5.TabIndex = 11;
            this.imageBox5.TabStop = false;
            // 
            // imageBox6
            // 
            this.imageBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox6.Location = new System.Drawing.Point(624, 274);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(300, 215);
            this.imageBox6.TabIndex = 11;
            this.imageBox6.TabStop = false;
            // 
            // btTakePhoto
            // 
            this.btTakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btTakePhoto.Location = new System.Drawing.Point(237, 626);
            this.btTakePhoto.Name = "btTakePhoto";
            this.btTakePhoto.Size = new System.Drawing.Size(75, 23);
            this.btTakePhoto.TabIndex = 9;
            this.btTakePhoto.Text = "Capture";
            this.btTakePhoto.UseVisualStyleBackColor = true;
            this.btTakePhoto.Click += new System.EventHandler(this.btTakePhoto_Click);
            // 
            // imageBox7
            // 
            this.imageBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox7.Location = new System.Drawing.Point(930, 12);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.Size = new System.Drawing.Size(300, 215);
            this.imageBox7.TabIndex = 11;
            this.imageBox7.TabStop = false;
            // 
            // imageBox8
            // 
            this.imageBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox8.Location = new System.Drawing.Point(930, 274);
            this.imageBox8.Name = "imageBox8";
            this.imageBox8.Size = new System.Drawing.Size(300, 215);
            this.imageBox8.TabIndex = 11;
            this.imageBox8.TabStop = false;
            // 
            // btCompare
            // 
            this.btCompare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCompare.Location = new System.Drawing.Point(930, 626);
            this.btCompare.Name = "btCompare";
            this.btCompare.Size = new System.Drawing.Size(75, 23);
            this.btCompare.TabIndex = 12;
            this.btCompare.Text = "Compare";
            this.btCompare.UseVisualStyleBackColor = true;
            this.btCompare.Click += new System.EventHandler(this.btCompare_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(543, 626);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 14;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 661);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCompare);
            this.Controls.Add(this.imageBox8);
            this.Controls.Add(this.imageBox6);
            this.Controls.Add(this.imageBox7);
            this.Controls.Add(this.imageBox5);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btTakePhoto);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox4;
        private Emgu.CV.UI.ImageBox imageBox5;
        private Emgu.CV.UI.ImageBox imageBox6;
        private System.Windows.Forms.Button btTakePhoto;
        private Emgu.CV.UI.ImageBox imageBox7;
        private Emgu.CV.UI.ImageBox imageBox8;
        private System.Windows.Forms.Button btCompare;
        private System.Windows.Forms.Button btReset;
    }
}

