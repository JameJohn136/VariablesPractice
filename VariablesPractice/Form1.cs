using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayLabel_Click(object sender, EventArgs e)
        {

        }

        private void wayneButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            displayLabel.Text = $"{playerName} is number {playerNumber}";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = pi * (radius * radius); 
            displayLabel.Text = $"The area of a circle with a radius of {radius} is {area}cm^2";
        }



        private void carpetButton_Click(object sender, EventArgs e)
        {
            //Create a double length variable that stores the values 8.5
            double length = 8.5f;

            //Create a double width variable that stores the value 6
            double width = 6;

            //Create a double costPerMeter variable that stores the value 19.95
            double costPerMeter = 19.95;

            //Create a double area variable that stores the calculated value for the area of the room
            double area = length * width;

            //Create a double totalCost variable that stores the value of the calculated total cost
            double totalCost = area * costPerMeter;

            //The area of a room with dimensions 8.5m x 6m is 51m ^ 2




            //The cost to carpet this area at 19.95 per square metre is $1017.45
            displayLabel.Text = $"The area of a room with the demensions {length}m x {width}m is {area} ^ 2";
            displayLabel.Text += $"\nThe cost to carpet this area at ${costPerMeter} per square metre is {totalCost}";
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            //A shirt was purchased for $12.49 and was paid with a $20 bill.

            //Calculate taxes, (HST = 13 %), total bill, and change.

            //Display the following output, using the values in the variables: 

            //Bill of Sale

            //Shirt:       12.49

            //Tax: 1.62

            //Total: 14.11

            //Tendered: 20.00

            //Change: 5.89

            double price = 12.49;
            double paid = 20;
            double taxRate = 0.13;
            double taxPrice = price * (1 + taxRate) - price;
            double totalPrice = price * (1 + taxRate);
            double change = paid - totalPrice;

            displayLabel.Text = $"Bill of Sale:\nShirt Price: {price}\nTax: {taxPrice}" +
                $"\nTotal: {totalPrice}\nTendered: {paid}\nChange: {change}";
        }
    }
}
