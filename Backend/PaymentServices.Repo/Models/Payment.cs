using System.ComponentModel.DataAnnotations;

namespace PaymentServices.Repo.Models
{
    public class Payment
    {
        [Key]
        public int PersonId { get; set; }
        public string username { get; set; }
        public string email { get; set; }
    }

    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public required int adminlevel { get; set; }
    }
}
