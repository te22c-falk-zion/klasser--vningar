

using System.Threading.Tasks.Dataflow;

book b1 = new book("a", 5 );
book b2 = new book("b", 10);
book b3 = new book("c", 15);


Console.WriteLine($"{b3.GetName()} and {b3.GetCurrentPage()}");
b3.turnpage();
Console.WriteLine($"{b3.GetPages()} then {b3.GetCurrentPage()}");
Console.ReadLine();
