using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QslBureauCheck
{
    public class TJarlMemberInfo : Object
    {
        private string m_strCallsign;
        private bool m_fTransfer;
        private bool m_fJarlMember;
        private string m_source;

        public TJarlMemberInfo()
        {
            m_strCallsign = "";
            m_fTransfer = false;
            m_fJarlMember = false;
            m_source = "";
        }

        public TJarlMemberInfo(string strCallsign)
        {
            m_strCallsign = strCallsign;
            m_fTransfer = false;
            m_fJarlMember = false;
            m_source = "";
        }

        public TJarlMemberInfo(string strCallsign, string source)
        {
            m_strCallsign = strCallsign;
            m_fTransfer = false;
            m_fJarlMember = false;
            m_source = source;
        }

        public TJarlMemberInfo(string strCallsign, bool fTransfer, bool fJarlMember)
        {
            m_strCallsign = strCallsign;
            m_fTransfer = fTransfer;
            m_fJarlMember = fJarlMember;
            m_source = "";
        }

        public string Callsign
        {
            get { return m_strCallsign; }
            set { m_strCallsign = value; }
        }

        public bool Transfer
        {
            get { return m_fTransfer; }
            set { m_fTransfer = value; }
        }

        public bool JarlMember
        {
            get { return m_fJarlMember; }
            set { m_fJarlMember = value; }
        }

        public string Source
        {
            get { return m_source; }
            set { m_source = value; }
        }
    }

    public class TJarlMemberInfoList : List<TJarlMemberInfo>
    {
        public TJarlMemberInfo ObjectOf(string strCallsign)
        {
            int i;

            for (i = 0; i < Count; i++) {
                if (this[i].Callsign == strCallsign) {
                    return (this[i]);
                }
            }

            return null;
        }

        public int IndexOf(string strCallsign)
        {
            int i;

            for (i = 0; i < Count; i++) {
                if (this[i].Callsign == strCallsign) {
                    return (i);
                }
            }

            return (-1);
        }
    }
}
