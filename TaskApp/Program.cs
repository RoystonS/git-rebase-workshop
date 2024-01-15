using System;
using System.Collections.Generic;
using System.Linq;

var tasks = new List<string>
{
    "Buy milk",
    "Write report",
    "Call Alice",
    "Fix bug"
};

Console.WriteLine("Tasks:");
foreach (var task in tasks)
{
    Console.WriteLine(task);
}
