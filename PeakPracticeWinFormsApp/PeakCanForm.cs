using Peak.Can.Basic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeakPracticeWinFormsApp
{
    public partial class PeakCanForm : Form
    {
        public static Worker worker;

        public event EventHandler<MessageAvailableEventArgs> MessageAvailable;

        public PcanMessage message;

        ObservableCollection<Broadcast> broadcasts = new ObservableCollection<Broadcast>();

        public Dictionary<int, Bitrate> bitrates = new Dictionary<int, Bitrate>();

        public Dictionary<int, PcanChannel> channels = new Dictionary<int, PcanChannel>();

        //Channels ComboBox Item Source
        List<string> channelsList = new List<string>();

        //Bitrate ComboBox Item Source
        List<string> bitRateList = new List<string>();

        public PcanChannel selectedPcanChannel { get; set; }

        public Bitrate selectedBitrate{ get; set; }
        public PeakCanForm()
        {
            InitializeComponent();
            AddChannles();
            AddBitRates();

        }

        //Add channels to the Channels ComboBox
        public void AddChannles()
        {
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

            foreach (var item in channels)
            {
                channelsList.Add(item.Value.ToString());
            }

            PcanChannelcomboBox.Items.AddRange(channelsList.ToArray());
        }

        //Add bitrates to the Bitrates ComboBox
        public void AddBitRates()
        {
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

            foreach (var item in bitrates)
            {
                bitRateList.Add(item.Value.ToString());
            }

            BitratecomboBox.Items.AddRange(bitRateList.ToArray());
        }

        //Initialize a Worker with two overloads (PcanChannel, Bitrate)
        private void Initializebutton_Click(object sender, EventArgs e)
        {
            selectedPcanChannel = channels.Where(i => i.Key == PcanChannelcomboBox.SelectedIndex).Select(s => s.Value).FirstOrDefault();

            selectedBitrate = bitrates.Where(i => i.Key == BitratecomboBox.SelectedIndex).Select(s => s.Value).FirstOrDefault();

            if(selectedPcanChannel == 0 || selectedBitrate == 0)
            {
                MessageBox.Show("Please select a Can Channel and Bitrate");                
            }
            else
            {
                worker = new Worker(selectedPcanChannel, selectedBitrate);
                BroadcastgroupBox.Enabled = true;
            }
           
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            uint id;
            bool intOK = uint.TryParse(IdtextBox.Text, out id);

            if (!intOK)
            {
                MessageBox.Show("The Id value is not valid!");
            }



            byte länge;

            bool längeOK = byte.TryParse(längetextBox.Text, out länge);

            if (!längeOK)
            {
                MessageBox.Show("The length is not valid!");
            }



            List<byte> daten = new List<byte>();

            string[] datenOK = datentextBox.Text.Split(',');

            for (int i = 0; i < datenOK.Length; i++)
            {
                byte toadd;

                bool dataOk = byte.TryParse(datenOK[i], out toadd);

                if (!dataOk)
                {
                    MessageBox.Show("Invalid byte array");
                }

                daten.Add(toadd);
            }

            message = new PcanMessage(id, MessageType.Standard, länge, daten.ToArray(), false);


            if (broadcasts.Count < 3)
            {
                Broadcast broadcast = new Broadcast(message, 250);
                broadcasts.Add(broadcast);
                BroadcastdataGridView.Rows.Add(broadcast.Index, broadcast.Message, broadcast.Interval, broadcast.Active);
                Startbutton.Enabled = true;
            }
            else
            {
                MessageBox.Show("There are only three Broadcast allowed!");
            }

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (BroadcastdataGridView.CurrentRow != null)
            {
                Broadcast brd = broadcasts[BroadcastdataGridView.SelectedRows[0].Index];

                worker.AddBroadcast(ref brd);
                worker.MessageAvailable += Workerworker_MessageAvailable;

                worker.Start();

            }
            else
            {
                MessageBox.Show("Please select a row!");
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            broadcasts.RemoveAt(BroadcastdataGridView.SelectedRows[0].Index);
            BroadcastdataGridView.Rows.RemoveAt(BroadcastdataGridView.SelectedRows[0].Index);         
        }

        public void Workerworker_MessageAvailable(object? sender, MessageAvailableEventArgs e)
        {
            PcanMessage output;
            ulong timestamp;

            while (worker.Dequeue(out output, out timestamp))
                ProcessYourMessage(output, timestamp);
            worker.Stop();
        }

        public void ProcessYourMessage(object msg, ulong timestamp)
        {
            CanDatenlistBox.Text = $" New message retrieved. Timestamp: {timestamp} | {msg}";
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            worker.Stop();
        }
    }
}
