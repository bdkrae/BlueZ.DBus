using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tmds.DBus;

namespace BlueZ.NET
{
  [Dictionary]
  public class GattDescriptor1Properties : IEnumerable<KeyValuePair<string,object>>
  {
    public string UUID;
    public ObjectPath Characteristic;
    public byte[] Value;
    public string[] Flags;

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    public IEnumerator<KeyValuePair<string,object>> GetEnumerator()
    {
      yield return new KeyValuePair<string, object>(nameof(UUID), UUID);
      yield return new KeyValuePair<string, object>(nameof(Characteristic), Characteristic);
      yield return new KeyValuePair<string, object>(nameof(Value), Value);
      yield return new KeyValuePair<string, object>(nameof(Flags), Flags);
    }
  }

  /// <summary>
  /// DBus Interface: org.bluez.GattDescriptor1
  /// Object path: [variable prefix]/{hci0,hci1,...}/dev_XX_XX_XX_XX_XX_XX/serviceXX/charYYYY/descriptorZZZ
  /// </summary>
  [DBusInterface("org.bluez.GattDescriptor1")]
  public interface GattDescriptor1 : IDBusObject
  {
    Task<byte[]> ReadValueAsync(IDictionary<string, object> flags);
    Task WriteValueAsync(byte[] value, IDictionary<string, object> flags);

    Task<GattDescriptor1Properties> GetAllAsync();
    Task<T> GetAsync<T>(string prop);
    Task SetAsync(string prop, object val);
    Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
  }
}
