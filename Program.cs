namespace LinqSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5};
            IList<int> Answer = new List<int>();
            foreach (int i in list)
            {
                if(i %2 == 0)
                {
                    Answer.Add(i);
                }
            }

            var AnswerEnum = from n in Answer
                     where n %2 == 0
                     select n;
            Answer= AnswerEnum.ToList();



        }
    }
}
