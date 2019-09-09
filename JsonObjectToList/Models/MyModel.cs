using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonObjectToList.Models
{
    public class MyModel
    {
        public List<KeyValuePair> KeyValuePairs { get; set; }
    }

    public class KeyValuePair
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}