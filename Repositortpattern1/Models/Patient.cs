namespace Repositortpattern1.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string Age { get; set; }
        public string? Address { get; set; }
        public string? PatientType { get; set; }
        public string? bednum { get; set; }=string.Empty;
        public string? diagnosis { get; set; } = string.Empty;

    }
}
