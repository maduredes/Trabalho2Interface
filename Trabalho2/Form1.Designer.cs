namespace Trabalho2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnEquipe = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(830, 161);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(28, 270);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(830, 144);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // btnEquipe
            // 
            this.btnEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipe.Image = global::Trabalho2.Properties.Resources.trabalho_em_equipe__1_;
            this.btnEquipe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEquipe.Location = new System.Drawing.Point(607, 201);
            this.btnEquipe.Name = "btnEquipe";
            this.btnEquipe.Size = new System.Drawing.Size(244, 53);
            this.btnEquipe.TabIndex = 2;
            this.btnEquipe.Text = "Equipe";
            this.btnEquipe.UseVisualStyleBackColor = true;
            this.btnEquipe.Click += new System.EventHandler(this.btnEquipe_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::Trabalho2.Properties.Resources.eraser__2_;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(324, 201);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(277, 53);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Image = global::Trabalho2.Properties.Resources.analise__1_;
            this.btnAnalisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalisar.Location = new System.Drawing.Point(28, 201);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(272, 53);
            this.btnAnalisar.TabIndex = 0;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(779, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Linhas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnEquipe);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAnalisar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEquipe;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

