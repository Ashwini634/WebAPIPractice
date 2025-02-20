using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIPractice.Models;

public partial class EmpTable
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

    public string EmpType { get; set; } = null!;

    public string Languages { get; set; } = null!;
}
