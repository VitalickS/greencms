using System.Diagnostics;

var process = Process.Start(new ProcessStartInfo
{
    UseShellExecute = false,
    FileName = args[0],
    Arguments = args[1],
});
await process?.WaitForExitAsync();

return process.ExitCode;
