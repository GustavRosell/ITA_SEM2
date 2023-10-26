using modul14.Shared;

namespace modul14.Server.Repositories
{
    public interface IShoppingRepository
    {
        void AddItem(ShoppingItem item);

        ShoppingItem[] GetAll();

        void DeleteById(int id);

        void UpdateItem(ShoppingItem item);
    }
}