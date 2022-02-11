namespace Examen.Application.ViewModels
{
    public class PersonViewModel : BaseViewModel
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public int? Document { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Gender { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
