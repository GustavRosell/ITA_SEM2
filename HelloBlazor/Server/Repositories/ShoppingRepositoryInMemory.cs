using System;
using System.Collections.Generic;
using System.Linq;
using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public class ShoppingRepositoryInMemory : IShoppingRepository
    {
        private List<ShoppingItem> mProducts = new() {
            new ShoppingItem { Id = 1, Name = "bananer", Amount = 12, Description = "Organiske", Done = true },
            new ShoppingItem { Id = 2, Name = "Æbler", Amount = 14, Description = "Røde æbler", Done = false }
        };

        public void AddItem(ShoppingItem item)
        {
            int newId = mProducts.Any() ? mProducts.Max(item => item.Id) + 1 : 1;
            item.Id = newId;
            mProducts.Add(item);
        }

        public ShoppingItem[] GetAll() => mProducts.ToArray();

        public void DeleteById(int id)
        {
            mProducts.RemoveAll(item => item.Id == id);
        }

        public void UpdateItem(ShoppingItem item)
        {
            var index = mProducts.FindIndex(existingItem => existingItem.Id == item.Id);
            if (index != -1)
            {
                mProducts[index] = item;
            }
        }
    }
}
