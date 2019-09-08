using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class Inicio : Form
    {
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public Inicio()
        {
            InitializeComponent();
            panel2.Left = 0;
        }

        int plus = 2;

        void move(object sender, EventArgs e)
        {
            cont++;
            panel2.Left = panel2.Left + plus;

            if (panel2.Left > 283)
            {
                plus = -2;
            }
            if (panel2.Left < 0)
            {
                plus = 2;
            }
            if (cont == 50)
            {
                timer1.Stop();
                Hide();
                Form1 obj = new Form1();
                obj.ShowDialog();

                Close();
            }
        }
        int cont = 0;
        private void Inicio_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(move);
            timer1.Interval = 1;
            timer1.Start();
            
            
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
