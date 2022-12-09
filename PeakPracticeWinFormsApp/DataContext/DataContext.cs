using Peak.Can.Basic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PeakPracticeWinFormsApp.DataContext
{
    public static class DataContext 
    {
        public static Dictionary<int, Bitrate> LoadBitrates()
        {
            Dictionary<int, Bitrate> bitrates = new Dictionary<int, Bitrate>();

            bitrates.Add(0, Bitrate.Pcan10);
            bitrates.Add(1, Bitrate.Pcan100);
            bitrates.Add(2, Bitrate.Pcan1000);
            bitrates.Add(3, Bitrate.Pcan125);
            bitrates.Add(4, Bitrate.Pcan20);
            bitrates.Add(5, Bitrate.Pcan250);
            bitrates.Add(6, Bitrate.Pcan33);
            bitrates.Add(7, Bitrate.Pcan47);
            bitrates.Add(8, Bitrate.Pcan5);
            bitrates.Add(9, Bitrate.Pcan50);
            bitrates.Add(10, Bitrate.Pcan500);
            bitrates.Add(11, Bitrate.Pcan800);
            bitrates.Add(12, Bitrate.Pcan83);
            bitrates.Add(13, Bitrate.Pcan95);

            return bitrates;
        }


        public static Dictionary<int, PcanChannel> LoadPcanChannels()
        {
            Dictionary<int, PcanChannel> channels = new Dictionary<int, PcanChannel>();

            channels.Add(0, PcanChannel.Lan01);
            channels.Add(1, PcanChannel.Lan02);
            channels.Add(2, PcanChannel.Lan03);
            channels.Add(3, PcanChannel.Lan04);
            channels.Add(4, PcanChannel.Lan05);
            channels.Add(5, PcanChannel.Lan06);
            channels.Add(6, PcanChannel.Lan07);
            channels.Add(7, PcanChannel.Lan08);
            channels.Add(8, PcanChannel.Lan09);
            channels.Add(9, PcanChannel.Lan10);
            channels.Add(10, PcanChannel.Lan11);
            channels.Add(11, PcanChannel.Lan12);
            channels.Add(12, PcanChannel.Lan13);
            channels.Add(13, PcanChannel.Lan14);
            channels.Add(14, PcanChannel.Lan15);
            channels.Add(15, PcanChannel.Lan16);

            channels.Add(16, PcanChannel.Pci01);
            channels.Add(17, PcanChannel.Pci02);
            channels.Add(18, PcanChannel.Pci03);
            channels.Add(19, PcanChannel.Pci04);
            channels.Add(20, PcanChannel.Pci05);
            channels.Add(21, PcanChannel.Pci06);
            channels.Add(22, PcanChannel.Pci07);
            channels.Add(23, PcanChannel.Pci08);
            channels.Add(24, PcanChannel.Pci09);
            channels.Add(25, PcanChannel.Pci10);
            channels.Add(26, PcanChannel.Pci11);
            channels.Add(27, PcanChannel.Pci12);
            channels.Add(28, PcanChannel.Pci13);
            channels.Add(29, PcanChannel.Pci14);
            channels.Add(30, PcanChannel.Pci15);
            channels.Add(31, PcanChannel.Pci16);

            channels.Add(32, PcanChannel.Usb01);
            channels.Add(33, PcanChannel.Usb02);
            channels.Add(34, PcanChannel.Usb03);
            channels.Add(35, PcanChannel.Usb04);
            channels.Add(36, PcanChannel.Usb05);
            channels.Add(37, PcanChannel.Usb06);
            channels.Add(38, PcanChannel.Usb07);
            channels.Add(39, PcanChannel.Usb08);
            channels.Add(40, PcanChannel.Usb09);
            channels.Add(41, PcanChannel.Usb10);
            channels.Add(42, PcanChannel.Usb11);
            channels.Add(43, PcanChannel.Usb11);
            channels.Add(44, PcanChannel.Usb13);
            channels.Add(45, PcanChannel.Usb14);
            channels.Add(46, PcanChannel.Usb15);
            channels.Add(47, PcanChannel.Usb16);

            return channels;
        }
    }
}
