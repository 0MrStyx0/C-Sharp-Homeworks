using DisposeAndDestructor;
using DisposeAndDestructor.ClassPlay;

Console.WriteLine("Task 1");
TestDestructor();
GC.Collect();
Console.Read();

void TestDestructor()
{
    Play play1 = new Play("Lebed", "Pushkin", "Tragedia", 1800);
    Play play2 = new Play();
}

Console.WriteLine("Task 2");

Shop shop1 = new Shop();
Shop shop2 = new Shop();
Shop shop3 = new Shop();
Shop shop4 = new Shop();

using (shop1) { }
using (shop2) { }
using (shop3) { }
using (shop4) { }

Console.WriteLine("Task 3");
Console.WriteLine("Такие же дествия надо совершить поэтому пропустил задание");