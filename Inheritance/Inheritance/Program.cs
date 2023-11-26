namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parent parent = new Parent();
            //Child child = new Child(5);
            //Child child1 = new Child(" XYZ");

            Parent parent = new Parent();
            Child child = new Child();

            parent.MethodA();
            child.MethodA();

            Parent parent1 = new Child();
            
            parent1.MethodB();
            
            

        }
    }
}
