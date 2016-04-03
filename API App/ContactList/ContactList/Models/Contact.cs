
namespace ContactList.Models
{
    public class Contact
    {
        /// <summary>
        /// The ID of the contact.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Contact's full name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Contact's email address. 
        /// </summary>
        public string EmailAddress { get; set; }
    }
}