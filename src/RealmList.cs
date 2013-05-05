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

namespace RealmChanger
{
    // manages all the realmlists
    public static class RealmList
    {
        public static Dictionary<String, String> List
        {
            get
            {
                return _realmList;
            }
        }

        public static bool IsEmpty()
        {
            return _realmList.Count == 0;
        }

        // returns realmname
        public static String GetRealmAddress(String realmName)
        {
            return _realmList[realmName];
        }
        // returns realmaddress
        public static String GetRealmName(String realmAddress)
        {
            foreach (KeyValuePair<String, String> pair in _realmList)
                if (pair.Value == realmAddress)
                    return pair.Key;
            return String.Empty;
        }

        // adds a realmlist to the container
        public static void AddRealm(String realmName, String realmAddress, bool save = true)
        {
            _realmList.Add(realmName, realmAddress);
            if (save)
                Save();
        }
        public static void ModifyRealmName(String oldRealmName, String newRealmName)
        {
            String realmAddress = _realmList[oldRealmName];
            DeleteRealm(oldRealmName);
            AddRealm(newRealmName, realmAddress);
            Save();
        }
        public static void ModifyRealmAddress(String realmName, String newRealmAddress)
        {
            String old = _realmList[realmName];
            _realmList[realmName] = newRealmAddress;
            Save();
        }
        // deletes a realmlist from the container and modifies the XML
        public static void DeleteRealm(String realmName)
        {
            _realmList.Remove(realmName);
            Save();
        }

        public static bool IsRealmNameExists(String realmName, String except)
        {
            if (except == String.Empty)
                return _realmList.ContainsKey(realmName);
            else
            {
                foreach (String s in _realmList.Keys)
                    if (s != except && s == realmName)
                        return true;
                return false;
            }
        }
        public static bool IsRealmAddressExists(String realmAddress, String except)
        {
            if (except == String.Empty)
                return _realmList.ContainsValue(realmAddress);
            else
            {
                foreach (String s in _realmList.Values)
                    if (s != except && s == realmAddress)
                        return true;
                return false;
            }
        }

        // dumps the data to the XML
        public static void Save()
        {
            XMLDataManager.SaveData();
        }

        private static Dictionary<String /* realmName */, String /* realmAddress */> _realmList = new Dictionary<String, String>();
    }
}
