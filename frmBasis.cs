using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WarpScan
{
    public partial class frmBasis : Form
    {
        public frmBasis()
        {
            InitializeComponent();
           
        }



        private void btnBestand_Click(object sender, EventArgs e)
        {
                OpenFileDialog Bestand = new OpenFileDialog();
                DialogResult result = Bestand.ShowDialog();
                if (result == DialogResult.OK)
                { txtBestand.Text = Bestand.FileName; }
                {
                    try
                    {
                        WebClient WBClient = new WebClient();
                        WBClient.UploadFileCompleted += new UploadFileCompletedEventHandler(CheckResultaat);
                        WBClient.UploadFileAsync(new Uri("https://www.pscan.xyz/api.php"), "POST", txtBestand.Text);
                        while (WBClient.IsBusy) { Application.DoEvents(); }
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }

            } 
                   
        private void CheckResultaat(object sender, System.Net.UploadFileCompletedEventArgs e) 
        {
            try
            {
                string Uitkomst = System.Text.Encoding.UTF8.GetString(e.Result);
                lvScan.Items.Clear();

                    string[] AVDelimiter = new string[] { "[NextAV]" }; 
                    string[] AV = Uitkomst.Split(AVDelimiter, StringSplitOptions.RemoveEmptyEntries); 
                    string[] Delimiter1 = new string[] { "[ResultDetails]" }; 
                    string[] ScanDetails = Uitkomst.Split(Delimiter1, StringSplitOptions.RemoveEmptyEntries); 
                    string[] Links = new string[] { "[Details]" }; 
                    string[] lijstje = ScanDetails[1].Split(Links, StringSplitOptions.RemoveEmptyEntries); 
                    lblUitkomst.Text = lijstje[4]; 
                    lblLink.Text = lijstje[5]; 
                    int processed = 0; 
                    foreach (var i in AV) 
                    {
                        if (++processed == 36) break;
                        string[] fa = new string[] { "[]Result[]" };
                        string[] fr = i.Split(fa, StringSplitOptions.RemoveEmptyEntries);
                        ListViewItem x = new ListViewItem(fr[0]);
                        x.SubItems.Add(fr[1]);
                        if (fr[1] == "OK")
                        { x.ForeColor = Color.ForestGreen; }
                        else
                        { x.ForeColor = Color.Red; }
                        lvScan.Items.Add(x);                
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            

            }

        private void btnSluit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
