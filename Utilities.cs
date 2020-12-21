using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SPZLab6Var1
{
    public static class Utilities
    {
        public static T GetRandomElement<T>(this List<T> source) => source[new Random().Next(0, source.Count)];

        public static string SerializeToXML<T>(T source)
        {
            using var stringWriter = new StringWriter();
            new XmlSerializer(typeof(T)).Serialize(stringWriter, source);
            return stringWriter.ToString();
        }

        public static T DeserializeFromXML<T>(string source)
        {
            using var stringReader = new StringReader(source);
            return (T)new XmlSerializer(typeof(T)).Deserialize(stringReader);
        }
    }
}

