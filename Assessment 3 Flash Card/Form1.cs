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
        private const string V = ",";
        

        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void browseButton_Click(object sender, EventArgs e)
        { 
            
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            string FileName = fileName;
            // testing if it gets the correct filename ::        MessageBox.Show(FileName);
            StreamReader FileReader = new StreamReader(FileName);
        }

        private void flipCardButton_Click(object sender, EventArgs e)
        {
            //CardsArray.flip
           
        }
   

        private void importButton_Click(object sender, EventArgs e, string FileName, string FileReader)
        {
            int count = 0;
        /*    

            while (FileName = FileReader.Read ()) //getting the information in the file
            {
                string[] cells = FileName.Split(","); //organising the data
                string title = cells[0];
                string definition = cells[1];
                
                Card[count] = new Card(FileName);

                count++;

                Console.WriteLine("{0} {1} {2} {3}", title, definition);
            }
       */     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void shuffleButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
        }

        private void previousButton_Click(object sender, EventArgs e)
        {

        }
    }
}
