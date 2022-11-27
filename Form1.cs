using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfonsoLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("This message will only appear in Interface Branch", "Programmed by Daniel");
        }
        /* By Daniel Alfonso, IT Programmer Analyst Student, NBCC
         * Intro to Programming, October 5th, 2022
         *    _    _
         *    *    *
         *     ----
         * This program will receive and multiply 2 numbers and display the result,
         * It will also show an image and a short story in the information section.
         * There are different methods for the user to navigate and select events.
         * 
        /*/

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            //Display the picture in the Information box and hide story
            pictureBox1.Visible = true;
            lblStory.Hide();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Hide has been cliked", "See you");
            //Hide picture when botton Hide is clicked
            pictureBox1.Visible = false;
            //lblStory.Visible = false;
            lblStory.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear content in text boxes and output label
            txtNumber.Clear();
            txtMultiplier.Clear();
            
            //txtMultiplier.Text = "";
            lblAnswer.Text = "";
            btnCalculate.Focus();
            
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //Create some string variables for the story
            string paragraph1, paragraph2, paragraph3;
            paragraph1 = "Cycling is a great exercise, and Saint John provides beautiful trails and roads where you can go for a ride. \n\n";
            paragraph2 = "Depending on the weather you should use the right outfit to enjoy your ride and also wear protective gear. \n\n";
            paragraph3 = "Although traffic is really friendly and people respect rules, it is relevant to be aware of the rules at all times and ride safe!.\n\n";

            //Show some information about topic and hide picture
            lblStory.Text = "My topic is " + lblTitle.Text + ".\n\n" + paragraph1 + paragraph2 + paragraph3;
            lblStory.Visible = true;
            pictureBox1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Display some information about the picture
            lblTitle.Text = lblTitle.Text + " Thanks";
            MessageBox.Show("Make sure you enjoy the beautiful tracks in Saint John in your bicycle!", "Daniel");

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Read numbers from text boxes, convert the string to int and assign to variable
            int operand1 = Convert.ToInt32(txtNumber.Text);
            int operand2 = Convert.ToInt32(txtMultiplier.Text);
            //declare variable answer and do the math
            int answerM = operand1 * operand2;
            //display the answer - conversion required 
            lblAnswer.Text = answerM.ToString();
            lblAnswer.Visible = true;
        }

    }
}
