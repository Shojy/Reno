using System.Diagnostics;

namespace Shojy.FF7.Reno;

[PublicAPI]
public interface IProcessAccessor
{
    Task<Process> ScanForProcess(params string[] names);
    Task<Process> ScanForProcess(int timeout, params string[] names);
    Task<Process> ScanForProcess(string name) => ScanForProcess(new [] {name});
    Task<Process> ScanForProcess(string name, int timeout) => ScanForProcess(timeout, name);
}

[PublicAPI]
[UsedImplicitly]
public class ProcessAccessor : IProcessAccessor
{
    public Task<Process> ScanForProcess(params string[] names)
    {
        return ScanForProcess(250, names);
    }

    public async Task<Process> ScanForProcess(int timeout, params string[] names)
    {
        Process? process = null;

        do
        {
            foreach (var name in names)
            {
                process = Process.GetProcessesByName(name).FirstOrDefault();
                if (process is not null)
                {
                    return process;
                }
            }

            await Task.Delay(timeout);
        } while (process is null);

        return process;
    }
}