namespace Ejercicio1
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarYVerAlumno = new System.Windows.Forms.Button();
            this.rbSecuencial = new System.Windows.Forms.RadioButton();
            this.rbBinaria = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMostrarListadoOrdenado = new System.Windows.Forms.Button();
            this.rbBurbuja = new System.Windows.Forms.RadioButton();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarAlumno);
            this.groupBox1.Location = new System.Drawing.Point(276, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud de valor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(58, 41);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarAlumno.TabIndex = 0;
            this.btnRegistrarAlumno.Text = "Registrar";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBinaria);
            this.groupBox2.Controls.Add(this.rbSecuencial);
            this.groupBox2.Controls.Add(this.btnBuscarYVerAlumno);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbLU);
            this.groupBox2.Location = new System.Drawing.Point(276, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salidas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbLU
            // 
            this.tbLU.Location = new System.Drawing.Point(39, 43);
            this.tbLU.Name = "tbLU";
            this.tbLU.Size = new System.Drawing.Size(70, 20);
            this.tbLU.TabIndex = 0;
            this.tbLU.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LU: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarYVerAlumno
            // 
            this.btnBuscarYVerAlumno.Location = new System.Drawing.Point(115, 40);
            this.btnBuscarYVerAlumno.Name = "btnBuscarYVerAlumno";
            this.btnBuscarYVerAlumno.Size = new System.Drawing.Size(74, 23);
            this.btnBuscarYVerAlumno.TabIndex = 2;
            this.btnBuscarYVerAlumno.Text = "Buscar";
            this.btnBuscarYVerAlumno.UseVisualStyleBackColor = true;
            // 
            // rbSecuencial
            // 
            this.rbSecuencial.AutoSize = true;
            this.rbSecuencial.Location = new System.Drawing.Point(20, 77);
            this.rbSecuencial.Name = "rbSecuencial";
            this.rbSecuencial.Size = new System.Drawing.Size(78, 17);
            this.rbSecuencial.TabIndex = 3;
            this.rbSecuencial.TabStop = true;
            this.rbSecuencial.Text = "Secuencial";
            this.rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // rbBinaria
            // 
            this.rbBinaria.AutoSize = true;
            this.rbBinaria.Location = new System.Drawing.Point(115, 77);
            this.rbBinaria.Name = "rbBinaria";
            this.rbBinaria.Size = new System.Drawing.Size(57, 17);
            this.rbBinaria.TabIndex = 2;
            this.rbBinaria.TabStop = true;
            this.rbBinaria.Text = "Binaria";
            this.rbBinaria.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbQuickSort);
            this.groupBox3.Controls.Add(this.rbBurbuja);
            this.groupBox3.Controls.Add(this.btnMostrarListadoOrdenado);
            this.groupBox3.Location = new System.Drawing.Point(276, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salidas";
            // 
            // btnMostrarListadoOrdenado
            // 
            this.btnMostrarListadoOrdenado.Location = new System.Drawing.Point(58, 19);
            this.btnMostrarListadoOrdenado.Name = "btnMostrarListadoOrdenado";
            this.btnMostrarListadoOrdenado.Size = new System.Drawing.Size(92, 23);
            this.btnMostrarListadoOrdenado.TabIndex = 0;
            this.btnMostrarListadoOrdenado.Text = "MostrarListado";
            this.btnMostrarListadoOrdenado.UseVisualStyleBackColor = true;
            this.btnMostrarListadoOrdenado.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbBurbuja
            // 
            this.rbBurbuja.AutoSize = true;
            this.rbBurbuja.Checked = true;
            this.rbBurbuja.Location = new System.Drawing.Point(20, 67);
            this.rbBurbuja.Name = "rbBurbuja";
            this.rbBurbuja.Size = new System.Drawing.Size(61, 17);
            this.rbBurbuja.TabIndex = 1;
            this.rbBurbuja.TabStop = true;
            this.rbBurbuja.Text = "Burbuja";
            this.rbBurbuja.UseVisualStyleBackColor = true;
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Location = new System.Drawing.Point(109, 67);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(72, 17);
            this.rbQuickSort.TabIndex = 3;
            this.rbQuickSort.Text = "QuickSort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBinaria;
        private System.Windows.Forms.RadioButton rbSecuencial;
        private System.Windows.Forms.Button btnBuscarYVerAlumno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMostrarListadoOrdenado;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbBurbuja;
    }
}

