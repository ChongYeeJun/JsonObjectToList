using JsonObjectToList.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;

namespace JsonObjectToList.ModelBinder
{
    public class JsonToListModelBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            var keyValuePairs = new List<KeyValuePair>();
            var inputBody = actionContext.Request.Content.ReadAsStringAsync().Result;
            var strPairs = inputBody.Split(',');

            var jsonObject = (JContainer)JsonConvert.DeserializeObject(inputBody);
            
            foreach(var strPair in jsonObject)
            {
                var jProperty = (JProperty) strPair;
                var keyValuePair = new KeyValuePair
                {
                    Key = jProperty.Name,
                    Value = jProperty.Value.ToString()
                };

                keyValuePairs.Add(keyValuePair);
            }

            bindingContext.Model = new MyModel
            {
                KeyValuePairs = keyValuePairs
            };

            return true;
        }
    }
}