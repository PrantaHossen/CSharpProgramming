using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerStudy
{
    internal class Generic <T>//,U>
    {
        internal T ay;
        internal T[] by=new T[5];
        static int count = 0;
        //internal U cx;

        internal T Ay
        { 
            get { return this.ay; }
            set { this.ay = value; }
        }

        internal T[] By
        {
            get { return this.by; }
            set { this.by = value; }
        }

        internal T M1()
        {
            return ay;
        }

        internal void Add(T a)
        {
            this.by[count] = a;
            count++;
        }

        internal bool Search(T r)
        {
            byte c =0;
            while(c<by.Length)
            {
                if (r.Equals(by[c]))
                {
                    Console.WriteLine("Found");
                    return true;
                }
                    c++;
            }
            return false;

        }
        internal void Remove(T r)
        {
            bool d = Search(r);

            if (d) 
            {

            }
        }
    }
}
