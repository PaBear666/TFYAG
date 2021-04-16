using System;
using System.Drawing;
using System.Windows.Forms;

namespace TFYAG
{
    public partial class Form1 : Form
    {
        Controller Controller { get; set; }
        public Form1()
        {
            InitializeComponent();
            Controller = new Controller(mainTB, errorTB, outputTB, sendBUT, clearBUT);
        }

        private void MainTB_TextChanged(object sender, EventArgs e)
        {
            Controller.CheckCorrectInput(Color.Red);
        }

        private void errorTB_Click(object sender, EventArgs e)
        {
            Controller.ChangeCursorPosition();
        }

    }
}
