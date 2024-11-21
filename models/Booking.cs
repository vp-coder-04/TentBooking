using System;
using System.Collections.Generic;

namespace TentBookingManagement.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public DateTime BookingDate { get; set; }

    public int? TeamId { get; set; }

    public int? ProductId { get; set; }

    public int? DesignId { get; set; }

    public string FunctionName { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Client> Clients { get; } = new List<Client>();

    public virtual Design? Design { get; set; }

    public virtual Product? Product { get; set; }

    public virtual EmployeesTeam? Team { get; set; }
}
