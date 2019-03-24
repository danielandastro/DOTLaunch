using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace downloaderLibrary
{
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

    public struct DataPacket {
        public string name;
        public string description;
        public string launchString;
        public string version;
        public string versionCandidateName;
        public DateTime releaseDate;
        public string repoURL;
        public string fileURL;
    }
}