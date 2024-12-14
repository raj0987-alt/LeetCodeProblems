using _202.HappyNummber;

Solution solution = new Solution();
int n;
Console.WriteLine("Enter The Number: ");
n= Convert.ToInt32(Console.ReadLine());

bool IsHappy = solution.IsHappy(n);

Console.WriteLine($"Happy number: {n}: {IsHappy}");