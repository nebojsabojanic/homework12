using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework12_Nebojsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var buttonMoved = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /* For homework:
        For homework:
        Create a Windows Forms app
        Add needed button and textbox/label controls onto the window, and when the button is clicked, read the inputs and show the calculation results.
        It'd be good for everyone to have their task on a separate Git repository, to get used to that flow and work routine.
        *Forgot to mention!
        You need to calculate the area and perimeter (not sure if it's a proper word for this) of a circle - so there is just a slight adjustment needed when comparing to the today's example.*
         */

        private void btnCircleAreaPerimeter_Click(object sender, EventArgs e)
        {
            var radius = Convert.ToInt32(txtRadius.Text);
            var pi = 3.14;
            double area;
            double perimeter;

            area = radius * radius * pi;
            perimeter = 2 * radius * pi;

            lblPerimeter.Text = perimeter.ToString();
            lblArea.Text = area.ToString();
        }

        private void btnCircleAreaPerimeter_MouseEnter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRadius.Text) && btnCircleAreaPerimeter.Left == 160)
            {
                btnCircleAreaPerimeter.Left -= 100;
            } else if (String.IsNullOrEmpty(txtRadius.Text) && btnCircleAreaPerimeter.Left == 60)
            {
                btnCircleAreaPerimeter.Left += 100;
            }
        }



        /* Recommendation:
        If you have some time, try and design some kind of an user interface yourself, maybe copy someone's idea, maybe create it
        from your own idea, it's not important, just to get used to the toolbox and designer window  (together with properties window),
        and share screenshots (or code) with us via email. This is not required, but recommended as it will help you to get to know the Visual Studio and Windows Forms tools better. */

    }
}
