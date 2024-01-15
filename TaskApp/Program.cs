using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("DEBUG: starting app");

var tasks = new List<string>
{
    "Buy milk",
    "Write report",
    "Call Alice",
    "Fix bug"
};

Console.WriteLine("Enter filter:");
var filter = Console.ReadLine();

var filtered = tasks.Where(t => t.Contains(filter)).ToList();

Console.WriteLine("Tasks:");
foreach (var task in filtered)
{
    Console.WriteLine(task);
}
