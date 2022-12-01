using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TestimonyCS.Models
{
    public class DB
    {
        static List<Rootobject> items;
        public static List<Rootobject> GetDB()
        {
            //converst Json file to c# object
            using (StreamReader r = new StreamReader(@"C:\Users\User\Desktop\אלישבע\הסרטות\YadVashemProject\TestimonyCS\TestimonyCS\Models\testimony.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Rootobject>>(json);
            }
            return items;
        }        
    }
      
}