Console.WriteLine("Task 1");

int[] arr = new int[100];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(0, 100);
    Console.Write(arr[i] + " ");
}

string path = "Primal.txt";
using (StreamWriter writer = new StreamWriter(path))
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (isPrime(arr[i]))
        {
            writer.Write(arr[i] + " ");
        }
    }
}
Console.WriteLine("\n\n\n");
using (StreamReader reader = new StreamReader(path))
{
    Console.Write("Primal Numbers: ");
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

bool isPrime(int num)
{
    int a = 2;
    if (num == 0) return false;
    else if (num == 1) return false;
    else if (num < 0) num *= -1;

    while (a != num)
    {
        if (num % a == 0) return false;
        a++;
    }

    return true;
}

Console.WriteLine("\n\nTask 2");
//string text = "Hello Step IT! Hello World! Hello my friend!";
//string pathText = "Text.txt";
//string pathBuffer = "Buffer.txt";

//FileStreamOptions option = new FileStreamOptions();

//using (StreamWriter writer = new StreamWriter(pathText, false, System.Text.Encoding.UTF8))
//{
//    writer.Write(text);
//}

//using (StreamWriter writer = new StreamWriter(pathBuffer, false, System.Text.Encoding.UTF8))
//{
//    string line = "";
//    for (int i = 0; i < text.Length; i++) 
//    {
//        if (text[i] == ' ' && (text[i - 1] == '.' || text[i - 1] == '!' || text[i - 1] == '?')) 
//        {
//            line = "";
//        }
//        else if(text[i] == ' ')
//        {
//            writer.WriteLine(line);
//            line = "";
//        }
//        else if (text[i] == '.' || text[i] == '!' || text[i] == '?') 
//        {
//            writer.WriteLine(line);
//            line = text[i].ToString();
//            writer.WriteLine(line);
//            line = "";
//        }
//        else
//        {
//            line += text[i];
//        }
//    }
//}

//using (StreamReader reader = new StreamReader(pathText, System.Text.Encoding.UTF8)) 
//{
//    string line;
//    while((line = reader.ReadLine()) != null)
//    {
//        Console.WriteLine(line);
//    }
//}

//Console.Write("Word --> ");
//string search = Console.ReadLine();
//Console.Write("Replace --> ");
//string replace = Console.ReadLine();

//using(StreamReader reader = new StreamReader(pathBuffer, System.Text.Encoding.UTF8))
//{
//    string line;
//    string newText = "";
//    while ((line = reader.ReadLine()) != null)
//    {
//        if (line == search)
//        {
//            newText += replace + ' ';
//        }
//        else
//        {
//            newText += line + ' ';
//        }
//    }
//    Console.WriteLine(newText);
//    using (StreamWriter writer = new StreamWriter(pathText, false, System.Text.Encoding.UTF8))
//    {
//        writer.Write(newText);
//    }
//}

Console.WriteLine("Task 4");

string NormText = "Jessy, we need to cook!";

string pathNormText = "NormText.txt";
string pathReversedText = "ReversedText.txt";
using (StreamWriter writer = new StreamWriter(pathNormText, false, System.Text.Encoding.UTF8)) 
{
    writer.WriteLine(NormText);
}

Console.WriteLine("Norm text: " + NormText);

using (StreamReader reader = new StreamReader(pathNormText, System.Text.Encoding.UTF8)) 
{
    string line;
    while((line = reader.ReadLine()) != null)
    {
        char[] reversedText = line.ToArray().Reverse().ToArray();
        string result = new string(reversedText);
        Console.WriteLine("Reversed: " + result);
        using (StreamWriter writer = new StreamWriter(pathReversedText, false, System.Text.Encoding.UTF8))
        {
            writer.WriteLine(result);
        }
    }
}

Console.WriteLine("Task 5");
int[] numbers = new int[100000];
Random random2 = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random2.Next(-99, 100000);
}
string pathNumbers = "100Thousands.txt";
using (StreamWriter writer = new StreamWriter(pathNumbers, false)) 
{
    for (int i = 0; i < numbers.Length; i++)
    {
        writer.WriteLine(numbers[i]);
    }
}

using (StreamReader reader = new StreamReader(pathNumbers, System.Text.Encoding.UTF8)) 
{
    string num;
    int positive = 0, negative = 0, twoNum = 0, fiveNum = 0;
    string pathPositive = "Positive.txt", pathNegative = "Negative.txt", pathTwoNum = "TwoNum.txt", pathFiveNum = "FiveNum.txt";
    File.Delete(pathPositive);
    File.Delete(pathNegative);
    File.Delete(pathTwoNum);
    File.Delete(pathFiveNum);
    while ((num = reader.ReadLine()) != null)
    {
        int ConNum = Convert.ToInt32(num);
        if (ConNum > 0)
        {
            positive++;
            using(StreamWriter writer = new StreamWriter(pathPositive, true))
            {
                writer.WriteLine(num);
            }
        }
        else if (ConNum < 0)
        {
            negative++;
            using (StreamWriter writer = new StreamWriter(pathNegative, true))
            {
                writer.WriteLine(num);
            }
        }

        if ((ConNum >= 10 && ConNum <= 99) || (ConNum <= -10 && ConNum >= -99)) 
        {
            twoNum++;
            using (StreamWriter writer = new StreamWriter(pathTwoNum, true))
            {
                writer.WriteLine(num);
            }
        }
        else if((ConNum >= 10000 && ConNum <= 99999) || (ConNum <= -10000 && ConNum >= -99999))
        {
            fiveNum++;
            using (StreamWriter writer = new StreamWriter(pathFiveNum, true))
            {
                writer.WriteLine(num);
            }
        }
    }
    Console.WriteLine("Positive count: " + positive);
    Console.WriteLine("Negative count: " + negative);
    Console.WriteLine("2 Numbers count: " + twoNum);
    Console.WriteLine("5 Numbers count: " + fiveNum);
}