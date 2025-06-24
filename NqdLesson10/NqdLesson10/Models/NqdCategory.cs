using System;
using System.Collections.Generic;

namespace NqdLesson10.Models;

public partial class NqdCategory
{
    public int CateId { get; set; }

    public string? CateName { get; set; }

    public bool? CateStatus { get; set; }
}
