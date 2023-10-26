using modul08.Shared;

namespace modul08
{
    public interface IShoppingRepository
    {
        void AddItem(ShoppingItem item);
        ShoppingItem[] GetAll();

        void DeleteById(int id);
        void UpdateItem(ShoppingItem item);
    }
}