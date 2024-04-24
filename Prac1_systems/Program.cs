using System;
using System.Management;

namespace ProcessInfo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string computerName = ".";
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("\\\\" + computerName + "\\root\\CIMV2", "SELECT * FROM Win32_TimeZone");

        //    foreach (ManagementObject queryObj in searcher.Get())
        //    {
        //        Console.WriteLine("-----------------------------------");
        //        Console.WriteLine("Win32_TimeZone");
        //        Console.WriteLine("Caption: " + queryObj["Caption"]);
        //        Console.WriteLine("DaylightName: " + queryObj["DaylightName"]);
        //        Console.WriteLine("Description: " + queryObj["Description"]);
        //        Console.WriteLine("Bias: " + queryObj["Bias"]);
        //        Console.WriteLine("DayLightBias: " + queryObj["DayLightBias"]);
        //        Console.WriteLine("-----------------------------------");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    string computerName = ".";
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Product");

        //    foreach (ManagementObject queryObj in searcher.Get())
        //    {
        //        Console.WriteLine("-----------------------------------");
        //        Console.WriteLine("Win32_Product");
        //        Console.WriteLine("Name: " + queryObj["Name"]);
        //        Console.WriteLine("Vendor: " + queryObj["Vendor"]);
        //        Console.WriteLine("Version: " + queryObj["Version"]);
        //        Console.WriteLine("InstallDate: " + queryObj["InstallDate"]);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    string computerName = ".";
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

        //    foreach (ManagementObject queryObj in searcher.Get())
        //    {
        //        Console.WriteLine("-----------------------------------");
        //        Console.WriteLine("Win32_Processor");
        //        Console.WriteLine("Name: " + queryObj["Name"]);
        //        Console.WriteLine("MaxClockSpeed: " + queryObj["MaxClockSpeed"]);
        //        Console.WriteLine("SocketDesignation: " + queryObj["SocketDesignation"]);
        //        Console.WriteLine("Status: " + queryObj["Status"]);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    string computerName = ".";
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");

        //    foreach (ManagementObject queryObj in searcher.Get())
        //    {
        //        Console.WriteLine("-----------------------------------");
        //        Console.WriteLine("Win32_BIOS");
        //        Console.WriteLine("BIOSVersion: " + queryObj["BIOSVersion"]);
        //        Console.WriteLine("Manufacturer: " + queryObj["Manufacturer"]);
        //        Console.WriteLine("Status: " + queryObj["Status"]);
        //        Console.WriteLine("CurrentLanguage: " + queryObj["CurrentLanguage"]);
        //    }
        //}
        static void Main(string[] args)
        {
            string computerName = ".";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Win32_ComputerSystem");
                Console.WriteLine("Caption: " + queryObj["Caption"]);
                Console.WriteLine("Manufacturer: " + queryObj["Manufacturer"]);
                Console.WriteLine("Model: " + queryObj["Model"]);
                Console.WriteLine("PrimaryOwnerName: " + queryObj["PrimaryOwnerName"]);
                Console.WriteLine("SystemType: " + queryObj["SystemType"]);
            }
        }
    }
}