﻿using System;
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
            if (!int.TryParse(subs[0], out int num))
            {
                throw new Exception("Error!");
            }
            if (!int.TryParse(subs[0], out  num))
            {
                throw new Exception("Error!");
            }
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
