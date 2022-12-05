using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drobi
{
    public class FixWrongResult
    {
        public string FixWrongResultt(string stroka)
        {
            string[] subs = stroka.Split('/');
            string str = "";
            //if (subs{[0], subs[1] != )
            //{

            //}
            if (stroka == "")
            {
                    throw new Exception("Error!");
            }
                else
                {
                    if (Convert.ToDouble(subs[0]) > Convert.ToDouble(subs[1]))
                    {
                        subs[0] = subs[1];
                    }
                    str = String.Join("/", subs);
                }
            return str;
        }
    }
}
