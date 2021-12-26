var process = new System.Diagnostics.Process();

process.StartInfo.UseShellExecute = false;
process.StartInfo.FileName = args[0];
foreach (var arg in args.Skip(1))
{
    process.StartInfo.ArgumentList.Add(arg);
}
process.StartInfo.RedirectStandardError = true;
process.StartInfo.RedirectStandardOutput = true;

process.ErrorDataReceived += (sendingProcess, errorLine) => Console.Error.WriteLine(errorLine.Data);
process.OutputDataReceived += (sendingProcess, dataLine) => Console.WriteLine(dataLine.Data);

process.Start();

process.BeginErrorReadLine();
process.BeginOutputReadLine();

await process?.WaitForExitAsync();

return process?.ExitCode ?? default;
