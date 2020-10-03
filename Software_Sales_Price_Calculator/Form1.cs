/*
 * Author Name: Berzaf Teklu
 * Date 10/02/2020
 * 
 * Create an application that lets the user enter the number of packages purchased. 
 * The program should then display the amount of the discount and the total amount 
 * of the purchase after the discount. 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales_Price_Calculator
{
    public partial class Form1 : Form
    {
        // Constant fields
        const double packagePrice = 99.00;
        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numOfPackages;

                if(int.TryParse(txtNumOfPackages.Text, out numOfPackages) && numOfPackages >= 0)
                {
                    const double discountPercentageTwenty = 0.20;
                    const double discountPercentageThirty = 0.30;
                    const double discountPercentageForty = 0.40;
                    const double discountPercentageFifty = 0.50;

                    if (numOfPackages < 10)
                    {
                        double orignalTotalPrice = numOfPackages * packagePrice;
                        double discount = 0.0;
                        double totalPrice = orignalTotalPrice - discount;        // Calculate total price after discount.

                        // Display discount and total price.

                        txtDiscount.Text = discount.ToString("c");
                        txtTotalPrice.Text = totalPrice.ToString("c");


                    }
                    else if (numOfPackages >= 10 && numOfPackages <= 19)
                    {
                        double orignalTotalPrice = numOfPackages * packagePrice;
                        double discount = orignalTotalPrice * discountPercentageTwenty;
                        double totalPrice = orignalTotalPrice - discount;                  // Calculate total price after discount.

                        // Display discount and total price.
                        txtDiscount.Text = discount.ToString("c");
                        txtTotalPrice.Text = totalPrice.ToString("c");

                    }
                    else if (numOfPackages >= 20 && numOfPackages <= 49)
                    {
                        double orignalTotalPrice = numOfPackages * packagePrice;             // Calculate orignal price
                        double discount = orignalTotalPrice * discountPercentageThirty;
                        double totalPrice = orignalTotalPrice - discount;                    // Calculate total price after discount.

                        // Display discount and total price.
                        txtDiscount.Text = discount.ToString("c");
                        txtTotalPrice.Text = totalPrice.ToString("c");
                    }
                    else if (numOfPackages >= 50 && numOfPackages <= 99)
                    {
                        double orignalTotalPrice = numOfPackages * packagePrice;
                        double discount = orignalTotalPrice * discountPercentageForty;
                        double totalPrice = orignalTotalPrice - discount;                    // Calculate total price after discount.

                        // Display discount and total price.
                        txtDiscount.Text = discount.ToString("c");
                        txtTotalPrice.Text = totalPrice.ToString("c");
                    }
                    else if (numOfPackages >= 100)
                    {
                        double orignalTotalPrice = numOfPackages * packagePrice;
                        double discount = orignalTotalPrice * discountPercentageFifty;       
                        double totalPrice = orignalTotalPrice - discount;                    // Calculate total price after discount.

                        // Display discount and total price.
                        txtDiscount.Text = discount.ToString("c");
                        txtTotalPrice.Text = totalPrice.ToString("c");
                    }


                }

            }
            catch (Exception ex)
            {
                // Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear all the input and output controls.
            txtNumOfPackages.Text = "";
            txtDiscount.Text = "";
            txtTotalPrice.Text = "";

            // Set focus to TextBox.
            txtNumOfPackages.Focus();


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
