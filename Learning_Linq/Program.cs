using Learning_Linq;
using Learning_Linq.Questions;

public class Program
{
    public static void Main()
    {
        //WherePractice.WhereQuestion();
        //SelectPractice.SelectQues();
        //WhereSelect.WhSel();
        //SelectMany.SelectManyQ();
        //Sort.SortQ();
        //GroupBy.GrpBy();
        LinqPractice.LinqQ();
    }
}




// overall practice of linq-

//IEnumerable<int> numbers = new List<int>{1,20, 3, 6,9,2,7, 90};
//Console.WriteLine("numbers are : ");
//foreach(int num in numbers)
//{
//    Console.WriteLine(num);
//}
//var number = numbers.Where(n => n > 8);
//Console.WriteLine("Greater Than 8 : ");
//foreach(int numb in number)
//{
//    Console.WriteLine(numb);
//}

//Console.WriteLine("\n\n");
//IEnumerator<int> enumerator = numbers.GetEnumerator();
//while (enumerator.MoveNext())
//{
//    int n = enumerator.Current;
//    Console.WriteLine(n);
//}

