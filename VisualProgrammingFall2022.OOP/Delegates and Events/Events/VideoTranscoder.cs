/*
 * Events in C#
*/

using System;
using System.Threading;

namespace VisualProgrammingFall2022.Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
        public int Duration { get; set; }
    }

    //Publisher
    public class VideoTranscoder
    {
        //Events are based on delegates
        //First a delegate must be declared
        //public delegate void TranscodeHandler(object sender, EventArgs args);

        //Create event based on the delegate
        //public event TranscodeHandler VideoTranscoded;

        public event EventHandler<VideoEventArgs> VideoTranscoded;
        public void TransCode(Video video)
        {
            Console.WriteLine("Video Transcoding....");
            Thread.Sleep(3000);
            OnVideoUploaded(video);
        }
        
        //The proper way of raising events
        protected virtual void OnVideoUploaded(Video video)
        {
            //if (VideoTranscoded != null)
            //{
            //    VideoTranscoded(null, EventArgs.Empty);
            //}
            VideoTranscoded?.Invoke(this, new VideoEventArgs { Video = video, Duration = 45});
        }
    }
}
