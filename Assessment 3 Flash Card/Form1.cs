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
            StreamReader FileReader = new StreamReader();
            string FileName =
        }

        private void flipCardButton_Click(object sender, EventArgs e)
        {
            if (Deck[])
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < DeckCount;  )
        }
    }
}
