using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAssign1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Assign1Service : IAssign1Service
    {
        public string IsPrimeNumber(int number)
        {
            Boolean isPrime = true;
            string result = "prime number";

            for (int i = 2; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            if (!isPrime)
            {
                result = "not " + result;
            }
            return (result);
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public int SumOfDigits(string number)
        {
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                result += int.Parse(number.Substring(i, 1));
            }
            return (result);
        }

        public string ReverseString(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                result += text.Substring(text.Length - 1 - i, 1);
            }
            return (result);
        }

        public string PrintHTMLTags(string tag, string data)
        {
            string result = "";

            result = string.Format("<{0}>{1}</{0}>", tag, data);

            return (result);
        }

        public string Sort5Numbers(bool sortAscending, string data)
        {
            string result = "";
            string[] tempData;
            StringToDoubleComparer toDoubleComparer = new StringToDoubleComparer();
            tempData = data.Split(',');
            Array.Sort(tempData, comparer: toDoubleComparer);
            if (!sortAscending)
            {
                Array.Reverse(tempData);
            }
            for (int i = 0; i < tempData.Length; i++)
            {
                result += tempData[i];
                if (i < tempData.Length-1)
                {
                    result += ",";
                }
            }
            return (result);
        }

        public class StringToDoubleComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return double.Parse((string)x).CompareTo(double.Parse((string)y));
            }
        }
    }
}
