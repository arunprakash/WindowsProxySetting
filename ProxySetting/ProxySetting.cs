using System;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProxySetting
{
    public partial class ProxySetting : Form
    {
        public ProxySetting()
        {
            InitializeComponent();
            checkProxy();
        }

        private void checkProxy()
        {
            WebProxy proxy = WebProxy.GetDefaultProxy();

            if (proxy.Address == null)
            {
                txtStatus.Text = "Proxy Disabled";
                colorTxtBox(txtStatus, "bad");
                txtProxyAddress.Text = "";
                txtProxyPort.Text = "";
                txtByPass.Text = "";
            }
            else
            {
                txtStatus.Text = "Proxy Enabled";
                colorTxtBox(txtStatus, "good");
                txtProxyAddress.Text = proxy.Address.ToString().Split('/')[2].Split(':')[0];
                txtProxyPort.Text = proxy.Address.ToString().Split('/')[2].Split(':')[1];
                txtByPass.Text = "";
                foreach (var item in proxy.BypassList.ToArray())
                {
                    string pattern = "[" + Regex.Escape(@"?/\:{},()^(0-9)$-") + "]";

                    var item1 = Regex.Replace(item, pattern, "");
                    txtByPass.AppendText(item1);
                }
            }
        }

        private void btnSetProxy_Click(object sender, EventArgs e)
        {
            if (txtProxyAddressSet.Text.Equals("") || txtProxyAddressSet.Text.Equals("") || txtProxyAddressSet.Text.Equals(""))
            {
                MessageBox.Show("Provide all the mandates!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Proxy.setProxy(txtProxyAddressSet.Text + ":" + txtProxyPortSet.Text, txtByPassSet.Text);
            }

            checkProxy();
        }

        private void btnDisableProxy_Click(object sender, EventArgs e)
        {
            Proxy.disableProxy();
            checkProxy();
        }

        private void txtPopulateDefault_Click(object sender, EventArgs e)
        {
            if (btnPopulateDefault.Text.Equals("Reset"))
            {
                txtProxyAddressSet.Text = "";
                txtProxyPortSet.Text = "";
                txtByPassSet.Text = "";
                btnPopulateDefault.Text = "Populate Default";
            }
            else
            {
                txtProxyAddressSet.Text = "";
                txtProxyPortSet.Text = "";
                txtByPassSet.Text = "";
                btnPopulateDefault.Text = "Reset";
            }
        }

        private void chkProxy_Click(object sender, EventArgs e)
        {
            checkProxy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "netsh.exe";
            p.StartInfo.Arguments = "wlan show interfaces";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            try
            {
                string s = p.StandardOutput.ReadToEnd();
                string s1 = s.Substring(s.IndexOf("SSID"));
                s1 = s1.Substring(s1.IndexOf(":"));
                s1 = s1.Substring(2, s1.IndexOf("\n")).Trim();

                string s2 = s.Substring(s.IndexOf("Signal"));
                s2 = s2.Substring(s2.IndexOf(":"));
                s2 = s2.Substring(2, s2.IndexOf("\n")).Trim();
                s2 = s2.Replace('%', '\0');
                txtConnection.Text = s1;
                if (int.Parse(s2) >= 75)
                {
                    colorTxtBox(txtConnection, "good");
                }
                else if (int.Parse(s2) >= 45)
                {
                    colorTxtBox(txtConnection, "neutral");
                }
                else if (int.Parse(s2) < 45)
                {
                    colorTxtBox(txtConnection, "bad");
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                txtConnection.Text = "Error! Wired May be!";
                colorTxtBox(txtConnection, "bad");
            }
            p.WaitForExit();

        }

        public void colorTxtBox(TextBox txt, string status)
        {
            if (status.Equals("good"))
            {
                txt.BackColor = Color.FromArgb(198, 239, 206);
                txt.ForeColor = Color.FromArgb(0, 97, 0);
            }
            else if (status.Equals("bad"))
            {
                txt.BackColor = Color.FromArgb(255, 199, 206);
                txt.ForeColor = Color.FromArgb(156, 0, 6);
            }
            else if (status.Equals("neutral"))
            {
                txt.BackColor = Color.FromArgb(255, 235, 156);
                txt.ForeColor = Color.FromArgb(156, 101, 0);
            }
            txt.ReadOnly = true;
        }
    }
}
