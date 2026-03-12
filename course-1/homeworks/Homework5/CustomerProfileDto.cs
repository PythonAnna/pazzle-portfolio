using System;
namespace Homework5.Dtos
{
    public class CustomerProfileDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string CardNumber { get; set; }
    }
}
