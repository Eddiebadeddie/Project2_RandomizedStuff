﻿/**********************************************************************
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
        //Creates the instance of 
        aRNG rng = aRNG.Instance(0);

        #region Dice Data Initilizations
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


        //Initializes a single die with a seed of 0
        aDie d = new aDie();
        #endregion

        #region Coin Data Initializations
        int[] coinTossFrequency = new int[2];

        aCoin c = new aCoin();
        #endregion

        #region Deck and Hand Initializations
        //Creates a new shuffled deck of cards
        aDeckOfCards deck = new aDeckOfCards();
        //Creates an empty hand
        List<aCard> hand = new List<aCard>();
        //Default draw number for card collection
        int num_draw = 1;
        #endregion

        //Constructor, came with the project
        public Form1()
        {
            //Initializes the form
            InitializeComponent();

            //Ensures that all arrays have 0 in each cell
            Reset();

            //Hides the roll counter 
            Roll_Counter_Label.Visible = false;

            //Sets the Draw text box to the default number, 1
            DrawBox.Text = "" + num_draw;
        }

        /*-------------------------------------------------------------
            void Reset():
                Sets each of the cells for both the diceFrequency array
                and the sumFrequency array to 0. That way, the graph 
                will not add to itself if the user presses the Roll 
                button again.
         ------------------------------------------------------------*/
        private void Reset()
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

            //For loop that writes 0 to each cell in the product Frequency array
            for (int i = 0; i < productFrequency.Length; ++i)
            {
                productFrequency[i] = 0;
            }

            coinTossFrequency[0] = 0;
            coinTossFrequency[1] = 0;

            /*Clears out the data in all three graphs
             *  +Series is the data
             *      +"Number Rolled" is the data for Die displays 1
             *        and 2
             *      +"Total Rolled" is the data for the Sum display
             */
            Die_1_Display.Series["Number Rolled"].Points.Clear();
            Die_2_Display.Series["Number Rolled"].Points.Clear();
            Die_Sum_Display.Series["Total Rolled"].Points.Clear();
            Die_Product_Display.Series["Product Rolled"].Points.Clear();

            Coin_Toss_Display.Series["Toss Frequency"].Points.Clear();


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
            Reset();

            
            //For each iteration, generate a random number and sum them
            for(int i =  0; i < iterations; ++i)
            {
                //Region for code organization relating to the dice
                #region Dice Data Collection and Display
                //roll_1 holds the value of the first number rolled
                int roll_1 = d;
                //roll_2 holds the value of the second number rolled
                int roll_2 = d;
                //Sum holds the total of roll_1 and roll_2
                int sum = roll_1 + roll_2;
                //Product holds the product of roll_1 and roll_2
                int product = roll_1 * roll_2;

                //Visually keeps track of the rolls
                Roll_Counter_Label.Text = "Rolls:  "+ i + "/" + iterations;
                //Updates the numbers on the label
                this.Update();

                //Updates the frequencies of the rolls by accessing the proper arrays
                diceFrequency[roll_1 - 1, 0] += 1;
                diceFrequency[roll_2 - 1, 1] += 1;
                sumFrequency[sum-2] += 1;
                productFrequency[product] += 1;

                //Updates the values in the graphs
                Die_1_Display.Series["Number Rolled"].Points.AddXY(roll_1, diceFrequency[roll_1 - 1, 0]);
                Die_2_Display.Series["Number Rolled"].Points.AddXY(roll_2, diceFrequency[roll_2 - 1, 1]);
                Die_Sum_Display.Series["Total Rolled"].Points.AddXY(sum, sumFrequency[sum-2]);
                Die_Product_Display.Series["Product Rolled"].Points.AddXY(product, productFrequency[product]);

                //Forces the graphs to draw in the new data
                Die_1_Display.Refresh();
                Die_2_Display.Refresh();
                Die_Sum_Display.Refresh();
                Die_Product_Display.Refresh();
                #endregion

                //Region for code organization relating to the coin
                #region Coin Data Collection and Display
                int toss = c;
                coinTossFrequency[toss] += 1;

                Coin_Toss_Display.Series["Toss Frequency"].Points.AddXY(toss, coinTossFrequency[toss]);

                Coin_Toss_Display.Refresh();
                #endregion
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

        /*-------------------------------------------------------------
            void DrawBox_TextChanged(object, EventArgs):
                Determines if the deck can draw any cards based
                on the user's input
         ------------------------------------------------------------*/
        private void DrawBox_TextChanged(object sender, EventArgs e)
        {
            //Tries to parse an integer out of the text
            if(!Int32.TryParse(DrawBox.Text, out int draw))
            {
                //If there is no int, display the error message
                Error_Message_Label.Text = "ERROR: Draw must be an integer";
                Error_Message_Label.Visible = true;

                //Disable the draw button
                Draw_Button.Enabled = false;
                return;
            }

            //If draw is a negative number or zero
            if (draw <= 0)
            {
                //Display an error message
                Error_Message_Label.Text = "ERROR: Draw must be positive";
                Error_Message_Label.Visible = true;

                //Disable the draw button
                Draw_Button.Enabled = false;
                return;
            }
            //If the draw number is more than the number of cards
            else if (draw > deck.Count)
            {
                //Display the error message
                Error_Message_Label.Text = "ERROR: Attempting to draw too many cards";
                Error_Message_Label.Visible = true;

                //Disable the draw button
                Draw_Button.Enabled = false;
                return;
            }

            //Set the number to draw to the number parsed
            num_draw = draw;
            //Get rid of the error messages, if there are any
            Error_Message_Label.Visible = false;
            //Enable the draw button
            Draw_Button.Enabled = true;
        }

        /*-------------------------------------------------------------
            void Draw_Button_Click(object, EventArgs):
                Draws a number of cards specified by user input and
                displays the cards in the Hand_Display
         ------------------------------------------------------------*/
        private void Draw_Button_Click(object sender, EventArgs e)
        {
            //If there are no cards in the hand
            if(hand.Count == 0)
            {
                //Add the cards drawn to the hand
                hand = deck.Draw(num_draw);
            }
            else
            {
                /*  Creates a temporary list of cards to append to
                    the hand if there are cards in the hand         */
                List<aCard> cards_to_add = deck.Draw(num_draw);
                
                //Add the new cards at the end of the hand
                foreach(aCard card in cards_to_add)
                {
                    hand.Add(card);
                }
            }

            //Clears the Hand_Display text
            Hand_Display.Text = "";
            //Displays each card in the hand in the Hand_Display
            foreach(aCard card in hand)
            {
                Hand_Display.Text += card + "\n";
            }

            //Checks to see if the draw value is possible
            DrawBox_TextChanged(sender, e);
            //Updates the visual of the cards left in the deck
            Card_Counter_Label.Text = "Cards: " + deck.Count + " / 52";
        }

        /*-------------------------------------------------------------
            void Clear_Hand_Button_Click(object, EventArgs):
                Clears the hand and reshuffles the deck
         ------------------------------------------------------------*/
        private void Clear_Hand_Button_Click(object sender, EventArgs e)
        {
            //Empties the hand
            hand.Clear();
            //Reflects new hand in text box
            Hand_Display.Text = "";

            //Resets the deck and shuffles the new deck
            deck.ResetDeck();
            //Updates number of cards in the deck
            Card_Counter_Label.Text = "Cards: " + deck.Count + " / 52";
            //Checks to see if the draw value is possible
            DrawBox_TextChanged(sender, e);
        }
    }
}