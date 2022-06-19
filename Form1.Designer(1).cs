
namespace AkinatOrt
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.btnTemas = new System.Windows.Forms.Button();
            this.lblprueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnJugar.Location = new System.Drawing.Point(475, 456);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(95, 47);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCreditos.Location = new System.Drawing.Point(94, 300);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(125, 41);
            this.btnCreditos.TabIndex = 1;
            this.btnCreditos.Text = "Creditos";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnTemas
            // 
            this.btnTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnTemas.Location = new System.Drawing.Point(94, 500);
            this.btnTemas.Name = "btnTemas";
            this.btnTemas.Size = new System.Drawing.Size(104, 46);
            this.btnTemas.TabIndex = 2;
            this.btnTemas.Text = "Temas";
            this.btnTemas.UseVisualStyleBackColor = true;
            this.btnTemas.Click += new System.EventHandler(this.btnTemas_Click);
            // 
            // lblprueba
            // 
            this.lblprueba.AutoSize = true;
            this.lblprueba.Location = new System.Drawing.Point(324, 128);
            this.lblprueba.Name = "lblprueba";
            this.lblprueba.Size = new System.Drawing.Size(35, 13);
            this.lblprueba.TabIndex = 3;
            this.lblprueba.Text = "label1";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 710);
            this.Controls.Add(this.lblprueba);
            this.Controls.Add(this.btnTemas);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnJugar);
            this.Name = "principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.Button btnTemas;
        private System.Windows.Forms.Label lblprueba;
    }
}

