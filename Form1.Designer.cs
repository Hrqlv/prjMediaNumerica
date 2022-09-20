namespace Projeto_Media_Numerica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor de A :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtA.Location = new System.Drawing.Point(210, 15);
            this.txtA.MaxLength = 10;
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(99, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o valor de B :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtB.Location = new System.Drawing.Point(210, 45);
            this.txtB.MaxLength = 10;
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(99, 20);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            this.txtB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCalcularMedia.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularMedia.Location = new System.Drawing.Point(23, 76);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(273, 24);
            this.btnCalcularMedia.TabIndex = 3;
            this.btnCalcularMedia.Text = "Calcular MEdia Numerica";
            this.btnCalcularMedia.UseVisualStyleBackColor = false;
            this.btnCalcularMedia.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(308, 145);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Motorwerk", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "PROGRAMA DA MÉDIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalcularMedia;
    }
}

