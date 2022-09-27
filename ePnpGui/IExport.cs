using System.Collections.Generic;
using ePnpGui.Utils;

namespace ePnpGui
{
    public interface IExport
    {
        string Export(List<DriverStoreEntry> ldse);
    }
}
