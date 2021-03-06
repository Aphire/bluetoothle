using System;
using CoreBluetooth;
using Foundation;


namespace Acr.Ble
{
    public class PeripheralConnectionFailed
    {
        public PeripheralConnectionFailed(CBPeripheral peripheral, NSError error)
        {
            this.Peripheral = peripheral;
            this.Error = error;
        }


        public CBPeripheral Peripheral { get; }
        public NSError Error { get; }
    }
}