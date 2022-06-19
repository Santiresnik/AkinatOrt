
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
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnElegante = new System.Windows.Forms.Button();
            this.btnJedi = new System.Windows.Forms.Button();
            this.btnOtaku = new System.Windows.Forms.Button();
            this.btnPayaso = new System.Windows.Forms.Button();
            this.btnPlaya = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnDefault.Location = new System.Drawing.Point(45, 71);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(160, 80);
            this.btnDefault.TabIndex = 0;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnElegante
            // 
            this.btnElegante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnElegante.Location = new System.Drawing.Point(281, 71);
            this.btnElegante.Name = "btnElegante";
            this.btnElegante.Size = new System.Drawing.Size(160, 80);
            this.btnElegante.TabIndex = 1;
            this.btnElegante.Text = "Elegante";
            this.btnElegante.UseVisualStyleBackColor = true;
            this.btnElegante.Click += new System.EventHandler(this.btnElegante_Click);
            // 
            // btnJedi
            // 
            this.btnJedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnJedi.Location = new System.Drawing.Point(527, 71);
            this.btnJedi.Name = "btnJedi";
            this.btnJedi.Size = new System.Drawing.Size(160, 80);
            this.btnJedi.TabIndex = 2;
            this.btnJedi.Text = "Jedi";
            this.btnJedi.UseVisualStyleBackColor = true;
            this.btnJedi.Click += new System.EventHandler(this.btnJedi_Click);
            // 
            // btnOtaku
            // 
            this.btnOtaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOtaku.Location = new System.Drawing.Point(45, 201);
            this.btnOtaku.Name = "btnOtaku";
            this.btnOtaku.Size = new System.Drawing.Size(160, 80);
            this.btnOtaku.TabIndex = 3;
            this.btnOtaku.Text = "Otaku";
            this.btnOtaku.UseVisualStyleBackColor = true;
            this.btnOtaku.Click += new System.EventHandler(this.btnOtaku_Click);
            // 
            // btnPayaso
            // 
            this.btnPayaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPayaso.Location = new System.Drawing.Point(281, 201);
            this.btnPayaso.Name = "btnPayaso";
            this.btnPayaso.Size = new System.Drawing.Size(160, 80);
            this.btnPayaso.TabIndex = 4;
            this.btnPayaso.Text = "Payaso";
            this.btnPayaso.UseVisualStyleBackColor = true;
            this.btnPayaso.Click += new System.EventHandler(this.btnPayaso_Click);
            // 
            // btnPlaya
            // 
            this.btnPlaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPlaya.Location = new System.Drawing.Point(527, 201);
            this.btnPlaya.Name = "btnPlaya";
            this.btnPlaya.Size = new System.Drawing.Size(160, 80);
            this.btnPlaya.TabIndex = 5;
            this.btnPlaya.Text = "Playa";
            this.btnPlaya.UseVisualStyleBackColor = true;
            this.btnPlaya.Click += new System.EventHandler(this.Playa_Click);
            // 
            // temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlaya);
            this.Controls.Add(this.btnPayaso);
            this.Controls.Add(this.btnOtaku);
            this.Controls.Add(this.btnJedi);
            this.Controls.Add(this.btnElegante);
            this.Controls.Add(this.btnDefault);
            this.Name = "temas";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnElegante;
        private System.Windows.Forms.Button btnJedi;
        private System.Windows.Forms.Button btnOtaku;
        private System.Windows.Forms.Button btnPayaso;
        private System.Windows.Forms.Button btnPlaya;
    }
}