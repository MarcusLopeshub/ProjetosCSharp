
namespace Conceito_While
{
    partial class asdasd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTeste = new System.Windows.Forms.Button();
            this.IbINumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTeste
            // 
            this.btnTeste.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTeste.Location = new System.Drawing.Point(111, 116);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(160, 74);
            this.btnTeste.TabIndex = 0;
            this.btnTeste.Text = "Teste While";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // IbINumero
            // 
            this.IbINumero.AutoSize = true;
            this.IbINumero.Location = new System.Drawing.Point(171, 86);
            this.IbINumero.Name = "IbINumero";
            this.IbINumero.Size = new System.Drawing.Size(13, 15);
            this.IbINumero.TabIndex = 1;
            this.IbINumero.Text = "0";
            // 
            // asdasd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 326);
            this.Controls.Add(this.IbINumero);
            this.Controls.Add(this.btnTeste);
            this.Name = "asdasd";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label IbINumero;
    }
}

