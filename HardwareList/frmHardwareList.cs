using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace HardwareList
{
    public partial class frmHardwareList : Form
    {
        public frmHardwareList()
        {
            InitializeComponent();
        }

        private void btnHardwareList_Click(object sender, EventArgs e)
        {

            lstHardwareList.Items.Add("Printer - Hardware Devices");

            ManagementScope objScope = new ManagementScope(ManagementPath.DefaultPath); //For the local Access
            objScope.Connect();

            SelectQuery selectQuery = new SelectQuery();
            selectQuery.QueryString = "Select * from win32_Printer";
            ManagementObjectSearcher MOS = new ManagementObjectSearcher(objScope, selectQuery);
            ManagementObjectCollection MOC = MOS.Get();
            foreach (ManagementObject mo in MOC)
            {
                lstHardwareList.Items.Add(mo["Name"].ToString());
            }

            lstHardwareList.Items.Add("USB - Hardware Devices");

            var usbDevices = GetUSBDevices();

            foreach (var usbDevice in usbDevices)
            {
                // lstHardwareList.Items.Add(String.Format("Device ID: {0}, PNP Device ID: {1}, Description: {2}",
                //    usbDevice.DeviceID, usbDevice.PnpDeviceID, usbDevice.Description));
                lstHardwareList.Items.Add(usbDevice.Description);
            }




        }



        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("PNPDeviceID"),
                (string)device.GetPropertyValue("Description")
                ));
            }

            collection.Dispose();
            return devices;
        }

    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
    }
}
