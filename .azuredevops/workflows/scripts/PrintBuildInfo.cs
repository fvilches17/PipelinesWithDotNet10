#:package Humanizer@2.14.1

using Humanizer;
using System.Diagnostics;

long scriptStartTime = Stopwatch.GetTimestamp();

PrintPipelineVar("Build.BuildNumber");
PrintPipelineVar("Build.Repository.Name");
PrintPipelineVar("Build.SourceBranch");

string scriptExecutionTime = Stopwatch.GetElapsedTime(scriptStartTime).Humanize();
Console.WriteLine($"##[debug] Script execution time: {scriptExecutionTime}");

static void PrintPipelineVar(string varName)
{
    string? varValue = Environment.GetEnvironmentVariable(varName.Replace('.', '_').ToUpperInvariant());
    Console.WriteLine($"{varName}: {varValue}");
}
