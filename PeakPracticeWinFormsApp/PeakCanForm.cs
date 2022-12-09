using Peak.Can.Basic;
using PeakPracticeWinFormsApp.DataContext;
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
        //Worker
        public static Worker worker;

        //MessageAvailable EventHandler
        public event EventHandler<MessageAvailableEventArgs> MessageAvailable;

        public PcanMessage message;

        //Collection of the registredted Broadcasts
        ObservableCollection<Broadcast> broadcasts = new ObservableCollection<Broadcast>();

        //Collection of Bitrates
        public Dictionary<int, Bitrate> bitrates = new Dictionary<int, Bitrate>();

        //Collection of Pcan Channels
        public Dictionary<int, PcanChannel> channels = new Dictionary<int, PcanChannel>();

        //Channels ComboBox Item Source
        List<string> channelsList = new List<string>();

        //Bitrate ComboBox Item Source
        List<string> bitRateList = new List<string>();

        //Selected Pcan Chanel from ComboBox  to initialize a Worker
        public PcanChannel selectedPcanChannel { get; set; }
        //Selected Bitrate from ComboBox to initialize a Worker
        public Bitrate selectedBitrate{ get; set; }


        public PeakCanForm()
        {
            InitializeComponent();
            AddChannlesandBitrates();
        }

        //Add channels and bitrates to the Channels and Bitrates ComboBox
        public void AddChannlesandBitrates()
        {

            channels = DataContext.DataContext.LoadPcanChannels();

            bitrates = DataContext.DataContext.LoadBitrates();

            foreach (var item in channels)
            {
                channelsList.Add(item.Value.ToString());
            }

            PcanChannelcomboBox.Items.AddRange(channelsList.ToArray());

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
