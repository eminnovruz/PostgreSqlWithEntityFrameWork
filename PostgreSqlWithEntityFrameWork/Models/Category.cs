namespace PostgreSqlWithEntityFrameWork.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public IEnumerable<Product> Products { get; set;}
}
