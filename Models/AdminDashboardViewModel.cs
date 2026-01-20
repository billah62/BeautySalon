using System.Collections.Generic;

namespace BeautySalon.Models
{
    public class AdminDashboardViewModel
    {
        public List<ApplicationUser> Users { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Service> Services { get; set; }
    }
}