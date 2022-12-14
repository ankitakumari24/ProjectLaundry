using Laundry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laundry.Services
{
    public class InventoryDataAccess
    {
        LaundryManagmentSystemEntities db = new LaundryManagmentSystemEntities();

        public IEnumerable<Inventory> Get()
        {
            var result = db.Inventories.ToList();

            return result;
        }

        public Inventory Create(Inventory inventory)
        {
            var res = db.Inventories.Add(inventory);
            db.SaveChanges();
            return res;
        }

        public Inventory Delete(int id)
        {
            var res = db.Inventories.Where(x => x.Inventory_ID == id).First();
            db.Inventories.Remove(res);
            db.SaveChanges();
           
            return res;

        }
       
    }
}