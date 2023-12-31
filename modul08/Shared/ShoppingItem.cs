﻿using System;
using System.ComponentModel.DataAnnotations;

namespace modul08.Shared
{
    public class ShoppingItem
    {
        public string Name { get; set; } = "";

        public decimal Price { get; set; } = 0;

        public int Amount { get; set; } = 1;

        public string Description { get; set; } = "";

        public bool Done { get; set; } = false;

        // Opgave 1:
        public string Shop { get; set; } = "";

        // Opgave 3: tilføjer delete
        public int Id { get; set; }
    }
}