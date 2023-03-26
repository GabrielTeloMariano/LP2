
namespace PVolume
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
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.tbRaio = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(51, 389);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(101, 35);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btn_calcular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_calcular_KeyPress);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(237, 389);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(101, 35);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tbRaio
            // 
            this.tbRaio.Location = new System.Drawing.Point(201, 49);
            this.tbRaio.Name = "tbRaio";
            this.tbRaio.Size = new System.Drawing.Size(100, 34);
            this.tbRaio.TabIndex = 1;
            this.tbRaio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRaio_KeyPress);
            this.tbRaio.Validated += new System.EventHandler(this.tbRaio_Validated);
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(201, 118);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(100, 34);
            this.tbAltura.TabIndex = 2;
            this.tbAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAltura_KeyPress);
            this.tbAltura.Validated += new System.EventHandler(this.tbAltura_Validated);
            // 
            // tbVolume
            // 
            this.tbVolume.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbVolume.Enabled = false;
            this.tbVolume.Location = new System.Drawing.Point(201, 197);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(100, 34);
            this.tbVolume.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 452);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.tbRaio);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Cálculo do Volume do Cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.TextBox tbRaio;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.TextBox tbVolume;
    }
}

