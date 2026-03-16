namespace LinqSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5};
           

            // sql syntax
            var Answer = from n in list
                     where n %2 == 0
                     select n;
            

            // method syntax
            var Answer2 = list.Where(n=> n %2 == 0); 



        }
    }
}
