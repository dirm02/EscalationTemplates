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


namespace WindowsFormsApp1
{
    
public partial class Form1 : Form
    {
        public Form1()
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
