#:package Humanizer@2.14.1

using Humanizer;
using System.Diagnostics;

long scriptStartTime = Stopwatch.GetTimestamp();

PrintPipelineVar("GITHUB_RUN_NUMBER");
PrintPipelineVar("GITHUB_REPOSITORY");
PrintPipelineVar("GITHUB_HEAD_REF");

string scriptExecutionTime = Stopwatch.GetElapsedTime(scriptStartTime).Humanize();
Console.WriteLine($"::debug::Script execution time: {scriptExecutionTime}");

static void PrintPipelineVar(string varName)
{
    string? varValue = Environment.GetEnvironmentVariable(varName);
    Console.WriteLine($"{varName}: {varValue}");
}
