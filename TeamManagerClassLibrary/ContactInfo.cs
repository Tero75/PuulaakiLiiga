using System;
namespace TeamManagerClassLibrary
{
    public class ContactInfo
    {
        private int ContactID;
        public string ContactName;
        public string PhoneNumber;
        public string Email;

        public int contactID
        {
            get { return ContactID; }
            set { ContactID = value; }
            
        }

        public ContactInfo()
        {
        }
    }
}
