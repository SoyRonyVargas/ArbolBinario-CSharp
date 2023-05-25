namespace ArbolBinario
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
            this.agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lista_datos = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_dato = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.input_dato)).BeginInit();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(369, 117);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(111, 37);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Agregar al arbol";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ordenamiento Ascendente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ordenamiento Descendente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lista_datos
            // 
            this.lista_datos.FormattingEnabled = true;
            this.lista_datos.Location = new System.Drawing.Point(27, 117);
            this.lista_datos.Name = "lista_datos";
            this.lista_datos.Size = new System.Drawing.Size(188, 199);
            this.lista_datos.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Limpiar arbol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datos arbol binario";
            // 
            // input_dato
            // 
            this.input_dato.Location = new System.Drawing.Point(252, 127);
            this.input_dato.Name = "input_dato";
            this.input_dato.Size = new System.Drawing.Size(111, 20);
            this.input_dato.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input_dato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lista_datos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input_dato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lista_datos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown input_dato;
    }
}

