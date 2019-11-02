namespace TI_POO_AC2
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtHexa1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIEEE7541 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtIEEE7542 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHexa2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(184, 100);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // txtHexa1
            // 
            this.txtHexa1.Location = new System.Drawing.Point(534, 100);
            this.txtHexa1.Name = "txtHexa1";
            this.txtHexa1.ReadOnly = true;
            this.txtHexa1.Size = new System.Drawing.Size(72, 20);
            this.txtHexa1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hexadecimal";
            // 
            // txtIEEE7541
            // 
            this.txtIEEE7541.Location = new System.Drawing.Point(312, 100);
            this.txtIEEE7541.Name = "txtIEEE7541";
            this.txtIEEE7541.ReadOnly = true;
            this.txtIEEE7541.Size = new System.Drawing.Size(204, 20);
            this.txtIEEE7541.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IEEE754";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(356, 231);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtIEEE7542
            // 
            this.txtIEEE7542.Location = new System.Drawing.Point(312, 149);
            this.txtIEEE7542.Name = "txtIEEE7542";
            this.txtIEEE7542.ReadOnly = true;
            this.txtIEEE7542.Size = new System.Drawing.Size(204, 20);
            this.txtIEEE7542.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "IEEE754";
            // 
            // txtHexa2
            // 
            this.txtHexa2.Location = new System.Drawing.Point(534, 149);
            this.txtHexa2.Name = "txtHexa2";
            this.txtHexa2.ReadOnly = true;
            this.txtHexa2.Size = new System.Drawing.Size(72, 20);
            this.txtHexa2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hexadecimal";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(184, 149);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Número 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIEEE7542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHexa2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtIEEE7541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHexa1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtHexa1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIEEE7541;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtIEEE7542;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHexa2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label6;
    }
}

