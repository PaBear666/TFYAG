using System;
using System.Collections.Generic;
using System.Text;

namespace TFYAG
{
    static class ResultBack
    {
        static public string X(int k)
        {
            string str = "";
            for (int i = 0; i < k; i++)
            {
                str += "_"+" ";
            }
            return str;
        }
        static public string A(int k)
        {
            string str = "";
            for (int i = 0; i < k; i++)
            {
                str += "A";
            }
            return str;
        }
        static public string Skip(int k = 1)
        {
            string str = "";
            for (int i = 0; i < k; i++)
            {
                str += "#SKIP/";
            }
            return str;
        }

        static public string E(int k,int k1)
        {
            string str = "";
            for (int i = 0; i < k-k1 - 1; i++)
            {
                if (i.Equals(0))
                {
                    str += "З";
                }
                else
                {
                    str += "Ц";
                }
            }
            for (int i = 0; i <= k1; i++)
            {
                if (i.Equals(0))
                {
                    str += "E";
                }
                else if(i.Equals(1))
                {
                    str += "З";
                }
                else
                {
                    str += "У";
                }
            }
            return str;
        }

        static public string F(int k)
        {
            string str = "";
            for (int i = 0; i < k; i++)
            {
                if (i.Equals(0))
                {
                    str += "З";
                }
                else
                {
                    str += "Ц";
                }
                    
            }
            return str;
        }

        static public string F(int k, int k1)
        {
            string str = "";
            for (int i = 0; i < Math.Abs(k-k1 - 1); i++)
            {
                if (i.Equals(0))
                {
                    str += "З";
                }
                else
                {
                    str += "Ц";
                }
            }
            str += ".";
            for (int i = 0; i < k1; i++)
            {
                    str += "Ц";
            }
            return str;
        }
        

    }
}
