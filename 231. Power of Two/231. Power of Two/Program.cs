using _231._Power_of_Two;

Solution solution = new Solution();
int n;
Console.WriteLine("Enter The Number: ");
n = Convert.ToInt32(Console.ReadLine());

bool IsPowerOfTwo = solution.IsPowerOfTwo(n);
if (IsPowerOfTwo)
{
    Console.WriteLine($"{n} Is a Power of Two. The Case Is : {IsPowerOfTwo}");
}
else
{
    Console.WriteLine($"{n} Is Not a Power of Two. The Case Is : {IsPowerOfTwo}");
}