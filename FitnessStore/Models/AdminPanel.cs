using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessStore.Models
{
    public class AdminPanel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Cart> Carts { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
