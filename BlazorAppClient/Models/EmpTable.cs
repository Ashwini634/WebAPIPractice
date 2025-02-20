using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppClient.Models;

public partial class EmpTable
{
    [Range(1, int.MaxValue, ErrorMessage = "ID must be greater than 0")]
    public int Id { get; set; }


    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = null!;


    [Range(18, int.MaxValue, ErrorMessage = "Age must be greater than or equal to 18")]
    public int Age { get; set; }


    [Required(ErrorMessage = "Gender is required")]
    public string Gender { get; set; } = null!;


    [Required(ErrorMessage = "Employee Type is required")]
    public string EmpType { get; set; } = null!;


  
    public string Languages { get; set; } = null!;
}
