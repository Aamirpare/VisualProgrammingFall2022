using System;
using VisualProgrammingFall2022.Events;

namespace VisualProgrammingFall2022.OOP.MidtermSolution
{
    /*
     04 	The following code is the implementation of delegates and events. 
            The VideoTanscoder class in this code, raises VideoTanscoded event 
            when its new object is instantiated.
    */


    /*
     * (a)	Create two client services WhatsAppService and EmailService that 
     *      subscribe the event of VideoTanscoder and display the message on 
     *      console “Video Transcoded” when notification is received. 													
     *                                                                 (5 Marks)
    */

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

    /*
     * (b)	Write EventExecuteDemo program that demonstrate the use of the VideoTranscoder 
     *      as a publisher and two client services as subscriber to complete the video transcoding 
     *      process using events and delegates in C#. This mechanism in real world is referred to as 
     *      publisher-subscriber pattern and the .Net event pattern is based on the same mechanism.
     *                                                                                  (5 Marks)
    */

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
