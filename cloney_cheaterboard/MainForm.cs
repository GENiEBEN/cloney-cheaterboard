using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btn_PostScore_Click(object sender, EventArgs e)
        {
            String serverKey = "01813cdb29f72e141ec88355f1de6780e6dbf78a";
            String token = "51cfcad289a71a4c46eeae63209ce4fa3a65e3c2";
            String key = box_user.Text.ToString();
            String value = box_coins.Text.ToString();
            String update = "highest";
            String type = "int";
            String tags = box_system.Text.ToLower().ToString();
            String result = "";
            String strPost = "serverKey=" + serverKey + "&token=" + token + "&key=" + key + "&value=" + value + "&update=" + update + "&type=" + type + "&tags=" + tags;

            StreamWriter myWriter = null;

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create("https://api.dotbunny.com/v1/KeyValue/Add");
            objRequest.Method = "POST";
            objRequest.ContentLength = strPost.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";

            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(strPost);
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr =
               new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();

                // Close and clean up the StreamReader
                sr.Close();
            }
            MessageBox.Show(result);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.deusex.uk");
        }
    }
}
