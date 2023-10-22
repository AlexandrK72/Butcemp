// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// m=3
// 0 1 2 3 4 5 6 7 8 9
 
//  4 6 1 4 7 9 2 4 6 1

using System.Diagnostics;

int[] array = 500_000.Create()
                .Fill(1, 10);
// array.ConvertToString();


int m = 100_000;

Stopwatch sw = new Stopwatch();
sw.Start();
int max = array.GetSum(m);
sw.Stop();
Console.WriteLine($"Summ: {max} => {sw.ElapsedMilliseconds}");


sw.Reset();
sw.Start(); 
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodSumm: {max} => {sw.ElapsedMilliseconds}");
// Console.WriteLine(array.ConvertToString());