using System;
using modul8.Shared;

namespace modul8.Server.Repositories
{
    public class ShoppingRepositoryInMemory : IShoppingRepository
    {
        private List<ShoppingItem> mProducts = new()
    {
        new ShoppingItem { Id = 1, Name = "bananer", Price = 12, Done = true },
        new ShoppingItem { Id = 2, Name = "Æbler", Price = 14, Done = false }
    };

        private int nextId = 3;  // Initialiseres med 3, da de to første ID'er allerede er brugt duh

        public void AddItem(ShoppingItem item)
        {
            item.Id = nextId++;
            mProducts.Add(item);
        }

        public void DeleteById(int id)
        {
            var itemToRemove = mProducts.FirstOrDefault(p => p.Id == id);
            if (itemToRemove != null)
            {
                mProducts.Remove(itemToRemove);
            }
        }

        // Opgave 3: Delete
        public void DeleteByItem(ShoppingItem item)
        {
            var toDelete = mProducts.FirstOrDefault(p => p.Id == item.Id);
            if (toDelete != null)
            {
                mProducts.Remove(toDelete);
            }
        }

        public ShoppingItem[] GetAll() => mProducts.ToArray();

    }
}