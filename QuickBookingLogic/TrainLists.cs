using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace QuickBookingLogic
{
    public class TrainLists
    {
        private string postDatas;
        private string dayOfWeek;
        private string uri = "https://www.confirmtkt.com//api/multimodal/getdirecttrainscity?";

        public TrainLists(string _postDatas, string _dayOfWeek)
        {
            // TODO: Complete member initialization
            this.postDatas = _postDatas;
            this.dayOfWeek = _dayOfWeek.Substring(0,3);
        }
        public List<string> trains { get; set; }
        
        public List<string> GetTrains()
        {

            string request = uri + postDatas + "&travelCLass=ZZ&confirmTktStatus=Probable&statusType=0&getAlternates=true&nearestRailwayStation=true&quota=GN";
            
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(request);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            string response;
            using (Stream s = res.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                    response = reader.ReadToEnd();
            }
            JObject trains = JObject.Parse(response);
            JArray trainArray = (JArray)trains["direct"];
            var trainDets = from train in trainArray
                       where train["train"]["DaysOfRun"][dayOfWeek].ToString().Equals("True")
                       select new { trainName = train["train"]["trainName"], trainNo = train["train"]["trainNumber"] }; //train["train"]["trainName"];
            List<string> trainLists = new List<string>();
            foreach(var tr in trainDets)
            {
                trainLists.Add(tr.trainNo + " " + tr.trainName);
            }
            return trainLists;
        }
    }
}
