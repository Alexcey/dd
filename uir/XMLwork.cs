using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace uir
{
    public class XMLwork
    {
        public static string GetConnectionString()
        {
            string cString="";
            if (File.Exists("options.xml"))
            {
                try
                {
                    XmlDocument typedoc = new XmlDocument();
                    string str = (Application.StartupPath + @"\options.xml").ToString();
                    typedoc.Load(Application.StartupPath + @"\options.xml");
                    //Загрузка номера ДЦ
                    XmlNodeList connStr = typedoc.GetElementsByTagName("connection_string");
                    cString = connStr[0].InnerText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла ошибка при чтении файла options.xml, проверьте конфигурацию файла." + ex.ToString());
                }
            }
            else
            {
            }
            return cString;
        }
    }
}
