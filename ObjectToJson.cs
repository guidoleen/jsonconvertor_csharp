using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonObjectConvertor
{
    public class ObjectToJson: IObjectJson
    {
        private Object obj;

        public ObjectToJson(Object _obj)
        {
            this.obj = _obj;
        }

        public String setToJsonString()
        {
            string output = JsonConvert.SerializeObject(this.obj, Formatting.Indented).ToString();
            return output;
        }
    }
}
