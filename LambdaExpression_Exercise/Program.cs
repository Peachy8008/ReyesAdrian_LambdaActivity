namespace LambdaExpression_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Adrian", "Ana", "Jane", "Andrea", "Matthew", "Alan", "Ruby" };

            var filtered = names.Where(n => n.Contains("A"));

            foreach (var x in filtered) 
            {

                Console.WriteLine(x.ToString());
                
            }
        }
    }
}