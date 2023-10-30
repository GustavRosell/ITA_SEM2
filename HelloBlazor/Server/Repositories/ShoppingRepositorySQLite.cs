using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public class ShoppingRepositorySQLite : IShoppingRepository
    {
        private const string connectionString = @"Data Source=//Users/rosell/Data/shoppinglist.db";

        public void AddItem(ShoppingItem item)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"INSERT INTO shoppinglist (Name, Amount, Description) VALUES ($name, amount, Description)";
                command.Parameters.AddWithValue("$name", item.Name);
                command.Parameters.AddWithValue("$amount", item.Amount);
                command.Parameters.AddWithValue("$description", item.Description);
                command.ExecuteNonQuery();
            }
        }

        public ShoppingItem[] GetAll()
        {
            var result = new List<ShoppingItem>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM shoppinglist";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var amount = reader.GetInt32(2);
                        var description = reader.IsDBNull(3) ? null : reader.GetString(3);

                        ShoppingItem item = new ShoppingItem { Id = id, Name = name, Amount = amount, Description = description};
                        result.Add(item);
                    }
                }
            }
            return result.ToArray();
        }

        public void DeleteById(int id)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"DELETE FROM shoppinglist WHERE Id = $id";
                command.Parameters.AddWithValue("$id", id);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateItem(ShoppingItem item)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"UPDATE shoppinglist SET Name = $name, Amount = $amount, Description = $description WHERE Id = $id";
                command.Parameters.AddWithValue("$name", item.Name);
                command.Parameters.AddWithValue("$amount", item.Amount);
                command.Parameters.AddWithValue("$description", item.Description);
                command.Parameters.AddWithValue("$id", item.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
