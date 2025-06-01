#:package Humanizer@2.14.1

using Humanizer;
using System.Diagnostics;

long scriptStartTime = Stopwatch.GetTimestamp();

PrintPipelineVar("github.run.number");
PrintPipelineVar("github.repository");
PrintPipelineVar("github.ref");

string scriptExecutionTime = Stopwatch.GetElapsedTime(scriptStartTime).Humanize();

// Print additional info if pipeline job running in debug mode.
// https://docs.github.com/en/actions/writing-workflows/choosing-what-your-workflow-does/workflow-commands-for-github-actions#setting-a-debug-message
Console.WriteLine($"::debug::Script execution time: {scriptExecutionTime}");

static void PrintPipelineVar(string varName)
{
    string? varValue = Environment.GetEnvironmentVariable(varName.Replace('.', '_').ToUpperInvariant());
    Console.WriteLine($"{varName}: {varValue}");
}
