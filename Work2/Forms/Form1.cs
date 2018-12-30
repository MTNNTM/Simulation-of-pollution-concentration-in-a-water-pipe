// Tomer Steiner- 204480495 
// Ram Maian- 055435028
// Matan Jacobi- 204273452
// Idan Bukobza- 301875514

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work2.Forms;


namespace Work2
{
    public partial class PipeSimulation : Form
    {
        public PipeSimulation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Button to go to pipe building form
        private void button1_Click(object sender, EventArgs e)
        {
            BuildPipe back2 = new BuildPipe();
            back2.Show();
            this.Visible = false;
        }


        private void PipeSimulation_Load(object sender, EventArgs e)
        {

        }
    }
}
