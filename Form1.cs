using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace QslBureauCheck
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void buttonLoadFromFIle_Click(object sender, EventArgs e)
        {
            string line;

            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) {
                return;
            }

            textInput.Text = "";

            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            while ((line = sr.ReadLine()) != null)
            {
                textInput.AppendText(line + Environment.NewLine);
            }

            sr.Close();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) {
                return;
            }

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

            for (int i = 0; i < textOutput.Lines.Length; i++)
            {
                sw.WriteLine(textOutput.Lines[i]);
            }

            sw.Close();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            int c;
            int ok, ng, dx, ja;
            string line;
            string callsign;
            TJarlMemberInfoList list = new TJarlMemberInfoList();
            formMemberCheck f = new formMemberCheck();

            this.Enabled = false;

            c = 0;
            list.Clear();

            ok = 0;
            ng = 0;
            dx = 0;
            ja = 0;
            textOutput.Text = "";

            for (int i = 0; i < textInput.Lines.Length; i++)
            {
                line = textInput.Lines[i];
                if (line == "")
                {
                    continue;
                }

                callsign = ExtractCallsign(line.ToUpper());
                if (callsign == "")
                {
                    textOutput.AppendText(line + Environment.NewLine);
                }
                else if(IsDomestic(callsign) == false)
                {
                    textOutput.AppendText(line + Environment.NewLine);
                    dx++;
                }
                else
                {
                    TJarlMemberInfo minfo = new TJarlMemberInfo(callsign, line);
                    list.Add(minfo);
                    c++;
                    ja++;

                    if (c == 20)
                    {
                        f.QueryMemberInfo(list);

                        for (int j = 0; j < list.Count; j++)
                        {
                            if (list[j].Transfer == true)
                            {
                                textOutput.AppendText(list[j].Source + Environment.NewLine);
                                ok++;
                            }
                            else
                            {
                                ng++;
                            }
                        }

                        list.Clear();
                        c = 0;
                    }
                }
            }

            if (c > 0)
            {
                f.QueryMemberInfo(list);

                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Transfer == true)
                    {
                        textOutput.AppendText(list[j].Source + Environment.NewLine);
                        ok++;
                    }
                    else
                    {
                        ng++;
                    }
                }
            }

            this.Enabled = true;

            string s = "JARL会員情報の照会が終わりました。" + Environment.NewLine +
                       "転送可=" + ok.ToString() + " 転送不可=" + ng.ToString() + " / JA局=" + ja.ToString() + " DX局=" + dx.ToString();
            MessageBox.Show(this, s, "JARL Member Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            f.Dispose();
        }

        private string ExtractCallsign(string line)
        {
            int index;
            string callsign;
            string left, right;

            // Cabrillo?
            // https://wwrof.org/cabrillo/
            // https://wwrof.org/cabrillo/cabrillo-qso-data/
            //                              --------info sent------- -------info rcvd--------
            //QSO:  freq mo date       time call          rst exch   call          rst exch   t
            //QSO: ***** ** yyyy-mm-dd nnnn ************* nnn ****** ************* nnn ****** n
            //QSO:  3799 PH 1999-03-06 0711 HC8N           59 700    W1AW           59 CT     0
            //QSO:  3799 PH 1999-03-06 0712 HC8N           59 700    N5KO           59 CA     0

            index = line.IndexOf("QSO:");
            if (index >= 0)
            {
                int n = 0;
                string[] items = new string[20];
                while(true)
                {
                    index = line.IndexOf(" ");
                    if (index == -1)
                    {
                        break;
                    }

                    items[n] = line.Substring(0, index).Trim();
                    line = line.Substring(index + 1).Trim();
                    n++;
                }

                callsign = items[8];

                left = "";
                right = "";
                callsign = SplitCallsign(callsign, ref left, ref right);
                return (callsign);
            }

            // ADIF?
            // 012345678901234567890
            // <CALL:10>JR8PPG/QRP
            index = line.IndexOf("<CALL:");
            if (index >= 0)
            {
                string s = line.Substring(index);
                int index2 = s.IndexOf(">");
                string keta = s.Substring(6, index2 - 6);
                int n = int.Parse(keta);

                callsign = s.Substring(index2 + 1, n);

                left = "";
                right = "";
                callsign = SplitCallsign(callsign, ref left, ref right);
                return (callsign);
            }

            return ("");
        }

        private string SplitCallsign(string callsign, ref string left, ref string right)
        {
            int index;

            index = callsign.IndexOf("/");
            if (index == -1)
            {
                return callsign;
            }

            left = callsign.Substring(0, index);
            right = callsign.Substring(index + 1);

            if (left.Length >= right.Length)
            {
                return (left);
            }
            else
            {
                return (right);
            }
        }

        private bool IsDomestic(string callsign)
        {
            char S1;
            char S2;
            char S3;

            if (callsign == "")
            {
                return (true);
            }

            S1 = callsign[0];
            S2 = callsign[1];
            S3 = callsign[2];

            if (S1 == 'J') {
                if ((S2 >= 'A') && (S2 <= 'S')) {
                    return (true);
                }
            }

            if ((S1 == '7') && (S2 == 'J'))
            {
                return (true);
            }

            if (S1 == '7')
            {
                if (S2 >= 'K' && S2 <= 'N')
                {
                    if (S3 >= '1' && S3 <= '4')
                    {
                        return (true);
                    }
                }
            }

            if (S1 == '8')
            {
                if (S2 >= 'J' && S2 <= 'N')
                {
                    return (true);
                }
            }

            return (false);
        }
    }
}
