using System;
using System.Collections.Generic;

namespace TentBookingManagement.Models;

public partial class Design
{
    public int DesignId { get; set; }

    public string DesignName { get; set; } = null!;

    public string? DesignDescription { get; set; }

    public string DesignImageUrl { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; } = new List<Booking>();
}
