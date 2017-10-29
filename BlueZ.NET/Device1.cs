using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tmds.DBus;

namespace BlueZ.NET
{
  [Dictionary]
  public class Device1Properties : IEnumerable<KeyValuePair<string,object>>
  {
    public ObjectPath[] GattServices;
    public IList<string> UUIDs;
    public bool Blocked;
    public bool Connected;
    public bool LegacyPairing;
    public bool Paired;
    public bool Trusted;
    public short RSSI;
    public ObjectPath Adapter;
    public string Address;
    public string Alias;
    public string Icon;
    public string Modalias;
    public string Name;
    public ushort Appearance;
    public uint Class;
    public Int16 TxPower;
    public IDictionary<UInt16, object> ManufacturerData;
    public IDictionary<string, object> ServiceData;
    public bool ServicesResolved;
    public byte[] AdvertisingFlags;

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    public IEnumerator<KeyValuePair<string,object>> GetEnumerator()
    {
      yield return new KeyValuePair<string, object>(nameof(GattServices), GattServices);
      yield return new KeyValuePair<string, object>(nameof(UUIDs), UUIDs);
      yield return new KeyValuePair<string, object>(nameof(Blocked), Blocked);
      yield return new KeyValuePair<string, object>(nameof(Connected), Connected);
      yield return new KeyValuePair<string, object>(nameof(LegacyPairing), LegacyPairing);
      yield return new KeyValuePair<string, object>(nameof(Paired), Paired);
      yield return new KeyValuePair<string, object>(nameof(Trusted), Trusted);
      yield return new KeyValuePair<string, object>(nameof(RSSI), RSSI);
      yield return new KeyValuePair<string, object>(nameof(Adapter), Adapter);
      yield return new KeyValuePair<string, object>(nameof(Address), Address);
      yield return new KeyValuePair<string, object>(nameof(Alias), Alias);
      yield return new KeyValuePair<string, object>(nameof(Icon), Icon);
      yield return new KeyValuePair<string, object>(nameof(Modalias), Modalias);
      yield return new KeyValuePair<string, object>(nameof(Name), Name);
      yield return new KeyValuePair<string, object>(nameof(Appearance), Appearance);
      yield return new KeyValuePair<string, object>(nameof(Class), Class);
      yield return new KeyValuePair<string, object>(nameof(TxPower), TxPower);
      yield return new KeyValuePair<string, object>(nameof(ManufacturerData), ManufacturerData);
      yield return new KeyValuePair<string, object>(nameof(ServiceData), ServiceData);
      yield return new KeyValuePair<string, object>(nameof(ServicesResolved), ServicesResolved);
      yield return new KeyValuePair<string, object>(nameof(AdvertisingFlags), AdvertisingFlags);
    }
  }

  /// <summary>
  /// DBus Interface: org.bluez.Device1
  /// Object path: [variable prefix]/{hci0,hci1,...}/dev_XX_XX_XX_XX_XX_XX
  /// </summary>
  [DBusInterface("org.bluez.Device1")]
  public interface IDevice1 : IDBusObject
  {
    Task CancelPairingAsync();
    Task ConnectAsync();
    Task ConnectProfileAsync(string UUID);
    Task DisconnectAsync();
    Task DisconnectProfileAsync(string UUID);
    Task PairAsync();
    
    Task<Device1Properties> GetAllAsync();
    Task<T> GetAsync<T>(string prop);
    Task SetAsync(string prop, object val);
    Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
  }
}
