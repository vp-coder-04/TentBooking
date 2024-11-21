using System;
using System.Collections.Generic;

namespace TentBookingManagement.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int? ProductId { get; set; }

    public int Quantity { get; set; }

    public string Pstatus { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }

    public DateTime? InventoryDateOn { get; set; }

    public string? Notes { get; set; }

    public virtual Product? Product { get; set; }
}
