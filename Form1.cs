using System;
using System.Windows.Forms;

namespace _02_Alumnos
{
    public partial class Form_Alumnos : Form
    {
        bool estado = false;
        int posicion = -1;
        public Form_Alumnos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            
            if (txt_Cedula.Text != "" && txt_Nombres.Text != "" && txt_Apellidos.Text != "" && txt_Direccion.Text != "" && txt_Telefono.Text != "")
            {
               if (estado == true)
                {
                    lst_Alumnos.Items[posicion] = txt_Cedula.Text +" || "+ txt_Nombres.Text + " || " + txt_Apellidos.Text + " || " + txt_Direccion.Text + " || " + txt_Telefono.Text + " || " + dtp_Fecha.Text;
                    estado = false;
                    posicion = -1;
                    LimpiarCajas();
                }
                else
                {               
                    lst_Alumnos.Items.Add(txt_Cedula.Text + " || " + txt_Nombres.Text + " || " + txt_Apellidos.Text + " || " + txt_Direccion.Text + " || " + txt_Telefono.Text + " || " + dtp_Fecha.Text);
                    LimpiarCajas();
                    estado = false;
                }
            }
            else { MessageBox.Show("Complete las casillas para guardar la informacion"); }

            
        }

        public void LimpiarCajas() {
            txt_Apellidos.Text = "";
            txt_Cedula.Text = "";
            txt_Direccion.Text = "";
            txt_Nombres.Text = "";
            txt_Telefono.Text = "";         
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Alumnos.SelectedIndex == -1)
            {
                MessageBox.Show("Companiero, seleccione un item de la lista");
                return;
            }
                DialogResult dialogResult = 
                    MessageBox.Show("Esta seguro que desea eliminar al alumno!!!", "Alumnos", 
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lst_Alumnos.Items.RemoveAt(lst_Alumnos.SelectedIndex);
                    MessageBox.Show("Se elimino con exito");
                }
                else {
                    MessageBox.Show("El usuario cancelo la operacion");
                }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_Alumnos.SelectedIndex != -1)
            {
                string seleccion = lst_Alumnos.SelectedItem.ToString();
                string[] partesdelAlumnos = seleccion.Split(new string[] { "||" }, StringSplitOptions.None);
                txt_Cedula.Text = partesdelAlumnos[0];
                txt_Nombres.Text = partesdelAlumnos[1];
                txt_Apellidos.Text = partesdelAlumnos[2];
                txt_Direccion.Text =  partesdelAlumnos[3];
                txt_Telefono.Text = partesdelAlumnos[4];
                dtp_Fecha.Text = partesdelAlumnos[5];
                estado = true;
                posicion = lst_Alumnos.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Companiero, seleccione un item de la lista");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
    }
}
