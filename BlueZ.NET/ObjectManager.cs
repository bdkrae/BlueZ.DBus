using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Tmds.DBus;

namespace BlueZ.NET
{
  /// <summary>
  /// DBus object manager. For Bluez.NET create proxy to:
  /// Service: org.bluez
  /// Object path: /
  /// </summary>
  [DBusInterface("org.freedesktop.DBus.ObjectManager")]
  public interface IObjectManager : IDBusObject
  {
    Task<IDictionary<ObjectPath,IDictionary<string,IDictionary<string,object>>>> GetManagedObjectsAsync();

    Task<IDisposable> WatchInterfacesAddedAsync(Action<(ObjectPath,IDictionary<string,IDictionary<string,object>>)> handler);
    Task<IDisposable> WatchInterfacesRemovedAsync(Action<(ObjectPath, string[])> handler);
  }
}

