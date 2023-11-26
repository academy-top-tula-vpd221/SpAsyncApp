var task1 = PrintString("Hello world");
var task2 = PrintString("Hello people");
var task3 = PrintString("Hello all");
Func<string, Task> func = async (text) =>
{
    await Task.Delay(1000);
    Console.WriteLine(text);
};

var task4 = func("$$$$$$$$");

await task1;
await task2;
await task3;
await task4;

async Task PrintString(string text)
{
    await Task.Delay(3000);
    Console.WriteLine(text);
}




//Loop(30);
//Task task = LoopAsync();
//Loop(40);
//await task;
//Loop(10);

////await PrintAsync();

////Console.WriteLine("Main After async");

//////for(int i = 0; i < 40; i++)
//////{
//////    Thread.Sleep(100);
//////    Console.WriteLine($"Main thread {i}");
//////}

//void Loop(int timeDelay = 100)
//{
//    for(int i = 0; i < 50; i++)
//    {
//        Console.WriteLine($"Delay {timeDelay}");
//        Thread.Sleep(timeDelay);
//    }
//}

//void Loop100()
//{
//    for (int i = 0; i < 50; i++)
//    {
//        Console.WriteLine($"Delay {100}");
//        Thread.Sleep(100);
//    }
//}

//async Task LoopAsync()
//{
//    Console.WriteLine("Begin Print Async");
//    //await Task.Run(Loop100);
//    await Task.Delay(10000);
//    Console.WriteLine("End Print Async");
//}


//void Print()
//{
//    Thread.Sleep(3000);
//    Console.WriteLine("Hello world");
//}

//async Task PrintAsync()
//{
//    Console.WriteLine("Begin Print Async");
//    await Task.Run(Print);
//    Console.WriteLine("End Print Async");
//}





///*
//using System.Runtime.CompilerServices;

//await 1;



//public static class IntExtensions
//{
//    public static IntAwaiter GetAwaiter(this int number) => new IntAwaiter();

//    public class IntAwaiter : INotifyCompletion
//    {
//        public bool IsCompleted => false;

//        public void OnCompleted(Action continuation) { }

//        public void GetResult() { }
//    }
//}
//*/

