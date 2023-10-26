using modul8.Shared;

namespace modul8
{
    public interface IShoppingRepository
    {
        void AddItem(ShoppingItem item);
        ShoppingItem[] GetAll();

        void DeleteById(int id);
    }
}