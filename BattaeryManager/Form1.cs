using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattaeryManager
{
    public partial class BatteryManager : Form
    {
        private static Guid GUID_SLEEP_SUBGROUP = new Guid("238c9fa8-0aad-41ed-83f4-97be242c8f20");
        private static Guid GUID_HIBERNATEIDLE = new Guid("9d7815a6-7ee4-497e-8888-515a05f02364");
        private static Guid SCHEME_MAX = new Guid("a1841308-3541-4fab-bc81-f71556f20b4a");
        private static Guid SCHEME_BALANCED = new Guid("381b4222-f694-41f0-9685-ff5bb260df2e");
        private static Guid SCHEME_MIN = new Guid("8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");

        [DllImport("GDI32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(int hdc, void* ramp); 

        [DllImport("powrprof.dll")]
        static unsafe extern uint PowerSetActiveScheme(
           IntPtr UserRootPowerKey,
           ref Guid ActivePolicyGuid);

        [DllImport("powrprof.dll")]
        static unsafe extern uint PowerGetActiveScheme(
           IntPtr UserRootPowerKey,
           ref IntPtr ActivePolicyGuid);

        [DllImport("powrprof.dll")]
        static unsafe extern uint PowerReadACValue(
           IntPtr RootPowerKey,
           ref Guid SchemeGuid,
           ref Guid SubGroupOfPowerSettingGuid,
           ref Guid PowerSettingGuid,
           ref int Type,
           ref int Buffer,
           ref uint BufferSize);
        public BatteryManager()
        {            
            InitializeComponent();
        }
        private static bool initialized = false;
        private static Int32 hdc;


        private static void InitializeClass()
        {
            if (initialized)
                return;

            //Get the hardware device context of the screen, we can do
            //this by getting the graphics object of null (IntPtr.Zero)
            //then getting the HDC and converting that to an Int32.
            hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();

            initialized = true;
        }

        public static unsafe bool SetBrightness(short brightness)
        {
            InitializeClass();

            if (brightness > 255)
                brightness = 255;

            if (brightness < 0)
                brightness = 0;

            short* gArray = stackalloc short[3 * 256];
            short* idx = gArray;

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 256; i++)
                {
                    int arrayVal = i * (brightness + 128);

                    if (arrayVal > 65535)
                        arrayVal = 65535;

                    *idx = (short)arrayVal;
                    idx++;
                }
            }

            //For some reason, this always returns false?
            bool retVal = SetDeviceGammaRamp(hdc, gArray);

            //Memory allocated through stackalloc is automatically free'd
            //by the CLR.

            return retVal;
        }
        private void btn_high_Click(object sender, EventArgs e)
        { 
            PowerSetActiveScheme(IntPtr.Zero, ref SCHEME_MIN);
            //SetBrightness(150);
            MessageBox.Show("mode Hautes Performances activé");
        }

        private void btn_low_Click(object sender, EventArgs e)
        {
            PowerSetActiveScheme(IntPtr.Zero, ref SCHEME_MAX);
            //SetBrightness(75);
            MessageBox.Show("mode Économie d'énergie activé");
        }

    }
}
