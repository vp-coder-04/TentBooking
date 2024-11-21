using System;
using System.Collections.Generic;

namespace TentBookingManagement.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Category { get; set; } = null!;

    public DateTime BuyDate { get; set; }

    public int Stock { get; set; }

    public bool AvailableStatus { get; set; }

    public string Quality { get; set; } = null!;

    public string? ProductImageUrl { get; set; }

    public string PriceRange { get; set; } = null!;

    public int? Totalstock { get; set; }

    public virtual ICollection<Booking> Bookings { get; } = new List<Booking>();

    public virtual ICollection<Inventory> Inventories { get; } = new List<Inventory>();
}
