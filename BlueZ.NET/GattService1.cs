using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tmds.DBus;

namespace BlueZ.NET
{
  [Dictionary]
  public class GattService1Properties : IEnumerable<KeyValuePair<string,object>>
  {
    public string UUID;
    public bool Primary;
    public ObjectPath Device;
    public ObjectPath[] Includes;

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    public IEnumerator<KeyValuePair<string,object>> GetEnumerator()
    {
      yield return new KeyValuePair<string, object>(nameof(UUID), UUID);
      yield return new KeyValuePair<string, object>(nameof(Primary), Primary);
      yield return new KeyValuePair<string, object>(nameof(Device), Device);
      yield return new KeyValuePair<string, object>(nameof(Includes), Includes);
    }
  }

  /// <summary>
  /// DBus Interface: org.bluez.GattService1
  /// Object path: [variable prefix]/{hci0,hci1,...}/dev_XX_XX_XX_XX_XX_XX/serviceXX
  /// </summary>
  [DBusInterface("org.bluez.GattService1")]
  public interface IGattService1 : IDBusObject
  {
    Task<GattService1Properties> GetAllAsync();
    Task<T> GetAsync<T>(string prop);
    Task SetAsync(string prop, object val);
    Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
  }
}
