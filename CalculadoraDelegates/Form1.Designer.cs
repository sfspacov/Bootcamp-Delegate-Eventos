namespace CalculadoraDelegates
{
    partial class Form1
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
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(30, 93);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(46, 31);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.TabStop = false;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(62, 54);
            this.txtValor1.MaxLength = 3;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(66, 29);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor1_KeyDown);
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor1_KeyPress);
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(134, 54);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(66, 29);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor2_KeyPress);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(82, 93);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(46, 31);
            this.btnSubtrair.TabIndex = 0;
            this.btnSubtrair.TabStop = false;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(134, 93);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(46, 31);
            this.btnMultiplicar.TabIndex = 0;
            this.btnMultiplicar.TabStop = false;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(186, 93);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(46, 31);
            this.btnDividir.TabIndex = 0;
            this.btnDividir.TabStop = false;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Blue;
            this.txtResultado.Location = new System.Drawing.Point(62, 153);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(138, 29);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.TabStop = false;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(91, 188);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(262, 214);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Natural";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
    }
}

