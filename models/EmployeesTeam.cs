using System;
using System.Collections.Generic;

namespace TentBookingManagement.Models;

public partial class EmployeesTeam
{
    public int TeamId { get; set; }

    public string TeamName { get; set; } = null!;

    public DateTime BookingStartDate { get; set; }

    public DateTime BookingEndDate { get; set; }

    public string BookingAddress { get; set; } = null!;

    public decimal Salary { get; set; }

    public string Etstatus { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; } = new List<Booking>();

    public virtual ICollection<Worker> Workers { get; } = new List<Worker>();
}
