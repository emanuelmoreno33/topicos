using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form_Editar : Form
    {
        public Form_Editar()
        {
            InitializeComponent();
            //Por iniciar
            Todos();
            bntAlumno.BackColor = Color.LimeGreen;
            bntAlumno.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            bntAlumno.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
        }
        // Ponen los botones en color iguales
        public void Todos() {
            btnAC.BackColor = Color.FromArgb(56, 89, 120);
            btnCredito.BackColor = Color.FromArgb(56, 89, 120);
            btnDocente.BackColor = Color.FromArgb(56, 89, 120);
            bntAlumno.BackColor = Color.FromArgb(56, 89, 120);
            btnAC.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 89, 120);
            btnCredito.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 89, 120);
            btnDocente.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 89, 120);
            bntAlumno.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 89, 120);
            btnAC.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 89, 120);
            btnCredito.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 89, 120);
            btnDocente.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 89, 120);
            bntAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 89, 120);
        }
        // Botones principales
        private void bntAlumno_Click(object sender, EventArgs e)
        {
            Todos();
            // Coordedanas para ver los partes del panel
            PanelPrincipal.Location = new Point(0, 76);
            bntAlumno.BackColor = Color.LimeGreen;
            bntAlumno.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            bntAlumno.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
        }
        private void btnDocente_Click(object sender, EventArgs e)
        {
            Todos();
            // Coordedanas para ver los partes del panel
            PanelPrincipal.Location = new Point(-880, 76);
            btnDocente.BackColor = Color.LimeGreen;
            btnDocente.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnDocente.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
        }
        private void btnCredito_Click(object sender, EventArgs e)
        {
            Todos();
            // Coordedanas para ver los partes del panel
            PanelPrincipal.Location = new Point(-1760, 76);
            btnCredito.BackColor = Color.LimeGreen;
            btnCredito.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnCredito.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            Todos();
            // Coordedanas para ver los partes del panel
            PanelPrincipal.Location = new Point(-2640, 76);
            btnAC.BackColor = Color.LimeGreen;
            btnAC.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnAC.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
        }
        //seccion alumno
        //limpia los textbox
        private void button7_Click(object sender, EventArgs e)
        {
            txtanum.Clear();
            txtamodnum.Clear();
            txtamodnom.Clear();
            txtamodapepat.Clear();
            txtamodapemat.Clear();
        }
        //buscar el alumno
        private void button8_Click(object sender, EventArgs e)
        {

        }
        //actualiza el alumno
        private void actualizar_alumno_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
