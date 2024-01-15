var loggerType = typeof(OpenTelemetry.BaseProvider);
var assemblyName = loggerType.Assembly.GetName();
Console.WriteLine($"OpenTelemetry: {assemblyName}");
