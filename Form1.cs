/**********************************************************************
 *  Project 1   Author: Eduardo Nodarse
 *  -------------------------------------------------------------------
 *      -This project simulates 2 dice being thrown and visually 
 *      updates graphs to demonstrate the numbers rolled, and their 
 *      combined totals. The simulation uses a Random Number Generator
 *      (RNG) to simulate one die.
 *********************************************************************/ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project1
{
    public partial class Form1 : Form
    {
        /*
          Instantiates a 2D array that stores the frequencies of each
          rolled number for each die
        */
        int[,] diceFrequency = new int[6, 2];
        
        /*
            Stores the frequencies of the sums of the two dice 
            per roll
         */
        int[] sumFrequency = new int[11];

        /*
            Stores the frequencies of the products of the two dice per roll
         */
        int[] productFrequency = new int[37];

        //Iterations set to 100 by default
        int iterations = 100;

        aRNG rng = aRNG.Instance(0);

        //Initializes a single die with a seed of 0
        aDie d = aDie.Instance(0);

        //Constructor, came with the project
        public Form1()
        {
            //Initializes the form
            InitializeComponent();

            //Ensures that all arrays have 0 in each cell
            Reset_Counters();

            //Hides the roll counter 
            Roll_Counter_Label.Visible = false;
        }

        /*-------------------------------------------------------------
            void ResetCounters():
                Sets each of the cells for both the diceFrequency array
                and the sumFrequency array to 0. That way, the graph 
                will not add to itself if the user presses the Roll 
                button again.
         ------------------------------------------------------------*/
        private void Reset_Counters()
        {
            ///*Debug*/Console.Write("RESET_COUNTERS::");
            /*Nested for loop that writes 0 to each cell in the  array
             *  +diceFrequency.GetLength(0) returns the length of the
             *   1st dimension of the array (in this case, 6)
             *  +Likewise, diceFrequency.GetLength(1) returns the
             *   length of the 2nd dimension of the array (2)
             */
            for (int i = 0; i < diceFrequency.GetLength(0); ++i)
            {
                for (int j = 0; j < diceFrequency.GetLength(1); ++j)
                {
                    //Assignment of each array cell to 0
                    diceFrequency[i, j] = 0;
                }
            }

            //For loop that writes 0 to each cell in the sumFrequency array
            for(int i = 0; i < sumFrequency.Length; ++i)
            {
                //Assignemnt of each array cell to 0
                sumFrequency[i] = 0;
            }

            /*Clears out the data in all three graphs
             *  +Series is the data
             *      +"Number Rolled" is the data for Die displays 1
             *        and 2
             *      +"Total Rolled" is the data for the Sum display
             */
            Die_1_Display.Series["Number Rolled"].Points.Clear();
            Die_2_Display.Series["Number Rolled"].Points.Clear();
            Die_Sum_Display.Series["Total Rolled"].Points.Clear();

            ///*Debug*/Console.WriteLine("Arrays have been cleared");
        }

        /*-------------------------------------------------------------
            void RollButton_Clicked():
                Sets each of the cells for both the diceFrequency array
                and the sumFrequency array to 0. That way, the graph 
                will not add to itself if the user presses the Roll 
                button again.
         ------------------------------------------------------------*/
        private void Roll_Button_Click(object sender, EventArgs e)
        {
            ///*Debug*/Console.WriteLine("Roll Button Clicked");

            //Shows the roll counter with 0 rolls completed
            Roll_Counter_Label.Text = "Rolls:  0/" + iterations;
            Roll_Counter_Label.Visible = true;

            //Redraws the application to show the roll counter label
            this.Update();

            //Resets the counters to 0, and clears the graph of any data
            Reset_Counters();

            
            //For each iteration, generate a random number and sum them
            for(int i =  0; i < iterations; ++i)
            {
                //roll_1 holds the value of the first number rolled
                int roll_1 = d;
                //roll_2 holds the value of the second number rolled
                int roll_2 = d;
                //Sum holds the total of roll_1 and roll_2
                int sum = roll_1 + roll_2;

                //Visually keeps track of the rolls
                Roll_Counter_Label.Text = "Rolls:  "+ i + "/" + iterations;
                //Updates the numbers on the label
                this.Update();

                //Updates the frequencies of the rolls by accessing the proper arrays
                diceFrequency[roll_1 - 1, 0] += 1;
                diceFrequency[roll_2 - 1, 1] += 1;
                sumFrequency[sum-2] += 1;

                //Updates the values in the graphs
                Die_1_Display.Series["Number Rolled"].Points.AddXY(roll_1, diceFrequency[roll_1 - 1, 0]);
                Die_2_Display.Series["Number Rolled"].Points.AddXY(roll_2, diceFrequency[roll_2 - 1, 1]);
                Die_Sum_Display.Series["Total Rolled"].Points.AddXY(sum, sumFrequency[sum-2]);

                //Forces the graphs to draw in the new data
                Die_1_Display.Refresh();
                Die_2_Display.Refresh();
                Die_Sum_Display.Refresh();
            }

            //Hides the roll counter once the rolling is done
            Roll_Counter_Label.Text = "";
            Roll_Counter_Label.Visible = false;
        }

        /*-------------------------------------------------------------
            void Change_Die_Seed(object, EventArgs):
                Changes the RNG's seed in the instance of the die.
         ------------------------------------------------------------*/
        private void Change_Die_Seed(object sender, EventArgs e)
        {
            //Attempts to convert the string in the SeedTextBox to an int
            //  -If it succeeds, a new variable "seedValue" will hold the 
            //   value of the parsed string [Denoted by the "out" key word]
            if(!Int32.TryParse(SeedTextBox.Text, out int seedValue))
            {
                //If the Parsing fails, send out an error message
                Error_Message_Label.Text = "ERROR: Seed needs to be an integer";
                Error_Message_Label.Visible = true;

                //And disable the roll button
                Roll_Button.Enabled = false;
                return;
            }
            
            //If the error message is visible
            if (Error_Message_Label.Visible)
            {
                //Then make the error message invisible
                Error_Message_Label.Visible = false;
                Error_Message_Label.Text = "";
                //And enable the Roll button
                Roll_Button.Enabled = true;
            }
            
            //Get an RNG with a new seed value
            rng = aRNG.Instance(seedValue);
        }

        /*-------------------------------------------------------------
            void Change_Iteration_Number(object, EventArgs):
                Changes the number of rolls for the die
         ------------------------------------------------------------*/
        private void Change_Iteration_Number(object sender, EventArgs e)
        {
            //Attempts to convert the string in the IterationBox to an int
            if (!Int32.TryParse(IterationBox.Text, out iterations))
            {
                //If the parsing fails, show the error message
                Error_Message_Label.Text = "ERROR: Iterations needs to be an integer";
                Error_Message_Label.Visible = true;

                //Disable the roll button
                Roll_Button.Enabled = false;
                return;
            }

            //If the iterations <= 0
            if(iterations <= 0)
            {
                //Then display an error message
                Error_Message_Label.Text = "ERROR: Iterations need to be > 0";
                Error_Message_Label.Visible = true;

                //And disable the roll button
                Roll_Button.Enabled = false;
                return;
            }

            //If the Error Message is visible
            if (Error_Message_Label.Visible)
            {
                //Disable the error message
                Error_Message_Label.Visible = false;
                Error_Message_Label.Text = "";
                
                //Enable the button
                Roll_Button.Enabled = true;
            }
        }
    }
}