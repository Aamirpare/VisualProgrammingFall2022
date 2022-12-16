/*
 * Events in C#
*/

using System;

namespace VisualProgrammingFall2022.Events
{

    //Subscriber 1
    public class EmailService
    {
        public void OnVideoTranscoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"Email Service: Id : {e.Video.Id}, Title: {e.Video.Title}, Duration: {e.Duration}");
        }
    }

    //Subscriber 2
    public class WhatsAppService
    {
        public void OnVideoTranscoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"WahtsApp Service: {e.Video.Id}, Title: {e.Video.Title}, Duration: {e.Duration}");
        }
    }
    public static class EventExecuteDemo
    {

        public static void Main(string[] args)
        {
            Video video = new Video { Title = "Lecture-1 - Delegates and Events" };
            
            VideoTranscoder transcoder = new VideoTranscoder();
            
            EmailService emailService = new EmailService();

            WhatsAppService whatsAppService = new WhatsAppService();
            
            transcoder.VideoTranscoded += emailService.OnVideoTranscoded;
            transcoder.VideoTranscoded += whatsAppService.OnVideoTranscoded;
            
            transcoder.TransCode(video);

            Console.ReadKey();
        }
    }
}
