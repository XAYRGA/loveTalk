﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using InTheHand;
using InTheHand.Bluetooth;


namespace loveTalk
{

    // 5a300001-0023-4bd4-bbd5-a6920e4c5653
    public static class BTManager
    {
        public static BluetoothDevice[] pairedDevices;
        public static BluetoothDevice[] getDevices()
        {           
            var cl1 = Bluetooth.GetPairedDevicesAsync().Result;
            return cl1.ToArray<BluetoothDevice>();
        }

    }
}
