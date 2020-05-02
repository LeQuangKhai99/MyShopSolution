using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.Entities
{
    // Guid là chỉ thuộc tính tồn tại duy nhất trong toàn hệ thống
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { set; get; }
        public string LastName  { get; set; }

        public DateTime Dob { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }

        public List<Transaction> Transactions { set; get; }
    }
}
