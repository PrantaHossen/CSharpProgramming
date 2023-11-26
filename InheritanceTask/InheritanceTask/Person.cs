namespace InheritanceTask
{
    internal class Person
    {
        private string id;
        private string name;
        private int age;

        internal string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        internal Person() { }

        internal Person(string id, string name, int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }

        internal virtual void Showinfo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("ID: {0}", this.ID);
            System.Console.WriteLine("Name: {0}", this.Name);
            System.Console.WriteLine("Age: {0}", this.Age);

        }
    }
}
