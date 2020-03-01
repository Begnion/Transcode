namespace Transcode
{
    internal class Video
    {
        public string Path { get; set; }
        public string Format { get; set; }
        public long Size { get; set; }
        public int Duration { get; set; }
        public int Bitrate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Aspectratio { get; set; }
        public double Framerate { get; set; }

        public string AudioChannels { get; set; }
        public string AudioCodec { get; set; }
        public int AudioRate { get; set; }
        public int AudioSampleRate { get; set; }
    }
}
