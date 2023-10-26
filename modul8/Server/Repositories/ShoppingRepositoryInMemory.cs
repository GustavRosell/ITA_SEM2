using System;
using modul8.Shared;

namespace modul8.Server.Repositories
{
    public class ShoppingRepositoryInMemory : IShoppingRepository
    {
        private List<ShoppingItem> mProducts = new() {
                  new ShoppingItem { Name = "bananer", Price = 12, Done = true },
                  new ShoppingItem { Name = "Æbler", Price = 14, Done = false  }
        };

        public void AddItem(ShoppingItem item)
        {
            mProducts.Add(item);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public ShoppingItem[] GetAll() => mProducts.ToArray();

    }
}