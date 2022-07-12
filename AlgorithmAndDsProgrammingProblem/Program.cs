using AlgorithmAndDsProgrammingProblem;
BinarySearch Search = new BinarySearch();
Console.WriteLine("Hello, to the algorithm and data structure problems");
Console.WriteLine("Enter a sentence");
String s = Console.ReadLine();
Console.WriteLine("Enter the word you want to search");
String search = Console.ReadLine();
Search.sortAndCall(s,search);
