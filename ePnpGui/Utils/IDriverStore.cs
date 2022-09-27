using System.Collections.Generic;

namespace ePnpGui.Utils
{
    public interface IDriverStore
    {
        DriverStoreType Type { get; }

        string OfflineStoreLocation { get; }

        List<DriverStoreEntry> EnumeratePackages();

        bool DeleteDriver(DriverStoreEntry driverStoreEntry, bool forceDelete);

        bool AddDriver(string infFullPath, bool install);
    }
}
