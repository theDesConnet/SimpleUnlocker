﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace SU.Classes
{
    internal static class JSONHelper
    {
        /// <summary>
        /// Serializes an object to the respectable JSON string.
        /// </summary>
        public static string Serialize<T>(T o)
        {
            var s = new DataContractJsonSerializer(typeof(T));
            using (var ms = new MemoryStream())
            {
                s.WriteObject(ms, o);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        /// <summary>
        /// Deserializes a JSON string to the specified object.
        /// </summary>
        public static T Deserialize<T>(string json)
        {
            var s = new DataContractJsonSerializer(typeof(T));
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                return (T)s.ReadObject(ms);
            }
        }

        /// <summary>
        /// Deserializes a JSON stream to the specified object.
        /// </summary>
        public static T Deserialize<T>(Stream stream)
        {
            var s = new DataContractJsonSerializer(typeof(T));
            return (T)s.ReadObject(stream);
        }
    }
}
