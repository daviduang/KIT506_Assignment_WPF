using System;

namespace KIT506_Assignment_WPF.Model
{
    public class Publication
    {
        /* Publication's enumatations: type */
        public enum Type { Conference, Journal, Other };

        /* Publication's attributes */
        public string doi { get; set; }
        public string title { get; set; }
        public string authors { get; set; }
        public int year { get; set; }
        public Type type { get; set; }
        public string cite_as { get; set; }
        public DateTime avaliable { get; set; }
    }
}

