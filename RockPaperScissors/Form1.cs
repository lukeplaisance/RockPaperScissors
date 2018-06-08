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
//What is VS?:
//Visual studios is a IDE that is used to debug, edit code, and build applications for the microsoft windows platform.

//What is Windows Form Applications?
//    A winform is a GUI application that is only for Windows.

//Data Types:
//	-String : a word that contains characters.Used with “”
//	-Int : integer/whole number
//	-float : decimal value
//	-bool : true or false
//	-char : single letter on the keyboard.Used with ‘’

//Operators:
//	+(addition) add
//	+=(plus equals) the value to the right is added to the value to the left
//	-(subtraction) subtract
//	-=(minus equals) value to the right is subtracted to the value to the left
//	= (is assigned) assignment operator
//    ==(is equal to)
//	||(or)
//	&&(and)

//Methods:
//	Methods are a block of code that does a specific.You can call it over and over so you don't have to retype the code again

//Classes
//    Classes lets you group custom variable types and methods together and can define the functionality the object will have

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string UserChoice;
        string OpponentChoice;

        private void RockChoice_Click(object sender, EventArgs e)
        {
            UserChoice = RockChoice.Text;
            OpponentSelection();
        }

        private void PaperChoice_Click(object sender, EventArgs e)
        {
            UserChoice = PaperChoice.Text;
            OpponentSelection();
        }

        private void ScissorsChoice_Click(object sender, EventArgs e)
        {
            UserChoice = ScissorsChoice.Text;
            OpponentSelection();
        }

        void OpponentSelection()
        {
            Computer.Text = "Opponent Choice";
            Random r = new Random();
            int choice = r.Next(1, 3);
            if(choice == 1)
            {
                OpponentChoice = "Rock";
            }
            if(choice == 2)
            {
                OpponentChoice = "Paper";
            }
            if(choice == 3)
            {
                OpponentChoice = "Scissors";
            }
            Computer.Text += "\n" + OpponentChoice;
            VicotoryCheck();
        }

        void VicotoryCheck()
        {
            string VictoryOne = "Rock>Scissors";
            string VictoryTwo = "Paper>Rock";
            string VictoryThree = "Scissors>Paper";

            string check = UserChoice + ">" + OpponentChoice;

            if(check == VictoryOne || check == VictoryTwo || check == VictoryThree )
            {
                CombatLog.Text += "Victory: " + UserChoice + " beats " + OpponentChoice + "\n";
            }
            else if (UserChoice == OpponentChoice)
            {
                CombatLog.Text += "Draw: " + UserChoice + " Same as " + OpponentChoice + "\n";
            }
            else
                CombatLog.Text += "Defeat: " + UserChoice + " lost to " + OpponentChoice + "\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
