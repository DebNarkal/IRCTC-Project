using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LastRecord
{
    public static class SaveRecord
    {
        public static void SaveData(Info record)
        {
            string jsonData = JsonConvert.SerializeObject(record, Formatting.Indented);
            File.WriteAllText("LastRecord.json", jsonData);
            
        }
    }
}
