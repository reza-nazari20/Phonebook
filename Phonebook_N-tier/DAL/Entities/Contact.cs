namespace DAL.Entities
{
    public class Contact
    {
        public int ID { get; set; }

        public required string Name { get; set; }

        public required string Lastname { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Company { get; set; }

        public required string Description { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
