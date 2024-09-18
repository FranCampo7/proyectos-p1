namespace Calculadora_IMC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.APeso = new System.Windows.Forms.Button();
            this.AAltura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(101, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(356, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Peso
            // 
            this.Peso.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Peso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Peso.ForeColor = System.Drawing.Color.AliceBlue;
            this.Peso.Location = new System.Drawing.Point(104, 122);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(100, 20);
            this.Peso.TabIndex = 2;
            this.Peso.Text = "Ingrese...";
            this.Peso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Altura
            // 
            this.Altura.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Altura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Altura.ForeColor = System.Drawing.Color.AliceBlue;
            this.Altura.Location = new System.Drawing.Point(359, 122);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(100, 20);
            this.Altura.TabIndex = 3;
            this.Altura.Text = "Ingrese...";
            // 
            // APeso
            // 
            this.APeso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.APeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.APeso.Location = new System.Drawing.Point(210, 122);
            this.APeso.Name = "APeso";
            this.APeso.Size = new System.Drawing.Size(53, 20);
            this.APeso.TabIndex = 5;
            this.APeso.Text = "Aceptar";
            this.APeso.UseVisualStyleBackColor = false;
            // 
            // AAltura
            // 
            this.AAltura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AAltura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AAltura.Location = new System.Drawing.Point(465, 122);
            this.AAltura.Name = "AAltura";
            this.AAltura.Size = new System.Drawing.Size(53, 20);
            this.AAltura.TabIndex = 6;
            this.AAltura.Text = "Aceptar";
            this.AAltura.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(62, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(667, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calculadora IMC (Indice Masa Corporal)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(101, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resultado IMC:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AAltura);
            this.Controls.Add(this.APeso);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.Button APeso;
        private System.Windows.Forms.Button AAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

