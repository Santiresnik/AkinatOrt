
namespace AkinatOrt
{
    partial class temas
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
            this.RbOtaku = new System.Windows.Forms.RadioButton();
            this.Rbpayaso = new System.Windows.Forms.RadioButton();
            this.RbDefault = new System.Windows.Forms.RadioButton();
            this.RbPlaya = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RbOtaku
            // 
            this.RbOtaku.AutoSize = true;
            this.RbOtaku.Location = new System.Drawing.Point(16, 214);
            this.RbOtaku.Name = "RbOtaku";
            this.RbOtaku.Size = new System.Drawing.Size(14, 13);
            this.RbOtaku.TabIndex = 7;
            this.RbOtaku.TabStop = true;
            this.RbOtaku.UseVisualStyleBackColor = true;
            this.RbOtaku.CheckedChanged += new System.EventHandler(this.RbOtaku_CheckedChanged);
            // 
            // Rbpayaso
            // 
            this.Rbpayaso.AutoSize = true;
            this.Rbpayaso.Location = new System.Drawing.Point(16, 158);
            this.Rbpayaso.Name = "Rbpayaso";
            this.Rbpayaso.Size = new System.Drawing.Size(14, 13);
            this.Rbpayaso.TabIndex = 8;
            this.Rbpayaso.TabStop = true;
            this.Rbpayaso.UseVisualStyleBackColor = true;
            this.Rbpayaso.CheckedChanged += new System.EventHandler(this.Rbpayaso_CheckedChanged);
            // 
            // RbDefault
            // 
            this.RbDefault.AutoSize = true;
            this.RbDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RbDefault.Location = new System.Drawing.Point(16, 29);
            this.RbDefault.Name = "RbDefault";
            this.RbDefault.Size = new System.Drawing.Size(14, 13);
            this.RbDefault.TabIndex = 6;
            this.RbDefault.TabStop = true;
            this.RbDefault.UseVisualStyleBackColor = true;
            this.RbDefault.CheckedChanged += new System.EventHandler(this.RbDefault_CheckedChanged);
            // 
            // RbPlaya
            // 
            this.RbPlaya.AutoSize = true;
            this.RbPlaya.Location = new System.Drawing.Point(16, 95);
            this.RbPlaya.Name = "RbPlaya";
            this.RbPlaya.Size = new System.Drawing.Size(14, 13);
            this.RbPlaya.TabIndex = 9;
            this.RbPlaya.TabStop = true;
            this.RbPlaya.UseVisualStyleBackColor = true;
            this.RbPlaya.CheckedChanged += new System.EventHandler(this.RbPlaya_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RbPlaya);
            this.groupBox1.Controls.Add(this.RbDefault);
            this.groupBox1.Controls.Add(this.Rbpayaso);
            this.groupBox1.Controls.Add(this.RbOtaku);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(355, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(50, 233);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AkinatOrt.Properties.Resources.personajes1;
            this.pictureBox1.Location = new System.Drawing.Point(-135, -106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "temas";
            this.Text = "Temas";
            this.Load += new System.EventHandler(this.temas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RbOtaku;
        private System.Windows.Forms.RadioButton Rbpayaso;
        private System.Windows.Forms.RadioButton RbDefault;
        private System.Windows.Forms.RadioButton RbPlaya;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}