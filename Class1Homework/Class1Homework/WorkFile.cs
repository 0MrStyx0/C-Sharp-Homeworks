using Class1Homework.Shop;
using Class1Homework.ArrayFilter;
using Class1Homework.Magazine;
using Class1Homework.Palindrome;
using Class1Homework.SquareMaker;
using Class1Homework.Website;

Console.WriteLine("Task 1");
Console.WriteLine("Full Square:");
SquareMaker.PrintFullSquare(10, '*');
Console.WriteLine("Hollow Square:");
SquareMaker.PrintHollowSquare(10, '*');

Console.WriteLine("\nTask 2");
Console.WriteLine(Palindrome.IsPalindrome(7854));
Console.WriteLine(Palindrome.IsPalindrome(1221));

Console.WriteLine("\nTask 3");
int[] originalArr = { 1, 2, 6, -1, 88, 7, 6 };
int[] filterArr = { 6, 88, 7 };
ArrayFilter.FiltrateArray(originalArr, filterArr);

Console.WriteLine("\n\nTask 4");
Website website1 = new Website("War thunder", "https:/warthunder.ru","Game website", " 104.20.83.98");
website1.ShowInfo();

Console.WriteLine("\n\nTask 5");
Magazine magazine1 = new Magazine("Hugo Boss","1998","Parfume","+123354345","hugoboss@gmail.com");
magazine1.ShowInfo();

Console.WriteLine("\n\nTask 6");
Shop shop1 = new Shop("Amazon", "410 Terry Ave N, Seattle 98109, WA.", "Online shop", "+1 (206) 922-0880", "primary@amazon.com");
shop1.ShowInfo();