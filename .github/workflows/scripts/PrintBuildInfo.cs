#:package Humanizer@2.14.1

using Humanizer;
using System.Diagnostics;

long scriptStartTime = Stopwatch.GetTimestamp();

PrintPipelineVar("github.run.number");
PrintPipelineVar("github.repository");
PrintPipelineVar("github.ref");

string scriptExecutionTime = Stopwatch.GetElapsedTime(scriptStartTime).Humanize();
Console.WriteLine($"::debug::Script execution time: {scriptExecutionTime}");

static void PrintPipelineVar(string varName)
{
    string? varValue = Environment.GetEnvironmentVariable(varName.Replace('.', '_').ToUpperInvariant());
    Console.WriteLine($"{varName}: {varValue}");
}
