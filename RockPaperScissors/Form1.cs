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
    }
}
