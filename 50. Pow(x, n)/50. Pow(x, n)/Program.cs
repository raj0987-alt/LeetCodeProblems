using _50._Pow_x__n_;

Solution solution = new Solution();

double x;
int n;
Console.WriteLine("Enter Value of X: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Value of N: ");
n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"{x} raised to the power {n}: {solution.MyPow(x,n)}");