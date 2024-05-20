using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Address
{
    public class Province
    {
        string _Name;
        public string _Code;

        public enum Code {ON,QC,NS,NB,MB,BC,PE,SK,AB,NL}
        public static Code[] Codes = { Code.ON, Code.QC, Code.NS, Code.NB, Code.MB, Code.BC, Code.PE, Code.SK, Code.AB, Code.NL };
        public Province(string name)
        {

            Utility.StringUtility.ElegantCase(ref name);
            _Name = name;

            switch (_Name)
            {
                case "Ontario": 
                    _Code = Code.ON.ToString();
                    break;
                case "Quebec":
                    _Code = Code.QC.ToString();
                    break;
                case "Nova Scotia":
                    _Code = Code.NS.ToString();
                    break;
                case "New Brunswick":
                    _Code = Code.NB.ToString();
                    break;
                case "Manitoba":
                    _Code = Code.MB.ToString();
                    break;
                case "British Columbia":
                    _Code = Code.BC.ToString();
                    break;
                case "Prince Edward Island":
                    _Code = Code.PE.ToString();
                    break;
                case "Saskatchewan":
                    _Code = Code.SK.ToString();
                    break;
                case "Alberta":
                    _Code = Code.AB.ToString();
                    break;
                case "Newfoundland and Labrador":
                    _Code = Code.NL.ToString();
                    break;
                default:
                    _Name = "";
                    _Code = "";
                    break;
            }
        }
        override public string ToString()
        {
            return _Name;
        }
    }
}
