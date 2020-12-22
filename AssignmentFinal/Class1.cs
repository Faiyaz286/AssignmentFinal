using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFinal
{
    public class Class1
    {
        private int id;
        private string eventName;
        private string eventDescription;
        private byte[] image;
        private string priority;
        private string modificationDate;
        private User user;



        public Class1(int id, string eventName, string eventDescription, byte[] image, string priority, string modificationDate, User user)
        {
            this.id = id;
            this.EventName = eventName;
            this.EventDescription = eventDescription;
            this.Image = image;
            this.Priority = priority;
            this.ModificationDate = modificationDate;
            this.user = user;
        }



        public int Id { get => id; set => id = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string EventDescription { get => eventDescription; set => eventDescription = value; }
        public byte[] Image { get => image; set => image = value; }
        public string Priority { get => priority; set => priority = value; }
        public string ModificationDate { get => modificationDate; set => modificationDate = value; }
        public int UserID { get => user.ID; }
    }
}
