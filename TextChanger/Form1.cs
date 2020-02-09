using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateState()
        {
            string fontName = "";
            Color backColor = Color.White;
            int fontSize = 0;
            FontStyle style = FontStyle.Regular;
            if (firstChoiceRb.Checked)
            {
                fontName = "Arial";
                backColor = Color.Blue;
                fontSize = 20;
            }
            else if (secondChoiceRb.Checked)
            {
                fontName = "Alex Brush";
                backColor = Color.Green;
                fontSize = 15;
            }
            else if (thirdChoiceRb.Checked)
            {
                fontName = "Algerian";
                backColor = Color.Red;
                fontSize = 10;
            }

            if (boldChB.Checked)
            {
                style |= FontStyle.Bold;

            }
            if (italicChB.Checked)
            {
                style |= FontStyle.Italic;
            }
            addTextTb.Font = new Font(fontName, fontSize,style);
            addTextTb.BackColor = backColor;
        }

        private void firstChoiceRb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateState();
            UpdateStyle();
        }

        private void secondChoiceRb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateState();
            UpdateStyle();
        }

        private void thirdChoiceRb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateState();
            UpdateStyle();
        }

        private void boldChB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateState();
            
        }

        private void italicChB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateState();
        }
        private void UpdateStyle()
        {
            if (firstChoiceRb.Checked || secondChoiceRb.Checked || thirdChoiceRb.Checked)
            {
                boldChB.Checked = false;
                italicChB.Checked = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
