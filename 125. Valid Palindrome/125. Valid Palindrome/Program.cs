using _125._Valid_Palindrome;

Solution solution = new Solution();
string s;
Console.WriteLine("Enter The String: ");
s = Console.ReadLine();
bool IsPalindrome = solution.IsPalindrome(s);
if (IsPalindrome)
{
    Console.WriteLine($"{s} Is a Valid Palindrome. The Case Is : {IsPalindrome}");
}
else
{
    Console.WriteLine($"{s} Is Not a Valid Palindrome. The Case Is : {IsPalindrome}");
}
