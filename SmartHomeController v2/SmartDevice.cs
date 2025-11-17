using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHomeController
{
    public class SmartDevice
    {
        // Private fields
        public int deviceId;
        public string deviceName;
        public bool status;

        // Public properties
        public int DeviceID
        {
            get { return deviceId; }
            set { deviceId = value; }
        }

        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public SmartDevice(int deviceID, string deviceName)
        {
            this.DeviceID = deviceID;
            this.DeviceName = deviceName;
            this.Status = false; // default status for a new smart item

        }
        public void TurnOn()
        {
            Status = true;
            Console.WriteLine($"{DeviceName} with device ID {DeviceID} is now ON.");
        }
        public void TurnOff()
        {
            Status = false;
            Console.WriteLine($"{DeviceName} with device ID {DeviceID} is now OFF.");
        }
        public virtual void GetStatus()
        {
            Console.WriteLine($"Device ID: {DeviceID}, Device Name: {DeviceName}, Status (on or off): {(Status ? "ON" : "OFF")}");
        }
    }
}
