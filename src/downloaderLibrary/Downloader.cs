using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using repoBaseLib;
using System.Net;
namespace downloaderLibrary
{
    public class DataCollector
    {
        public string Downloader(string url)
        {
            var client = new WebClient();
            return client.DownloadString(url);
        }
    }
    public class DataHandler {
        public string Presenter(List<DataPacket> presenterData)
        {
            var returnData = "";
            foreach(DataPacket stuff in presenterData){
                returnData += stuff.name + Environment.NewLine;
                returnData += stuff.description + Environment.NewLine;
                returnData += stuff.version + Environment.NewLine;
                returnData += stuff.launchString + Environment.NewLine;
                returnData += stuff.versionCandidateName + Environment.NewLine;
                returnData += stuff.releaseDate.ToString() + Environment.NewLine;
                returnData += stuff.repoURL + Environment.NewLine;
                returnData += stuff.fileURL + Environment.NewLine;
                returnData += Environment.NewLine;
            }
            return returnData;
        }

        public List<DataPacket> Extractor(string jsonData)
        {
            return JsonConvert.DeserializeObject<List<DataPacket>>(jsonData);
        }
    }

}