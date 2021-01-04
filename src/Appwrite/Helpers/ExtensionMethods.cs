﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Appwrite
{
    public static class ExtensionMethods
    {

        public static string ToJson(this Dictionary<string, object> dict)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter> { new StringEnumConverter() }
            };

            return JsonConvert.SerializeObject(dict, settings);
        }

        public static string ToQueryString(this Dictionary<string, object> parameters)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);

            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (parameter.Value != null)
                {
                    if (parameter.Value is List<object>)
                    {
                        foreach(object entry in (dynamic) parameter.Value) 
                        {
                            query.Add(parameter.Key + "[]", entry.ToString());
                        }
                    } 
                    else 
                    {
                        query.Add(parameter.Key, parameter.Value.ToString());
                    }
                }
            }
            return query.ToString();
        }

    }
}