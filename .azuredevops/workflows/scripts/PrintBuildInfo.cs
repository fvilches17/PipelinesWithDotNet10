#:package Humanizer@2.14.*

using Humanizer;
using System.Diagnostics;

long scriptStartTime = Stopwatch.GetTimestamp();

PrintPipelineVar("Build.BuildNumber");
PrintPipelineVar("Build.Repository.Name");
PrintPipelineVar("Build.SourceBranch");

string scriptExecutionTime = Stopwatch.GetElapsedTime(scriptStartTime).Humanize();

// Print additional debug info.
// https://learn.microsoft.com/en-us/azure/devops/pipelines/scripts/logging-commands
Console.WriteLine($"##[debug] Script execution time: {scriptExecutionTime}");

static void PrintPipelineVar(string varName)
{
    string? varValue = Environment.GetEnvironmentVariable(varName.Replace('.', '_').ToUpperInvariant());
    Console.WriteLine($"{varName}: {varValue}");
}
