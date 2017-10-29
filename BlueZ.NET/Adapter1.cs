using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tmds.DBus;

namespace BlueZ.NET
{
  [Dictionary]
  public class Adapter1Properties : IEnumerable<KeyValuePair<string,object>>
  {
    public IList<string> UUIDs;
    public bool Discoverable;
    public bool Discovering;
    public bool Pairable;
    public bool Powered;
    public string Address;
    public string Alias;
    public string Modalias;
    public string Name;
    public uint Class;
    public uint DiscoverableTimeout;
    public uint PairableTimeout;

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    public IEnumerator<KeyValuePair<string,object>> GetEnumerator()
    {
      yield return new KeyValuePair<string, object>(nameof(UUIDs), UUIDs);
      yield return new KeyValuePair<string, object>(nameof(Discoverable), Discoverable);
      yield return new KeyValuePair<string, object>(nameof(Discovering), Discovering);
      yield return new KeyValuePair<string, object>(nameof(Pairable), Pairable);
      yield return new KeyValuePair<string, object>(nameof(Powered), Powered);
      yield return new KeyValuePair<string, object>(nameof(Address), Address);
      yield return new KeyValuePair<string, object>(nameof(Alias), Alias);
      yield return new KeyValuePair<string, object>(nameof(Modalias), Modalias);
      yield return new KeyValuePair<string, object>(nameof(Name), Name);
      yield return new KeyValuePair<string, object>(nameof(Class), Class);
      yield return new KeyValuePair<string, object>(nameof(DiscoverableTimeout), DiscoverableTimeout);
      yield return new KeyValuePair<string, object>(nameof(PairableTimeout), PairableTimeout);
    }
  }

  /// <summary>
  /// DBus Interface: org.bluez.Adapter1
  /// Object path: [variable prefix]/{hci0,hci1,...}
  /// </summary>
  [DBusInterface("org.bluez.Adapter1")]
  public interface IAdapter1 : IDBusObject
  {
    Task RemoveDeviceAsync(ObjectPath device);
    Task SetDiscoveryFilterAsync(IDictionary<string,object> filter);
    Task StartDiscoveryAsync();
    Task StopDiscoveryAsync();

    Task<Adapter1Properties> GetAllAsync();
    Task<T> GetAsync<T>(string prop);
    Task SetAsync(string prop, object val);
    Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
  }
}
