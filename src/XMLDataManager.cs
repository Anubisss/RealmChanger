/*
 * This file is part of RealmChanger.
 *
 * RealmChanger is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.

 * RealmChanger is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
 * along with RealmChanger.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Xml;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace RealmChanger
{
    public static class XMLDataManager
    {
        // dump all the data to XML
        public static void SaveData()
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter("data.xml", Encoding.UTF8);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("I don't have permission to write in file: data.xml", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            writer.Formatting = Formatting.Indented;
            writer.Indentation = 1; // one tab Indentation
            writer.IndentChar = '\t';
            writer.WriteStartDocument();
            writer.WriteComment(" RealmChanger by anuka - http://github.com/Anubisss "); // just comment the author
            writer.WriteStartElement("RealmChangerData"); // root element

            writer.WriteStartElement("RealmListData"); // list of realmlists
            foreach (KeyValuePair<String, String> pair in RealmList.List)
            {
                writer.WriteStartElement("RealmList");
                writer.WriteElementString("RealmListName", pair.Key);
                writer.WriteElementString("RealmListAddress", pair.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteStartElement("WTFListData"); // list of WTFlists
            foreach (KeyValuePair<String, String> pair in WtfList.List)
            {
                writer.WriteStartElement("WTF");
                writer.WriteElementString("WTFName", pair.Key);
                writer.WriteElementString("WTFLocation", pair.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        // load all the data from XML
        public static void LoadData()
        {
            XmlDocument data = new XmlDocument();
            try
            {
                data.Load("data.xml");
            }
            catch (SystemException ex)
            {
                if (ex is FileNotFoundException || ex is UnauthorizedAccessException)
                    return;
                else
                    throw;
            }

            XmlNodeList realmListNames = data.GetElementsByTagName("RealmListName");
            XmlNodeList realmListAddresses = data.GetElementsByTagName("RealmListAddress");
            XmlNodeList wtfNames = data.GetElementsByTagName("WTFName");
            XmlNodeList wtfLocations = data.GetElementsByTagName("WTFLocation");

            var i = 0;
            foreach (XmlNode node in realmListNames)
                RealmList.AddRealm(node.InnerText, realmListAddresses[i++].InnerText, false);
            i = 0;
            foreach (XmlNode node in wtfNames)
                WtfList.AddWtf(node.InnerText, wtfLocations[i++].InnerText, false);
        }
    }
}
