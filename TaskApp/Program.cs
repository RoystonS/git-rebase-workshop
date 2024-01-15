using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("DEBUG: starting app");

bool Matches(string task, string filter)
{
    return task.ToLower().Contains(filter.ToLower());
}

var tasks = new List<string>
{
    "Buy milk",
    "Write report",
    "Call Alice",
    "Fix bug"
};

var logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();

Console.WriteLine("Enter filter:");
var filter = Console.ReadLine();

var filtered = tasks.Where(t => t.Contains(filter)).ToList();

logger.Information("Generating tasklist");

Console.WriteLine("Tasks:");
foreach (var task in filtered)
{
    Console.WriteLine(task);
}
