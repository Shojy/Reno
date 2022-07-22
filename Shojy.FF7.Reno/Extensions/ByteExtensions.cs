using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno.Extensions;

public static class ByteExtensions
{
    public static T ToType<T>(this byte[] bytes) where T : struct
    {
        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        try
        {
            return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T))!;
        }
        finally
        {
            handle.Free();
        }
    }

    public static T ToType<T>(this Span<byte> bytes) where T : struct
        => bytes.ToArray().ToType<T>();
}