
namespace _02_Alumnos
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
            this.lst_Alumnos = new System.Windows.Forms.ListBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lst_Alumnos
            // 
            this.lst_Alumnos.FormattingEnabled = true;
            this.lst_Alumnos.ItemHeight = 24;
            this.lst_Alumnos.Location = new System.Drawing.Point(800, 52);
            this.lst_Alumnos.Name = "lst_Alumnos";
            this.lst_Alumnos.Size = new System.Drawing.Size(384, 460);
            this.lst_Alumnos.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(359, 315);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(137, 62);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingreso de Alumos";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(420, 94);
            this.txt_Cedula.MaxLength = 17;
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(362, 29);
            this.txt_Cedula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombres";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(420, 129);
            this.txt_Nombres.MaxLength = 200;
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(362, 29);
            this.txt_Nombres.TabIndex = 10;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(420, 164);
            this.txt_Apellidos.MaxLength = 200;
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(362, 29);
            this.txt_Apellidos.TabIndex = 11;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(420, 199);
            this.txt_Direccion.MaxLength = 200;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(362, 29);
            this.txt_Direccion.TabIndex = 12;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(420, 234);
            this.txt_Telefono.MaxLength = 200;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(362, 29);
            this.txt_Telefono.TabIndex = 13;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(502, 315);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(137, 62);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(645, 315);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(137, 62);
            this.btn_Eliminar.TabIndex = 16;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(420, 269);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(362, 29);
            this.dtp_Fecha.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 1061);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Nombres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lst_Alumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Alumnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Alumnos;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
    }
}

