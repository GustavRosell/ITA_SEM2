﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modul8.Shared;

namespace modul8.Server.Controllers
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
    }
}