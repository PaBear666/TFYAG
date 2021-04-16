using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TFYAG
{
    class Controller
    {
        public RichTextBox InPutTB { get; set; }
        public TextBoxBase ErrorTB { get; set; }
        public TextBoxBase OutPutTB { get; set; }
        public Button SendBUT { get; set; }
        public Button ClearBUT { get; set; }


        public Controller(RichTextBox inPutTb, TextBoxBase errorTB, TextBoxBase outPutTB,Button sendBUT,Button clearBUT)
        {
            InPutTB = inPutTb;
            ErrorTB = errorTB;
            OutPutTB = outPutTB;
            SendBUT = sendBUT;
            ClearBUT = clearBUT;
        }

        public int CheckCorrectInput(Color? errColor = null)
        {
            Result result = Validataion.Check(InPutTB.Text);
            ErrorTB.Text = result.ErrMessage() + " " + "Позиция:" + result.ErrPosition;
            ChangeSymbolColor(errColor, result.ErrPosition);
            PrintResultString(result.ResultString);
            return result.ErrPosition;
        }

        public void ChangeCursorPosition()
        {
            int pos = CheckCorrectInput();
            InPutTB.Focus();
            InPutTB.SelectionStart = pos + 1;
            
        }

        private void ChangeSymbolColor(Color? errcolor,int pos)
        {
            Color oldColor = InPutTB.ForeColor;
            int beginSelectionStart = InPutTB.SelectionStart;
            InPutTB.SelectionStart = 0;
            InPutTB.SelectionLength = InPutTB.Text.Length;
            InPutTB.SelectionColor = oldColor;
            InPutTB.SelectionStart = beginSelectionStart;

            if (errcolor != null && pos != -1)
                {

                    InPutTB.SelectionStart = pos;
                    InPutTB.SelectionLength = 1;
                    InPutTB.SelectionColor = (Color)errcolor;
                    InPutTB.SelectionStart = beginSelectionStart;
                    InPutTB.SelectionLength = 0;

            }
                

        }

        private void PrintResultString(string str)
        {
            if (str.Equals(""))
            {
                OutPutTB.Text = "Пустая строка"; ;
            }
            else
            {
                OutPutTB.Text = "";
                foreach (var newstr in PrintIndentation(str))
                {
                    OutPutTB.Text += newstr;
                    OutPutTB.Text += Environment.NewLine;
                }
                
            }
        }

        private string[] PrintIndentation(string str)
        {
            var newstr = str.Split(new string[] { "#SKIP/" },StringSplitOptions.None);
            return newstr;
        }


    }

}
