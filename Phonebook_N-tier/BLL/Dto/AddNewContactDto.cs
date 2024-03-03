namespace BLL.Dto
{
    public class AddNewContactDto
    {
        public required string Name { get; set; }

        public required string Lastname { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Company { get; set; }

        public required string Description { get; set; }
    }
}
