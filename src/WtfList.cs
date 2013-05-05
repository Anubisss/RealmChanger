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
using System.Collections.Generic;
using System.IO;

namespace RealmChanger
{
    // manages the WTFs
    public static class WtfList
    {
        public static Dictionary<String, String> List
        {
            get
            {
                return _wtfList;
            }
        }

        public static bool IsEmpty()
        {
            return _wtfList.Count == 0;
        }

        public static String GetWtfLocation(String wtfName)
        {
            return _wtfList[wtfName];
        }

        // adds a new WTF to the container
        public static void AddWtf(String wtfName, String wtfLocation, bool save = true)
        {
            _wtfList.Add(wtfName, wtfLocation);
            if (save)
                Save();
        }
        public static void ModifyWtfName(String oldWtfName, String newWtfName)
        {
            String wtfLocation = _wtfList[oldWtfName];
            DeleteWtf(oldWtfName);
            AddWtf(newWtfName, wtfLocation);
            Save();
        }
        public static void ModifyWtfLocation(String wtfName, String newWtfLocation)
        {
            String old = _wtfList[wtfName];
            _wtfList[wtfName] = newWtfLocation;
            Save();
        }
        // deletes a WTF from the container and writes the change into the XML
        public static void DeleteWtf(String wtfName)
        {
            _wtfList.Remove(wtfName);
            Save();
        }

        public static bool IsWtfNameExists(String wtfName, String except)
        {
            if (except == String.Empty)
                return _wtfList.ContainsKey(wtfName);
            else
            {
                foreach (String s in _wtfList.Keys)
                    if (s != except && s == wtfName)
                        return true;
                return false;
            }
        }
        public static bool IsWtfLocationExists(String wtfLocation, String except)
        {
            if (except == String.Empty)
                return _wtfList.ContainsValue(wtfLocation);
            else
            {
                foreach (String s in _wtfList.Values)
                    if (s != except && s == wtfLocation)
                        return true;
                return false;
            }
        }

        // tries the get the location of the Wow.exe
        // location finding based on the location of the realmlist.wtf
        // this file is in different places in different expansions
        // TODO: more comments in the method :)
        public static String GetClientLocation(String wtfLocation)
        {
            String clientPath;
            Int32 backSlashPos;

            backSlashPos = wtfLocation.LastIndexOf(@"\");
            if (backSlashPos == -1)
                return String.Empty;
            clientPath = wtfLocation.Substring(0, backSlashPos + 1);
            clientPath += "Wow.exe";
            if (File.Exists(clientPath))
                return clientPath;

            backSlashPos = wtfLocation.LastIndexOf(@"\");
            if (backSlashPos == -1)
                return String.Empty;
            clientPath = wtfLocation.Substring(0, backSlashPos);
            backSlashPos = clientPath.LastIndexOf(@"\");
            if (backSlashPos == -1)
                return String.Empty;
            clientPath = clientPath.Substring(0, backSlashPos);
            backSlashPos = clientPath.LastIndexOf(@"\");
            if (backSlashPos == -1)
                return String.Empty;
            clientPath = clientPath.Substring(0, backSlashPos + 1);
            clientPath += "Wow.exe";
            if (File.Exists(clientPath))
                return clientPath;

            return String.Empty;
        }

        // tries to read the realmaddress from a specif WTF file
        public static String GetRealmAddress(String wtfLocation)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(wtfLocation);
            }
            catch (FileNotFoundException)
            {
                return String.Empty;
            }
            String firstLine = reader.ReadLine();
            reader.Close();

            if (firstLine.IndexOf("set realmlist ") != 0)
                return String.Empty;
            else
            {
                String possibleRealmAddress = firstLine.Substring(14);
                if (possibleRealmAddress.Contains(" "))
                    return possibleRealmAddress.Substring(0, possibleRealmAddress.IndexOf(" "));
                else
                    return possibleRealmAddress;
            }
        }

        // dumps all the WTF data into the XML
        public static void Save()
        {
            XMLDataManager.SaveData();
        }

        private static Dictionary<String /* Wtf name */, String /* Wtf location */> _wtfList = new Dictionary<String, String>();
    }
}
