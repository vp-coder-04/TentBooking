using System;
using System.Collections.Generic;

namespace TentBookingManagement.Models;

public partial class Worker
{
    public int WorkerId { get; set; }

    public int? TeamId { get; set; }

    public string WorkerName { get; set; } = null!;

    public DateTime JoiningDate { get; set; }

    public string WorkerAddress { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public decimal Salary { get; set; }

    public string Post { get; set; } = null!;

    public string WorkerStatus { get; set; } = null!;

    public virtual EmployeesTeam? Team { get; set; }
}
