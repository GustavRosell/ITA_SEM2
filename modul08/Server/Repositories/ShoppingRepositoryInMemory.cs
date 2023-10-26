using System;
using modul08.Shared;
using System.Collections.Generic;


namespace modul08.Server.Repositories
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
            ShoppingItem itemToRemove = null;
            foreach (var item in mProducts)
            {
                if (item.Id == id)
                {
                    itemToRemove = item;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                mProducts.Remove(itemToRemove);
            }
        }

        public ShoppingItem[] GetAll() => mProducts.ToArray();

        public void UpdateItem(ShoppingItem item)
        {
            DeleteById(item.Id);
            mProducts.Add(item);
           
        }
    }
}