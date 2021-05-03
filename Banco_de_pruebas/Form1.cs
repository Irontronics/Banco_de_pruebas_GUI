using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //include this library 

namespace Banco_de_pruebas
{
    public partial class Form_inicial : Form
    {
        public Form_inicial()
        {
            InitializeComponent();
            string[] puertos = SerialPort.GetPortNames(); //obtener puertos PC

            foreach (string mostrar in puertos) {
                comboBox1.Items.Add(mostrar);
            }

            

        }

        private void Form_inicial_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_init_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close(); // revisar que este cerrado el puerto
            serialPort1.Dispose();
            string puertoseleccionado = comboBox1.Text;
            serialPort1.Open();
            CheckForIllegalCrossThreadCalls = false;

            if (serialPort1.IsOpen) {
                //agregar etiqueta "Esta abierto"
                groupbx_modos.Enabled = true;
            }

        }
    }
}
