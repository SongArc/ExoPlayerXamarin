namespace Com.Google.Android.Exoplayer.Chunk
{
    public partial class InitializationChunk
    {
        public void SetDrmInitData(Com.Google.Android.Exoplayer.Drm.DrmInitData data)
        {
            this.DrmInitData = data;
        }

        public void SetSeekMap(Com.Google.Android.Exoplayer.Extractor.ISeekMap seekMap)
        {
            this.SeekMap = seekMap;
        }

        public void SetFormat(Com.Google.Android.Exoplayer.MediaFormat format)
        {
            this.Format = format;
        }
    }
}