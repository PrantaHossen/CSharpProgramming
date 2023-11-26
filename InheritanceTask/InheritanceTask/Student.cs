namespace InheritanceTask
{
    internal class Student : Person
    {
        private double cgpa;

        internal double CGPA
        {
            get { return this.cgpa; }
            set
            {
                if (value >= 0 && value <= 4)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }

        }

        internal Student(string id, string name, int age, double cgpa) : base(id,name,age)
        {
            this.CGPA = cgpa;
        }

        internal override void Showinfo()
        {
            base.Showinfo();
            System.Console.WriteLine("Cgpa : {0}", this.CGPA);
        }
    }
}
