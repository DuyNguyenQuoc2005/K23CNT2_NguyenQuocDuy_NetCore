using System;
using System.Collections.Generic;

namespace NqdLesson11.Models;

public partial class Category
{
    public int NqdEmpId { get; set; }

    public string? NqdEmpName { get; set; }

    public string? NqdEmpLevel { get; set; }

    public DateOnly? NqdEmpStartDate { get; set; }

    public bool? NqdEmpStatus { get; set; }
}
