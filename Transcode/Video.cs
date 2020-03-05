using System;
using System.Reflection;
using System.Xml.Serialization;

namespace Transcode
{
    [Serializable]
    [SelectNonSerializ(new string[]{ "Path", "Format" } )]
    public class Video
    {
        public string Path { get; set; }
        [XmlIgnore]
        public string Format { get; set; }
        [XmlIgnore]
        public long Size { get; set; }
        [XmlIgnore]
        public int Duration { get; set; }
        
        public int Bitrate { get; set; }
        [MyXmlIgnore]
        public int Width { get; set; }
        [MyXmlIgnore]
        public int Height { get; set; }

        public string Aspectratio { get; set; }
        
        public double Framerate { get; set; }

        
        public string AudioChannels { get; set; }
        
        public string AudioCodec { get; set; }
        
        public int AudioRate { get; set; }
        
        public int AudioSampleRate { get; set; }

    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MyXmlIgnoreAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class)]
    public class SelectNonSerializAttribute : Attribute
    {
        public string[] V;
        public SelectNonSerializAttribute(string[] v)
        {
            V = v;
        }
    }
}
