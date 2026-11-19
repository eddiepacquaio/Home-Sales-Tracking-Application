
using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        double Danielle = 0, Edward = 0, Fatima = 0;

       
        
 
        public Form1()
        {
            InitializeComponent();
            label1.Text = "HOME SALES TRACKING\nD - Danielle | E - Edward | F - Fatima";
            label2.Text = "Enter Salesperson Initial (D, E, F)  ";
            label3.Text = " Sales Amount";
        }

        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            switch (salesInitial.ToUpper())
            {
                case "D":
                    Danielle += salesAmount;
                    break;
                case "E":
                    Edward += salesAmount;
                    break;
                case "F":
                    Fatima += salesAmount;
                    break;
                default:
                    MessageBox.Show("Invalid Initial! Enter D, E, or F.");
                    return;
            }

            Lbl_Display.Text =
                "Sale Successfully Recorded!\n" +
                "Danielle: " + Danielle.ToString("N2") + "\n" +
                "Edward: " + Edward.ToString("N2") + "\n" +
                "Fatima: " + Fatima.ToString("N2") + "\n" +
                "Total Sales: " + (Danielle + Edward + Fatima).ToString("N2");
        }

        private void clearEntry()
        {
            Txt_SalesInitial.Clear();
            Txt_SalesAmount.Clear();
            Lbl_Display.Text = "";
            Txt_SalesInitial.Focus();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            double amount;

            if (double.TryParse(Txt_SalesAmount.Text, out amount) && amount > 0)
                getSalesPerson_Amount(Txt_SalesInitial.Text.Trim(), amount);
            else
                MessageBox.Show("Please enter a valid sales amount!");
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "HOME SALES SUMMARY\n\n" +
                "Danielle: " + Danielle.ToString("N2") + "\n" +
                "Edward: " + Edward.ToString("N2") + "\n" +
                "Fatima: " + Fatima.ToString("N2") + "\n\n" +
                "Total Sales: " + (Danielle + Edward + Fatima).ToString("N2"),
                "Sales Report");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
