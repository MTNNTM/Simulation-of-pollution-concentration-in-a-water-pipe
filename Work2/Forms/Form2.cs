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

namespace Work2.Forms
{
    public partial class BuildPipe : Form
    {
        
        public BuildPipe()
        {
            InitializeComponent();
        }

        //Back to welcome form
        private void button4_Click(object sender, EventArgs e)
        {
            PipeSimulation back = new PipeSimulation();
            back.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //Clear text button
        private void button3_Click(object sender, EventArgs e)
        {
            speed.Text = "";
            radius.Text = "";
            length.Text = "";
            infection.Text = "";
        }

        //Default Pipe button
        private void button2_Click(object sender, EventArgs e)
        {
            Simulation simulation = new Simulation(100, 10, 1000, 400);
            simulation.Show();
            this.Visible = false;
        }

        //Build pipe button according to user's input
        private void button5_Click(object sender, EventArgs e)
        {
            int speed1, radius1, length1, infection1;

            // try/catch added to check whether the text the user input is not with any letters
            try
            {
                //if some or all of the text are blank
                if (speed.Text == "" || radius.Text == "" || length.Text == "" || infection.Text == "")
                    MessageBox.Show("You didn't enter all the data, please try again");

                else
                {
                    speed1 = Int32.Parse(speed.Text);
                    radius1 = Int32.Parse(radius.Text);
                    length1 = Int32.Parse(length.Text);
                    infection1 = Int32.Parse(infection.Text);

                    //All of those ifs are to check the boundaries of the texts
                    if ( !(speed1 >= 10 && speed1 <= 300))
                        MessageBox.Show("Water Speed must be between 10- 300 [m/s]");

                    else if( !(radius1 >= 10 && radius1 <= 30))
                        MessageBox.Show("Radius of the pipe must be between 10- 30 [m]");

                    else if ( !(length1 >= 500 && length1 <= 1000))
                        MessageBox.Show("Length of the pipe must be between 500- 1000 [m]");

                    else if ( !(infection1 >= 100 && infection1 <= 1000))
                        MessageBox.Show("Concentration of infection must be between 100 to 1000 [kg]");

                    //else all is good:
                    //- the inputs are not blanks 
                    //- all of them don't contain any letters(only natural numbers)
                    //- all of them are within the boundaries
                    else
                    {
                        //We open the simulation form to start the simulation
                        Simulation simulation = new Simulation(speed1, radius1, length1, infection1);
                        simulation.Show();
                        this.Visible = false;
                    }

                }
            }

            //if the data were not numericals or natural numbers,then we give an error message
            catch (FormatException)
            {
                MessageBox.Show("Error: All data must be numericals and natural numbers");
            }
        }

        private void BuildPipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
