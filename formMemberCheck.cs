using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mshtml;

namespace QslBureauCheck
{
    public partial class formMemberCheck : Form
    {
        bool m_fDocumentComplete;

        public formMemberCheck()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            m_fDocumentComplete = true;
        }
/*
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            int i;
            StringBuilder sb = new StringBuilder();

            string[] callarray = textBox1.Text.Split(',');

            TJarlMemberInfoList list = new TJarlMemberInfoList();

            for (i = 0; i < callarray.Length; i++) {
                list.Add(new TJarlMemberInfo(callarray[i], false, false));
            }

            QueryMemberInfo(list);

            for (i = 0; i < list.Count; i++) {
                sb.Append(list[i].Callsign + " " + list[i].Transfer + " " + list[i].JarlMember + "\r\n");
            }

            textBox2.Text = sb.ToString();
        }
*/

        public int QueryMemberInfo(TJarlMemberInfoList list)
        {
            IHTMLDocument2 Doc2;
            IHTMLDocument3 Doc3;
            IHTMLInputElement element;
            IHTMLElement ele1;
            IHTMLElement ele2;
            int i;
            string strCallsign;
            TJarlMemberInfo O;
            string strResult;

            strCallsign = "";
            for (i = 0; i < list.Count; i++) {
                strCallsign = strCallsign + list[i].Callsign + " ";
            }
            strCallsign = strCallsign.Trim();

            m_fDocumentComplete = false;
            webBrowser1.Navigate("https://www.jarl.com/Page/Search/MemberSearch.aspx?Language=Jp");

            while ((webBrowser1.ReadyState < WebBrowserReadyState.Complete) || (webBrowser1.IsBusy) || (m_fDocumentComplete == false)) {
                Application.DoEvents();
            }

            Doc3 = (IHTMLDocument3)webBrowser1.Document.DomDocument;

            Doc3.getElementById("txtCallSign").innerText = strCallsign;

            Doc2 = (IHTMLDocument2)webBrowser1.Document.DomDocument;

//            element = (IHTMLInputElement)Doc2.all.item("btnSearch", 0);
            element = (IHTMLInputElement)Doc3.getElementById("btnSearch");

            m_fDocumentComplete = false;
            ((DispHTMLButtonElement)element).click();

            while ((webBrowser1.ReadyState < WebBrowserReadyState.Complete) || (webBrowser1.IsBusy) || (m_fDocumentComplete == false)) {
                Application.DoEvents();
            }

            Doc3 = (IHTMLDocument3)webBrowser1.Document.DomDocument;

            for (i = 0; i < 20; i++) {
                ele1 = Doc3.getElementById("ListView1_lblCallSign_" + i.ToString());
                if (ele1 == null) {
                    break;
                }

                ele2 = Doc3.getElementById("ListView1_lblResult_" + i.ToString());

                O = list.ObjectOf(ele1.innerText);
                if (O == null) {
                    continue;
                }

                strResult = ele2.innerText;

                if (strResult.IndexOf("○") >= 0) {
                    O.JarlMember = true;
                }

                if (strResult.IndexOf("Yes") >= 0) {
                    O.Transfer = true;
                }
            }

            return 0;
        }
    }
}
