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

namespace Work2.Forms
{
    public partial class Simulation : Form
    {
        private int speed;// water speed
        private int radius;// radius of the pipe
        private int length;// length of the pipe
        private int infection;// concentration of infection
        private int x; //graphic tick
        private int tick; // graph tick

        //Initialize the values of the form
        public Simulation(int speed, int radius, int length, int infection)
        {
            InitializeComponent();
            this.speed = speed;
            this.radius = radius;
            this.length = length;
            this.infection = infection;
            
            //timer set to tick every 100 msec
            this.timer1.Enabled = true;
            this.timer1.Interval = 100;
            this.x = 0;
            this.tick = 0;           
        }

        //Load the given inputs of the previous form
        private void Simulation_Load(object sender, EventArgs e)
        {
            speedLabel.Text = "Water Speed: " + this.speed + " [m/s]";
            radiusLabel.Text = "Radius of the pipe: " + this.radius + " [m]";
            lengthLabel.Text = "Length of the pipe: " + this.length + " [m]";
            infectionLabel.Text = "Concentration: "   + this.infection + " [kg]";
        }

        //Back to Build pipe form
        private void back_Click(object sender, EventArgs e)
        {
            BuildPipe back = new BuildPipe();
            back.Show();
            this.Visible = false;
        }

        //Paint function to paint and redraw the pipe and the contaminant circle
        private void Simulation_Paint(object sender, PaintEventArgs e)
        {
            //Using graphics functions
            Graphics g = e.Graphics;

            //Create the the pipe
            Brush myBrush1 = new SolidBrush(Color.Azure);
            g.FillRectangle(myBrush1, 100, 600, this.length, radius*2);

            //Create the Contaminant circle
            Brush myBrush2 = new SolidBrush(Color.Red);
            g.FillEllipse(myBrush2, 100 + radius+ x, 600 , radius*2, radius*2);
        }
        
        //every 100 msec this function is called to redraw the circle at another place and show the graph
        private void timer1_Tick(object sender, EventArgs e)
        {
            //graph tick
            tick++;

            //if the circle didn't finish till the end of the pipe
            if (radius +x< length-2*radius)
            {
                //add to the moving circle x[m] (depending on the given water speed)
                x += speed/10;
                Invalidate();// redraw the pipe and circle

                if (tick % 10 == 0)//Refresh the graph every 10 ticks
                {
                    chart.Series["Concentration"].Points.Clear();// clear the previous graph to update
                    for(int i=0; i<10;i++)
                    {
                        int k= length/10*(i+1);//Position of the column on the graph
                        int j= x*10/length;// the number of the infection column

                        //if this is the infection column, then draw the infection on the graph
                        if(j==i)
                            this.chart.Series["Concentration"].Points.AddXY((double)k, (double)this.infection);

                        //else current column is 0. Meaning that we draw the infection every 10 ticks
                        else
                            this.chart.Series["Concentration"].Points.AddXY((double)k, 0.0);
                    }
                }

            }
            
            //else the circle finished moving to the end of the pipe so we move him away from the form
            else
            {
                x = 2000;
                Invalidate();

                //we set the timer off and the replay button to be enabled
                //to repeat the simulation with the same inputs if the user wants to
                this.timer1.Enabled = false;
                pause.Enabled = false;
            }
           
        }

        private void Simulation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        //replay the simulation button with the same inputs
        private void replay_Click(object sender, EventArgs e)
        {
            chart.Series["Concentration"].Points.Clear();
            this.x = 0;
            this.tick = 0;
            pause.Text = "Pause";
            pause.Enabled = true;
            this.timer1.Enabled = true;
        }

        //Pause the simulation button
        private void pause_Click(object sender, EventArgs e)
        {
            //if the simulation is running, then pause it
            if(this.timer1.Enabled==true)
            {
                this.timer1.Enabled = false;
                pause.Text = "Continue";
            }
            
            //else continue the simulation
            else
            {
                this.timer1.Enabled = true;
                pause.Text = "Pause";
            }
            
        }
    }
}
