namespace ECommerce.WebApp.Models.View;

public class CategoryView: BaseDto
{
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string LongName { get; set; }
    public string Description { get; set; }
}
