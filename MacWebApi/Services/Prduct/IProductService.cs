namespace MacWebApi.Services.Prduct
{
    public interface IProductService
    {
        ICollection<Data.Models.Product> GetProducts();
    }
}
