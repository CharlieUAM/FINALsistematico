using ExamenFinal.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona person = new Persona();
        arreglo grades = new arreglo();
        operaciones cal = new operaciones();
        
        

        private void BtnaddNm_Click(object sender, EventArgs e)
        {
            if (tbnames.Text.Length > 0)
            {
                person.nombre = tbnames.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tblastnames.Text.Length > 0)
            {
                person.nombre = tblastnames.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            person.fecha = DTPborn.Value;
            int edad = DTPborn.Value.Year;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            person.ciudad = CBcity.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cal.calcedad(DTPborn.Value.Year);
            
        }
    }
}
