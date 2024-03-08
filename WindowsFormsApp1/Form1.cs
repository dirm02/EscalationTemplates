using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    
public partial class Escalation : Form
    {

    SavedItems rg = new SavedItems();
        public Escalation()
        {
            InitializeComponent();
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // ResultWriter.WriteToFile("myResults.txt", results);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Q1_Click(object sender, EventArgs e)
        {

        }

        private void ERASE_Click(object sender, EventArgs e)
        {
            {
              //  public void empty()

}
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Escalation_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Power failure");
            comboBox1.Items.Add("Pay @ pump is down");
            comboBox1.Items.Add("Pumps are down - This includes Regular, Midgrade, Premium or Diesel. Not limited to all grades. Just one grade down is considered a P1 as well. ");
            comboBox1.Items.Add("50% or more of pumps down – This includes Regular, Midgrade, Premium or Diesel. Not limited to all grades.   Just one grade down is considered a P1 as well.");
            comboBox1.Items.Add("Network is down");
            comboBox1.Items.Add("Main Pay-point is down");
            comboBox1.Items.Add("Receipt printer is down – 1 PayPoint site");
            comboBox1.Items.Add("Pin pad is down - 1 PayPoint site");
            comboBox1.Items.Add("Tax changes take effect on the day of the outage ");
            comboBox1.Items.Add("Car wash is down");
            comboBox1.Items.Add("All Transactions are processing slowly at Multiple Sites +5 ");
            comboBox1.Items.Add("Network down");
            comboBox1.Items.Add("Loyalty Down");
            comboBox1.Items.Add("No PriceBook received at Multiple Sites +5");
            comboBox1.Items.Add("Bit 9 on Master Paypoint ");
            comboBox1.Items.Add("Fleet Keypad is down - 1 paypoint site");

            YN.Items.Add("YES");
            YN.Items.Add("NO");

            P1st.Items.Add("Escalation");
            P1st.Items.Add("UPDATE");
            P1st.Items.Add("RESOLUTION");
        }

        private void YN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }


    public class ResultWriter
    {
        public static void WriteToFile(string fileName, string content)
        {
            // Create a path to the file (replace "results.txt" with your desired filename)
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            // Write the content to the file
            try
            {
                File.WriteAllText(filePath, content);
                Console.WriteLine($"Results saved to: {filePath}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error writing to file: {e.Message}");
            }
        }
    }

}
