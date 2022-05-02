/*  This file is part of PathfinderList.

 *  PathfinderList is free software: you can redistribute it and/or modify it under the terms 
    of the GNU General Public License as published by the Free Software Foundation, 
    either version 3 of the License, or (at your option) any later version.

 *  PathfinderList is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
    without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR 
    PURPOSE. See the GNU General Public License for more details.

 *  You should have received a copy of the GNU General Public License along with Foobar. 
    If not, see <https://www.gnu.org/licenses/>. */

using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace DiceRoll.Control
{
    public class Discord
    {
        private string Color;
        private string Username;

        private WebRequest Request;

        public Discord(string username, string webhook, string color)
        {
            Color = color;
            Username = username;

            Request = (HttpWebRequest)WebRequest.Create(webhook);
            Request.ContentType = "application/json";
            Request.Method = "POST";
        }

        public void SendMessage(string title, string description)
        {
            using (var streamWriter = new StreamWriter(Request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(new { username = Username, embeds = new[] { new { title = title, description = description,  color = Color } } });

                streamWriter.Write(json);
            }

            var response = Request.GetResponse();
        }
    }
}
