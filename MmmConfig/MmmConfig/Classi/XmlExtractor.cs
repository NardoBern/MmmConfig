using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace MmmConfig
{
    class XmlExtractor
    {
        #region Variable declarations
        private XmlReader xmlReader;
        #endregion

        public void readXml(string strFilePath, EventLogger @eventLogger)
        {
            xmlReader = XmlReader.Create(strFilePath);
            int _i = -1;
            while (xmlReader.Read())
            {
                if (xmlReader.IsStartElement())
                {
                    if (xmlReader.Name.ToString() == "ID")
                    {
                        _i = _i + 1;
                        @eventLogger.events[_i].uiEventId = Convert.ToUInt32(xmlReader.ReadElementContentAsString());
                        @eventLogger.events[_i].strTimeStamp = xmlReader.ReadElementContentAsString();
                        

                    }
                }
            }
        }
    }
}
