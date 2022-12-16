using System;

namespace VisualProgrammingFall2022.Events
{
    public class Video
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
    }
}
