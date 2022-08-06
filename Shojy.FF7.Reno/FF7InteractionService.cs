using System.Diagnostics;
using Shojy.FF7.Reno.Extensions;
using Shojy.FF7.Reno.MemoryAddresses;
using Shojy.FF7.Reno.Models;

namespace Shojy.FF7.Reno;

[PublicAPI]
public interface IFF7InteractionService
{
    Task<Process> ConnectToGame();

    bool GetData(out SaveMap saveMap, out BattleMap battleMap);

    bool GetData(MemoryLocation memoryLocation, out byte[] bytes);
}

public class FF7InteractionService : IFF7InteractionService
{
    private readonly IProcessAccessor _processAccessor;
    private readonly IMemoryAccessor _memoryAccessor;
    

    public FF7InteractionService(IProcessAccessor processAccessor, IMemoryAccessor memoryAccessor)
    {
        _processAccessor = processAccessor;
        _memoryAccessor = memoryAccessor;
    }

    public async Task<Process> ConnectToGame()
    {
        var ff7 = await _processAccessor.ScanForProcess("ff7", "ff7_en");
        _memoryAccessor.SetProcess(ff7);
        return ff7;
    }

    public bool GetData(out SaveMap saveMap, out BattleMap battleMap)
    {
        var state = true;

        // Default these here to avoid a compile error for "not assigning them" before exiting on a fail state, even
        // though logically, there is no path that cannot assign them.
        saveMap = default;
        battleMap = default;

        try
        {
            if (_memoryAccessor.ReadMemory(MemoryLocations.SaveMap, out var saveBytes))
            {
                saveMap = saveBytes.ToType<SaveMap>();
            }
            else
            {
                state = false;
            }

            if (_memoryAccessor.ReadMemory(MemoryLocations.BattleMap, out var battleBytes))
            {
                battleMap = battleBytes.ToType<BattleMap>();
            }
            else
            {
                state = false;
            }
        }
        catch
        {
            state = false;
        }

        if (!state)
        {
            saveMap = default;
            battleMap = default;
        }

        return state;
    }

    public bool GetData(MemoryLocation memoryLocation, out byte[] bytes)
    {
        return _memoryAccessor.ReadMemory(memoryLocation, out bytes);
    }
}