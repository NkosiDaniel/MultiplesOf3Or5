public class Multiples
{
    private static int sum;

    static void Main(string[] args)
    {
        
        int num = 0;
        SumOfMultiples(num);
    }

    private static void SumOfMultiples (int num)
    {    //This is the base case of the recursive function. Due to its simplicity, it can be solved without a recursive call.
        if(num % 3 == 0 || num % 5 == 0)
        {
            sum += num;
        }
        if(num == 999)
        {
            Console.WriteLine(sum);
            return;
            //This will break the recursion
        }
        SumOfMultiples(num + 1);
        //This is the recursive case. This involves reducing the overall problem to a simpler one so it can be solved recursively.
        //In this case, we're adding 1 for every function call. Therefore, the problem gets simpler and simpler with each call
        //because we get closer to 999
    }
}

