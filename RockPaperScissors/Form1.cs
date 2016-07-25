using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary> 1)
        /// Create two variables of type string
        /// These variables will be used to hold inforamtion about 
        /// the option the player choose to play against the computer
        /// and the same goes for the computer choice
        /// </summary>

        /// <summary> 2)
        /// This function is all ready attached to our RockChoice button on our form that is provided.
        /// This will be executed once the RockChoice button has been clicked by the user of our application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RockChoice_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// This function will set the value of the variable we create above that we will be using to hold
            /// our data for the choice the player has made and we will set it equal to Rock.
            /// Once we have our data stored in that variable we will call the function OpponenentSelection.
            /// </summary>
        }

        /// <summary> 2)
        /// This function is all ready attached to our PaperChoice button on our form that is provided.
        /// This will be executed once the PaperChoice button has been clicked by the user of our application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaperChoice_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// This function will set the value of the variable we create above that we will be using to hold
            /// our data for the choice the player has made and we will set it equal to Paper.
            /// Once we have our data stored in that variable we will call the function OpponenentSelection.
            /// </summary>
        }

        /// <summary> 2)
        /// This function is all ready attached to our ScissorsChoice button on our form that is provided.
        /// This will be executed once the ScissorsChoice button has been clicked by the user of our application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScissorsChoice_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// This function will set the value of the variable we create above that we will be using to hold
            /// our data for the choice the player has made and we will set it equal to Scissors.
            /// Once we have our data stored in that variable we will call the function OpponenentSelection.
            /// </summary>
        }

        /// <summary> 3)
        /// This function will generate us a choice for our computer player based on some 
        /// conditions we set for it. We will call this function in the ScissorsChoice_Click, PaperChoice_Click, and RockChoice_Click
        /// functions above. We call it in those function to make it appear as if the computer and user are selecting thier choose at the 
        /// same time just like in Rock Paper Scissors.
        /// </summary>
        void OpponentSelection()
        {
            /// <summary>
            /// Now we will need to define a way to have the computer to generate
            /// a response against the players choice. There are a few ways we can do this
            /// but we will provide you with one using the Random class. This Random class
            /// will generate us a number between two digits.
            /// In this case we want a number between 1 and 4 including 1 but not 4.
            /// </summary>
            Random r = new Random();
            int choice = r.Next(1, 4);

            ///<summary>
            /// Once we have our number generated we need to create a set of conditionals to
            /// figure out what the computers response would be. 
            /// 1 = rock
            /// 2 = paper
            /// 3 = scissors
            /// </summary>
        }


        /// <summary> 4)
        /// This function can be called in a few different ways. If you want to limit the amount you have to type you can
        /// call it in one time from the OpponentSelection function above at the very end or we can call it at the end of our
        /// RockChoice, PaperChoice, and ScissorsChoice functions we made at the begging of the lesson. 
        /// </summary>
        void VictoryCheck()
        {
            /// <summary>
            /// So now that we have all our string variables and fucntions set up for our player and computer to select the option they wish to play
            /// its time to see who wins. There are multiple ways we can do this using more complex data types like Lists or Arrays
            /// but to keep it simple we will use make a few string varaibles one for each victory condition.
            /// We will need one for each of the victory types in our game Rock beats Scissors, Paper beats Rock, and Scissors beats Paper.
            /// </summary>

            /// <summary>
            /// Once we have our vicotory conditions defined we need to cocme up with some way to check.
            /// One way I like to do this since we are using strings for everything we can make a new string and 
            /// format it like our victory condition strings.
            /// </summary>

            ///<summary>
            /// Now that we have or strings created we need to make some more conditional statements using if, else if, and else checks to determine the outcome of the battle between the player and computer.
            /// 
            /// We will use these conditianal statements to compare our string that contains the current choices in play to all the victory conditions to see if the user or the computer has won.
            /// We will also need to see if there is a draw, so if the user and the computer have selected the same choice.
            /// Then if we did not meet any of the victory conditions or the draw condition, the user has lost and the computer is the winner.
            /// </summary>
        }
    }
}
