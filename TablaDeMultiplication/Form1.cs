using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaDeMultiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void  Table()
        {
            int Num;
            int i = 0;
            int Mult;
            Num = int.Parse(txtingresenum.Text);

            lbTabla.Items.Clear();

            while (i<=20)
            {
                Mult = Num * i;

                lbTabla.Items.Add(Num + "x" + i + "=" + Mult);

                i = i + 1;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imprimirbut_Click(object sender, EventArgs e)
        {

            Table(); 
        }
    }
}
