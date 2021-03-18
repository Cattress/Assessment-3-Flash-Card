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

namespace Assessment_3_Flash_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        
        private void browseButton_Click(object sender, EventArgs e)
        { 
            
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            MessageBox.Show(FileName);
            StreamReader FileReader = new StreamReader(FileName);
        }

        private void flipCardButton_Click(object sender, EventArgs e)
        {
          //  if (Deck[])
        }

        Deck[] decks;
        decks = new Deck[2]; // change this later to num of stuff

        private void importButton_Click(object sender, EventArgs e, string FileName, string FileReader)
        {
            int count = 0;
            
            while (( FileName= FileReader.Read()) != null)
            {
               // string[] cells = FileName.Split(",");
                string title = cells[0];
                string definition = cells[1];
                

                decks[count] = new Deck( title, definition);

                count++;

                Console.WriteLine("{0} {1} {2} {3}", title, definition);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cardLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
