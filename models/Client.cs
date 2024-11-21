using System;
using System.Collections.Generic;

namespace TentBookingManagement.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public int? BookingId { get; set; }

    public DateTime ClientBookingDate { get; set; }

    public DateTime ClientReturnDate { get; set; }

    public string HomeAddress { get; set; } = null!;

    public string TentFunctionAddress { get; set; } = null!;

    public string Contact1 { get; set; } = null!;

    public string? Contact2 { get; set; }

    public decimal Price { get; set; }

    public string? ClientStatus { get; set; }

    public int ClientStatusId { get; set; }

    public string FunctionName { get; set; } = null!;

    public virtual Booking? Booking { get; set; }
}
