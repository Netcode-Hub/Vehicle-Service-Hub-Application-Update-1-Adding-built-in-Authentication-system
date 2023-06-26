

namespace BlazorServer.CarService.SharedModels.ViewModels;

public class GetServiceViewModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
}
