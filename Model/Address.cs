namespace BlazingPizza;

public class Address
{
    public int Id { get; set; }
    [Required, MinLength(3, ErrorMessage = "Please enter a name more than 3 characters."), MaxLength(100, ErrorMessage = "Please enter a name less than 100 characters.")]
    public string Name { get; set; }
    [Required, MinLength(5, ErrorMessage = "Please enter an address more than 5 characters."), MaxLength(100, ErrorMessage = "Please enter an address less than 100 characters.")]
    public string Line1 { get; set; }
    [MaxLength(100)]
    public string? Line2 { get; set; }
    [Required, MinLength(3, ErrorMessage = "Please enter a city more than 3 characters."), MaxLength(50, ErrorMessage = "Please enter a city less than 50 characters.")]
    public string City { get; set; }
    [Required, MinLength(3, ErrorMessage = "Please enter a region more 3 than letters."), MaxLength(20, ErrorMessage = "Please enter a region less than 20 characters.")]
    public string Region { get; set; }
    [Required, RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Please enter a valid postal code with 5 numbers.")]
    public string PostalCode { get; set; }
}

