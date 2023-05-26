using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIP
{
    public partial class Form1 : Form
    {
        //byte[] serieel = new byte[] { 0x30 };
        bool toggleNummers = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbParking.SizeMode = PictureBoxSizeMode.Zoom;
            lstPoort.Width = pnlConnect.Width / 3;
            lstConsole.Width = pnlConnect.Width - lstPoort.Width;
            //alle seriële poorten voor dit toestel opvragen
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string poort in ports)
            {
                lstPoort.Items.Add(poort);
            }
            foreach (Label label in pbParking.Controls.OfType<Label>())
            {
                label.Parent = pbParking;
            }
            InitializeLabels(); //oproepen functie om alle labels op te slaan in de map
        }

        //Selecteren seriele poort
        //Dit event wordt opgeroepen wanneer en keuze voor een seriele poort wordt gemaakt,
        //hierna wordt indien mogelijk de verbinding opgezet
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
                    lblConnect.Visible = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                lstConsole.Items.Add(ex.Message.ToString());
            }
        }

        //InitializeLabels
        //InitializeLabels zal van alle labels van elk parkeervak het nummer opslaan zodat automatisch het nummer later kan gebruikt worden
        private Dictionary<int, Label> labelMap = new Dictionary<int, Label>();
        private void InitializeLabels()
        {
            //Eerst wordt een tag toegewezen aan elk label waarna dit wordt opgeslagen in een map
            foreach (Label label in pnlParkingEnStatus.Controls.OfType<Label>())
            {
                int number = int.Parse(label.Name.Substring(1));
                label.Tag = number;
                labelMap[number] = label;
                //label.Text = label.Tag.ToString();
            }
        }

        //Aanpassen Kleur Labels
        //Deze functie zorgt ervoor dat het label gekoppelt aan het nummer van de 
        //parkeerplaats veranderd van kleur afhankelijk of de parking bezet is of niet
        private void AanpassenKleur(int nummer, Color color)
        {
            if (labelMap.TryGetValue(nummer, out Label label))
            {
                label.BackColor = color;
            }
        }

        //Data ontvangen
        //Event waarin alle serieel ontvangen data wordt verwerkt met de nodige extra functies

        int[] parkeerplaatsen = new int[27];
        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serial.ReadLine();
            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    lstConsole.Items.Insert(0, data);
                    if (data.Contains("PARKING-OPGESTART"))
                    {
                        tsConnectie.Text = "Verbonden";
                        tsConnectie.ForeColor = Color.Green;
                    }
                    else if (data.StartsWith("B")) // Aantal bezette parkeerplaatsen
                    {
                        int bezetteparkeerplaatsen = int.Parse(data.Substring(1));
                        BezetteParkeerplaatsen = bezetteparkeerplaatsen;
                    }
                    else if (data.StartsWith("PB")) //Parking Bezet
                    {
                        int parkeerplaats = int.Parse(data.Substring(2));
                        if (parkeerplaatsen[parkeerplaats] != 1)
                        {
                            parkeerplaatsen[parkeerplaats] = 1;
                            if (File.Exists(logboekLocatie))
                            {
                                StreamWriter streamwriter = new StreamWriter(logboekLocatie, true);
                                streamwriter.WriteLine("[" + DateTime.Now.ToString() + "] " + parkeerplaats.ToString() + " BEZET");
                                streamwriter.Close();
                            }
                        }
                        AanpassenKleur(parkeerplaats, Color.Red);
                    }
                    else if (data.StartsWith("PL")) //Parking Leeg
                    {
                        int parkeerplaats = int.Parse(data.Substring(2));
                        if (parkeerplaatsen[parkeerplaats] != 0)
                        {
                            parkeerplaatsen[parkeerplaats] = 0;
                            if (File.Exists(logboekLocatie))
                            {
                                StreamWriter streamwriter = new StreamWriter(logboekLocatie, true);
                                streamwriter.WriteLine("[" + DateTime.Now.ToString() + "] " + parkeerplaats.ToString() + " LEEG");
                                streamwriter.Close();
                            }
                        }
                        AanpassenKleur(parkeerplaats, Color.Green);
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            lstPoort.Width = pnlConnect.Width / 3;
            lstConsole.Width = pnlConnect.Width - lstPoort.Width;
        }

        //Slagboom mode keuzemenu
        //Event dat wordt geactiveerd bij het selecteren van een andere slagboom,
        //afhankelijk van de naam wordt de mode toegepast en serieel verzonden naar de microcontroller
        private void slagboomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem currentItem = sender as ToolStripMenuItem;
            try
            {
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
                    serial.Write("slagboom10\r");
                    lstConsole.Items.Insert(0, "Normale Werking 1");
                    tsSlagboom1.Text = "Slagboom 1: Normaal";
                }
                else if (currentItem == altijdOpenSlagboom1ToolStripMenuItem)
                {
                    serial.Write("slagboom11\r");
                    lstConsole.Items.Insert(0, "Altijd open 1");
                    tsSlagboom1.Text = "Slagboom 1: Altijd Open";
                }
                else if (currentItem == altijdGeslotenSlagboom1ToolStripMenuItem)
                {
                    serial.Write("slagboom13\r");
                    lstConsole.Items.Insert(0, "Altijd gesloten 1");
                    tsSlagboom1.Text = "Slagboom 1: Altijd Gesloten";
                }
                if (currentItem == normaleWerkingSlagboom2ToolStripMenuItem)
                {
                    serial.Write("slagboom20\r");
                    lstConsole.Items.Insert(0, "Normale Werking 2");
                    tsSlagboom2.Text = "Slagboom 2: Normaal";
                }
                else if (currentItem == altijdOpenSlagboom2ToolStripMenuItem)
                {
                    serial.Write("slagboom21\r");
                    lstConsole.Items.Insert(0, "Altijd open 2");
                    tsSlagboom2.Text = "Slagboom 2: Altijd Open";
                }
                else if (currentItem == altijdGeslotenSlagboom2ToolStripMenuItem)
                {
                    serial.Write("slagboom22\r");
                    lstConsole.Items.Insert(0, "Altijd gesloten 2");
                    tsSlagboom2.Text = "Slagboom 2: Altijd Gesloten";
                }
            }
            catch (Exception ex)
            {
                //Toon de error wanneer er geen poort is geselecteerd
                MessageBox.Show("Error: " + ex.Message + " U heeft waarschijnlijk geen poort geselecteerd");
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
                        tsBeschikbaar.Text = BezetteParkeerplaatsen + ("/26");
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (serial.IsOpen)
            //{
            //    serial.Close();
            //}
        }

        private void tsWeergevenNummer_Click(object sender, EventArgs e)
        {
            //private Dictionary<int, Label> labelMap = new Dictionary<int, Label>();
            if (toggleNummers == false)
            {
                foreach (Label label in pnlParkingEnStatus.Controls.OfType<Label>())
                {
                    int number = int.Parse(label.Name.Substring(1));
                    label.Tag = number;
                    label.Text = " " + label.Tag.ToString() + " ";
                }
                toggleNummers = true;
            }
            else
            {
                foreach (Label label in pnlParkingEnStatus.Controls.OfType<Label>())
                {
                    int number = int.Parse(label.Name.Substring(1));
                    label.Tag = number;
                    label.Text = "    ";
                }
                toggleNummers = false;
            }
        }

        string logboekLocatie;
        private void tsLogBoekLocatie_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                fbd.Filter = ".txt files (*.txt)|*.txt";
                fbd.Title = "Kies of maak een .txt bestand";
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.ToString()))
                {
                    logboekLocatie = (fbd.FileName.ToString());
                    System.Windows.Forms.MessageBox.Show("Logboek wordt opgeslagen in: " + logboekLocatie);
                    if (File.Exists(logboekLocatie))
                    {
                        StreamWriter streamwriter = new StreamWriter(logboekLocatie, true);
                        streamwriter.WriteLine("[" + DateTime.Now.ToString() + "]" + "LOGBOEK GEOPEND");
                        streamwriter.Close();
                    }
                }
            }
        }
    }
}
