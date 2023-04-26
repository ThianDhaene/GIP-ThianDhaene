using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIP
{
    public partial class Form1 : Form
    {
        byte[] serieel = new byte[] { 0x30 };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstPoort.Width = pnlConnect.Width / 3;
            lstConsole.Width = pnlConnect.Width - lstPoort.Width;
            //alle seriële poorten voor dit toestel opvragen
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string poort in ports)
                lstPoort.Items.Add(poort);
        }

        private void lstPoort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPoort.SelectedIndex == -1) return;
            string poort = lstPoort.SelectedItem.ToString();
            if (poort == serial.PortName) return; //zelfde poort geselecteerd
            serial.Close();
            try
            {
                serial.PortName = poort;
                serial.Open();
                if (serial.IsOpen == true)
                {
                    lstConsole.Items.Insert(0, "Nieuwe poort geopend:" + poort);
                    lstConsole.Items.Insert(0, "Start de garage op en wacht op bevestiging");
                    lstPoort.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                lstConsole.Items.Add(ex.Message.ToString());
            }
        }
        string data;
        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data = serial.ReadLine();
            Invoke(new MethodInvoker(delegate ()
            {
                lstConsole.Items.Insert(0, data);
                if (data.Contains("PARKING-OPGESTART"))
                {
                    tsConnectie.Text="Verbonden";
                    tsConnectie.ForeColor = Color.Green;
                }
                else if (data.Contains("Slagboom1-01"))
                {
                    
                }
            }));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serial.Write("test\r");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            lstPoort.Width = pnlConnect.Width / 3;
            lstConsole.Width = pnlConnect.Width - lstPoort.Width;
        }

        private void slagboom1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem currentItem = sender as ToolStripMenuItem;
            if (currentItem != null)
            {
                ((ToolStripMenuItem)currentItem.OwnerItem).DropDownItems.OfType<ToolStripMenuItem>().ToList().ForEach(item =>
                {
                    item.Checked = false;
                });
                currentItem.Checked = true;
            }
            if (currentItem == normaleWerkingSlagboom1ToolStripMenuItem)
            {
                lstConsole.Items.Insert(0, "Normale Werking 1");
                tsSlagboom1.Text = "Slagboom 1: Normaal";
            }
            else if (currentItem == altijdOpenSlagboom1ToolStripMenuItem)
            {
                lstConsole.Items.Insert(0, "Altijd open 1");
                tsSlagboom1.Text = "Slagboom 1: Altijd Open";
            }
            else if (currentItem == altijdGeslotenSlagboom1ToolStripMenuItem)
            {
                lstConsole.Items.Insert(0, "Altijd gesloten 1");
                tsSlagboom1.Text = "Slagboom 1: Altijd Gesloten";
            }
        }

        private void slagboom2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem currentItem = sender as ToolStripMenuItem;
            if (currentItem != null)
            {
                ((ToolStripMenuItem)currentItem.OwnerItem).DropDownItems.OfType<ToolStripMenuItem>().ToList().ForEach(item =>
                {
                    item.Checked = false;
                });
                currentItem.Checked = true;
            }
            if (currentItem == normaleWerkingSlagboom2ToolStripMenuItem)
            {
                lstConsole.Items.Insert(0, "Normale Werking 2");
                tsSlagboom2.Text = "Slagboom 2: Normaal";
            }
            else if (currentItem == altijdOpenSlagboom2ToolStripMenuItem)
            {
                lstConsole.Items.Insert(0, "Altijd open 2");
                tsSlagboom2.Text = "Slagboom 2: Altijd Open";
            }
            else if (currentItem == altijdGeslotenSlagboom2ToolStripMenuItem)
            {
                lstConsole.Items.Insert(0, "Altijd gesloten 2");
                tsSlagboom2.Text = "Slagboom 2: Altijd Gesloten";
            }
        }
        int _bezetteparkeerplaatsen = 0;
        public int BezetteParkeerplaatsen
        {
            get { return _bezetteparkeerplaatsen; }
            set
            {
                if (_bezetteparkeerplaatsen != value)
                {
                    _bezetteparkeerplaatsen = value;
                    if (BezetteParkeerplaatsen <= 26)
                    {
                        tsProgressbar.Value = BezetteParkeerplaatsen;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BezetteParkeerplaatsen++;
            serial.Write("test\r");
            
        }

        private void normaleWerkingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
