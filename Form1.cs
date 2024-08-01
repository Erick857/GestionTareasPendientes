
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GestionTareasPendientes
{
 
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Tarea.Text))
            {
                lst_Tareas.Items.Add(txt_Tarea.Text);
                txt_Tarea.Clear();
                txt_Tarea.Focus();
            }
            else
            {
                MessageBox.Show(" Ingresar una Tarea");
            }
        }

        private void btn_EliminarTarea_Click(object sender, EventArgs e)
        {
            if (lst_Tareas.SelectedItem != null)
            {
                lst_Tareas.Items.Remove(lst_Tareas.SelectedItem);
            }
            else
            {
                MessageBox.Show(" Seleccione una tarea para eliminar. ");
            }

        }
    }
}
