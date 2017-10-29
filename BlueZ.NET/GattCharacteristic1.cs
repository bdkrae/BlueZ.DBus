using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tmds.DBus;

namespace BlueZ.NET
{
  [Dictionary]
  public class GattCharacteristic1Properties : IEnumerable<KeyValuePair<string,object>>
  {
    public string UUID;
    public ObjectPath Service;
    public byte[] Value;
    public bool Notifying;
    public string[] Flags;

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    public IEnumerator<KeyValuePair<string,object>> GetEnumerator()
    {
      yield return new KeyValuePair<string, object>(nameof(UUID), UUID);
      yield return new KeyValuePair<string, object>(nameof(Service), Service);
      yield return new KeyValuePair<string, object>(nameof(Value), Value);
      yield return new KeyValuePair<string, object>(nameof(Notifying), Notifying);
      yield return new KeyValuePair<string, object>(nameof(Flags), Flags);
    }
  }

  /// <summary>
  /// DBus Interface: org.bluez.GattCharacteristic1
  /// Object path: [variable prefix]/{hci0,hci1,...}/dev_XX_XX_XX_XX_XX_XX/serviceXX/charYYYY
  /// </summary>
  [DBusInterface("org.bluez.GattCharacteristic1")]
  public interface IGattCharacteristic1 : IDBusObject
  {
    Task<byte[]> ReadValueAsync(IDictionary<string, object> flags);
    Task WriteValueAsync(byte[] value, IDictionary<string, object> flags);
    Task StartNotifyAsync();
    Task StopNotifyAsync();

    Task<GattCharacteristic1Properties> GetAllAsync();
    Task<T> GetAsync<T>(string prop);
    Task SetAsync(string prop, object val);
    Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
  }
}
