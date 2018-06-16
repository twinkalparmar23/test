using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "monday",
                "saturday",
                "friday",
                "friday"

            };


            //Console.WriteLine("count :" + days.Length);

            ICollection<string> collection = (ICollection<string>)days;

            //Console.WriteLine("count():" + collection.Count());


            //var cmp = new lengthcompare();
            //Array.Sort(days, cmp);


            if (!collection.IsReadOnly)
                collection.Add("wednesday");
            else
                Console.WriteLine("collection is read only..");

            days[3] = "sunday";
            (collection as String[])[3] = "tuesday";

            foreach (string i in days)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine(Array.IndexOf(days, "friday"));
        }
    }
    //class lengthcompare : IComparer<String>
    //{
    //    public int Compare(string x, string y)
    //    {
    //        return x.Length.CompareTo(y.Length);
    //    }
    //}

}
