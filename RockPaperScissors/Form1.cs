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

        /// <summary>
        /// Create two variables of type string
        /// These variables will be used to hold inforamtion about 
        /// the option the player choose to play against the computer
        /// and the same goes for the computer choice
        /// </summary>
        string UserChoice;
        string OpponentChoice;

        /// <summary>
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

        /// <summary>
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

        /// <summary>
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

        /// <summary>
        /// This function will generate us a choice for our computer player based on some 
        /// conditions we set for it. We will call this function in the ScissorsChoice_Click, PaperChoice_Click, and RockChoice_Click
        /// functions above. We call it in those function to make it appear as if the computer and user are selecting thier choose at the 
        /// same time just like in Rock Paper Scissors.
        /// </summary>
        void OpponentSelection()
        {
            /// <summary>
            /// To we will need to create some way to get the computer to generate
            /// a response to the players choice. There are a few ways we can do this
            /// but we will provide you with one using the Random class. This Random class
            /// will generate us a number between two digits.
            /// In this case we want a number between 1 and 3 including 1 and 3.
            /// </summary>
            Random r = new Random();
            int choice = r.Next(1, 3);

            ///<summary>
            /// Once we have our number generated we need to create a set of conditionals to
            /// figure out what the computers response would be. 
            /// 1 = rock
            /// 2 = paper
            /// 3 = scissors
            /// 
            /// Once the computers response has been generated we will call the Victory Check function.
            /// </summary>
        }


        /// <summary>
        /// This function is called from the OpponentSelection function above.
        /// In this function will check to see if the user beats the computer or if the computer beats the player
        /// </summary>
        void VicotoryCheck()
        {
            /// <summary>
            /// So now that we have all the set up for our player and computer to select the option they wish to play
            /// its time to see who wins. There are multiple ways we can do this using more complex data types like Lists or Arrays
            /// but to keep it simple we are just gonna make a few string varaibles one for each victory condition.
            /// we will need one to say Rock beats Scissors, Paper beats Rock, and Scissors beats Paper.
            /// </summary>

            /// <summary>
            /// Once we have our vicotory conditions defined we need to cocme up with some way to check.
            /// One way I like to do this since we are using strings for everything is we can make a new string and 
            /// format it like our vicotry check strings.
            /// </summary>

            ///<summary>
            /// Once we have our strings made one two represent the current choices in play to check against the victory conditions
            /// and one for each of the three victory types we need to make some more conditional statements using if, else if, and else checks.
            /// 
            /// We will use this conditianal statements to see if our string that contains the current play to all the victory type to see if the user or the computer has won.
            /// We will alson needs to see if there is a draw so if the user and the computer have selected the same choice.
            /// Then if we did not meet the vicotry conditions or draw conditions, the user has lost and the computer is the winner.
            /// </summary>
        }
    }
}
