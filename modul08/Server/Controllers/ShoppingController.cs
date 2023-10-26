using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modul08.Shared;

namespace modul08.Server.Controllers
{
    [ApiController]
    [Route("api/Shopping")]
    public class ShoppingController : ControllerBase
    {
        private IShoppingRepository mRepo;

        public ShoppingController(IShoppingRepository repo)
        {
            mRepo = repo;
        }

        [HttpGet]
        [Route("getall")]
        public IEnumerable<ShoppingItem> GetAll()
        {
            return mRepo.GetAll();
        }

        [HttpPost]
        [Route("add")]
        public void AddItem(ShoppingItem product)
        {
            mRepo.AddItem(product);
        }

        // Opgave 3: Delete
        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteItem(int id)
        {
            mRepo.DeleteById(id);
        }

        // Opgave 4: Update
        [HttpPut]
        [Route("update")]
        public void UpdateItem(ShoppingItem item)
        {
            mRepo.UpdateItem(item);
        }

    }
}