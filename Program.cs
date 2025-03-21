using Microsoft.Win32;

namespace SurfaceManualRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl", true))
            {
                if (registryKey == null)
                    return;
                string str = registryKey.GetValue("ConvertibleSlateMode").ToString();
                registryKey.SetValue("ConvertibleSlateMode", str == "0" ? "1" : "0", RegistryValueKind.DWord);
                registryKey.Close();
            }
        }
    }
}
