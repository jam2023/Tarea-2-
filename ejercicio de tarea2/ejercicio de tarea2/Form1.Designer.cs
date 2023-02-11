namespace ejercicio_de_tarea2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nota1textBox = new System.Windows.Forms.TextBox();
            this.nota4textBox = new System.Windows.Forms.TextBox();
            this.nota3textBox = new System.Windows.Forms.TextBox();
            this.nota2textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.promediotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Primera nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la segunda nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la tercera nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese la cuarta nota";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nota1textBox
            // 
            this.nota1textBox.Location = new System.Drawing.Point(339, 101);
            this.nota1textBox.Name = "nota1textBox";
            this.nota1textBox.Size = new System.Drawing.Size(152, 22);
            this.nota1textBox.TabIndex = 5;
            // 
            // nota4textBox
            // 
            this.nota4textBox.Location = new System.Drawing.Point(339, 258);
            this.nota4textBox.Name = "nota4textBox";
            this.nota4textBox.Size = new System.Drawing.Size(152, 22);
            this.nota4textBox.TabIndex = 6;
            // 
            // nota3textBox
            // 
            this.nota3textBox.Location = new System.Drawing.Point(339, 207);
            this.nota3textBox.Name = "nota3textBox";
            this.nota3textBox.Size = new System.Drawing.Size(152, 22);
            this.nota3textBox.TabIndex = 7;
            // 
            // nota2textBox
            // 
            this.nota2textBox.Location = new System.Drawing.Point(339, 148);
            this.nota2textBox.Name = "nota2textBox";
            this.nota2textBox.Size = new System.Drawing.Size(152, 22);
            this.nota2textBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(488, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Programa para calcular el promedio final";
            // 
            // promediotextBox
            // 
            this.promediotextBox.Location = new System.Drawing.Point(571, 336);
            this.promediotextBox.Name = "promediotextBox";
            this.promediotextBox.Size = new System.Drawing.Size(100, 22);
            this.promediotextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Promedio del alumno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.promediotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nota2textBox);
            this.Controls.Add(this.nota3textBox);
            this.Controls.Add(this.nota4textBox);
            this.Controls.Add(this.nota1textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nota1textBox;
        private System.Windows.Forms.TextBox nota4textBox;
        private System.Windows.Forms.TextBox nota3textBox;
        private System.Windows.Forms.TextBox nota2textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox promediotextBox;
        private System.Windows.Forms.Label label6;
    }
}

