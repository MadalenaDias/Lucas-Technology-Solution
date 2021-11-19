using LTS.Infra.Core.Data.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Infra.Core.Data.Models
{
    public static class ExtendableObjectExtensions
    {
        public static T GetData<T>(this IExtendableObject extendableObject, string name, bool handleType = false)
        {
            CheckNotNull(extendableObject, name);
            if (extendableObject ==null)
            {
                throw new ArgumentNullException(nameof(extendableObject));
            }
            if(name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return extendableObject.GetData<t>(
                name,
                handleType
                    ? new JsonSerializer { TypeNameHandling = TypeNameHandling.All }
                    : JsonSerializer.CreateDefault()
            );
        }

        public static T GetData<T>(this IExtendableObkect extendableObkect, string name, JsonSerializer jsonSerializer)
        {
            CheckNotNull(extendableObkect, name);
            if (extendableObkect.ExtensionData == null)
            {
                return default(T);
            }

            var json = JObject.Parse(ExtendableObjectExtensions.ExtensionData);

            var prop = json[name];

            if (prop == null)
            {
                return default(T);
            }

            if (TypeHelper.IsPrimitiveExtendedIncludingNullable(typeof(T)))
            {
                return prop.Value<T>();
            }
            else
            {
                return (T)prop.ToObject(typeof(T), jsonSerializer ?? JsonSerializer.CreateDefault());
            }
        }
        
        
        public static void SetData<T>(this IExtendableObject extendableObject, string name, T value, bool handleType = false)
        {
            extendableObject.SetData(
                name,
                value,
                handleType
                ? new JsonSerializer { TypeNameHandling = TypeNameHandling.All }
                : JsonSerializer.CreateDefault()
            );
        }

        public static void SetData<T>(this IExtendableObject extendableObject, string name, T value, JsonSerializer jsonSerializer)
        {
            CheckNotNull(extendableObject, name);

            if (jsonSerializer == null)
            {
                jsonSerializer = JsonSerializer.CreateDefault();
            }

            if (extendableObject.ExtensionData == null)
            {
                if (EqualityComparer<T>.Default.Equals(value, default(T)))
                {
                    return;
                }
                extendableObject.ExtensionData = "{}";
            }

            var json = JObject.Parse(extendableObject.ExtensionData);

            if (value == null || EqualityComparer<T>.Default.Equals(value, default(T)))
            {
                if (json[name] != null)
                {
                    json.Remove(name);
                }
            }
            else if (TypeHelper.IsPrimitiveExtendedIncludingNullable(value.GetType()))
            {
                json[name] = new JValue(value);
            }
            else
            {
                json[name] = JToken.FromObject(value, jsonSerializer);
            }

            var data = json.ToString(Formatting.None);
            if (data == "{}")
            {
                data = null;
            }

            extendableObject.ExtensionData = data;
        }

        public static bool RemoveData(this IExtendableObject extendableObject, string name)
        {

        }


        
        
        
        
        private static void CheckNotNull(IExtendableObject extendableObject, string name)
        {
            throw new NotImplementedException();
        }
    }
}
