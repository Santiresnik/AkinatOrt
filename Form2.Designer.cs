
namespace AkinatOrt
{
    partial class juego
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbDaro = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDaro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSi.BackColor = System.Drawing.Color.Transparent;
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnSi.Location = new System.Drawing.Point(125, 601);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(137, 74);
            this.btnSi.TabIndex = 0;
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnNo.Location = new System.Drawing.Point(344, 601);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(136, 74);
            this.btnNo.TabIndex = 1;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 83);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDaro
            // 
            this.pbDaro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbDaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDaro.Location = new System.Drawing.Point(29, 82);
            this.pbDaro.Name = "pbDaro";
            this.pbDaro.Size = new System.Drawing.Size(539, 380);
            this.pbDaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDaro.TabIndex = 5;
            this.pbDaro.TabStop = false;
            this.pbDaro.Click += new System.EventHandler(this.pbDaro_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 78);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkinatOrt.Properties.Resources.Pantalla_Juego_Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbDaro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Name = "juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDaro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDaro;
        private System.Windows.Forms.Button button1;
    }
}