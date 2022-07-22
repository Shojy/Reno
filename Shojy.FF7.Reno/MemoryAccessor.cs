using Shojy.FF7.Reno.MemoryAddresses;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno;

[PublicAPI]
public interface IMemoryAccessor : IDisposable
{
    bool ReadMemory(MemoryLocation memoryLocation, out byte[] bytes);

    IMemoryAccessor SetProcess(Process process);
}

[PublicAPI]
[UsedImplicitly]
public class MemoryAccessor : IMemoryAccessor
{
    private bool _disposed;
    private const int ProcessAllAccess = 0x1F0FFF;

    ~MemoryAccessor()
    {
        Dispose(false);
    }

    public Process? TargetProcess { get; private set; } = null;
    public IntPtr TargetProcessHandle { get; private set; } = IntPtr.Zero;

    public void Close()
    {
        if (TargetProcessHandle != IntPtr.Zero)
        {
            CloseHandle(TargetProcessHandle);
            TargetProcessHandle = IntPtr.Zero;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public bool ReadMemory(MemoryLocation memoryLocation, out byte[] bytes)
    {
        if (ConfirmProcessConnection())
        {
            bytes = new byte[memoryLocation.Length];
            var result = ReadProcessMemory(TargetProcessHandle, memoryLocation.Address, bytes, Convert.ToUInt32(memoryLocation.Length), out var bytesRead);
            return result;
        }

        bytes = Array.Empty<byte>();
        return false;
    }

    public IMemoryAccessor SetProcess(Process process)
    {
        TargetProcess = process;
        return this;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            Close();
        }

        _disposed = true;
    }

    private bool ConfirmProcessConnection()
    {
        try
        {
            if (TargetProcess is null)
            {
                return false;
            }

            if (!TargetProcess.HasExited && TargetProcessHandle != IntPtr.Zero)
            {
                return true;
            }

            TargetProcessHandle = OpenProcess(ProcessAllAccess, true, Convert.ToUInt32(TargetProcess.Id));

            return TargetProcessHandle != IntPtr.Zero;
        }
        catch
        {
            return false;
        }
    }

    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, out uint lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesWritten);
}