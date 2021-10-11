
namespace BlackJack
{
    partial class Form1
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
            this.btnCrearCarta = new System.Windows.Forms.Button();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCrearCarta
            // 
            this.btnCrearCarta.Location = new System.Drawing.Point(119, 127);
            this.btnCrearCarta.Name = "btnCrearCarta";
            this.btnCrearCarta.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCarta.TabIndex = 0;
            this.btnCrearCarta.Text = "Agregar";
            this.btnCrearCarta.UseVisualStyleBackColor = true;
            this.btnCrearCarta.Click += new System.EventHandler(this.btnCrearCarta_Click);
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(309, 42);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(279, 227);
            this.rtxtResults.TabIndex = 2;
            this.rtxtResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.btnCrearCarta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCarta;
        private System.Windows.Forms.RichTextBox rtxtResults;
    }
}

