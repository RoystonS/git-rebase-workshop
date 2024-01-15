using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("DEBUG: starting app");

bool Matches(string task, string filter)
{
    return task.ToLower().Contains(filter.ToLower());
}

var taskList = new List<string>
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
var filter = Console.ReadLine() ?? "";

var filtered = taskList.Where(t => Matches(t, filter)).ToList();

logger.Information("Generating tasklist");

Console.WriteLine("taskList:");
int i=1; foreach (var task in filtered)
{
    Console.WriteLine($" { i++ }. { task }");
}

// TODO: exclude completed taskList


Console.WriteLine("DEBUG: filter=" + filter);
// small tweak

