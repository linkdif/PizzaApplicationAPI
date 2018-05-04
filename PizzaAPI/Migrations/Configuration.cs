using System.Collections.Generic;
using PizzaAPI.Interfaces.Entities;
using PizzaAPI.Models.Entities;

namespace PizzaAPI.Migrations
{
    using System.Data.Entity.Migrations;

    internal class Configuration : DbMigrationsConfiguration<PizzaOrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzaOrderContext context)
        {

            var cheese_s = new Topping { Id = 1, Name = "Cheese", Size = "small", Price = 0.90M };
            var cheese_m = new Topping { Id = 2, Name = "Cheese", Size = "medium", Price = 1.00M };
            var cheese_l = new Topping { Id = 3, Name = "Cheese", Size = "large", Price = 1.15M };
            var tom_s = new Topping { Id = 4, Name = "Tomato sauce", Size = "small", Price = 0.90M };
            var tom_m = new Topping { Id = 5, Name = "Tomato sauce", Size = "medium", Price = 1.00M };
            var tom_l = new Topping { Id = 6, Name = "Tomato sauce", Size = "large", Price = 1.15M };
            var pepp_s = new Topping { Id = 7, Name = "Pepperoni", Size = "small", Price = 0.90M };
            var pepp_m = new Topping { Id = 8, Name = "Pepperoni", Size = "medium", Price = 1.00M };
            var pepp_l = new Topping { Id = 9, Name = "Pepperoni", Size = "large", Price = 1.15M };
            var ham_s = new Topping { Id = 10, Name = "Ham", Size = "small", Price = 0.90M };
            var ham_m = new Topping { Id = 11, Name = "Ham", Size = "medium", Price = 1.00M };
            var ham_l = new Topping { Id = 12, Name = "Ham", Size = "large", Price = 1.15M };
            var chick_s = new Topping { Id = 13, Name = "Chicken", Size = "small", Price = 0.90M };
            var chick_m = new Topping { Id = 14, Name = "Chicken", Size = "medium", Price = 1.00M };
            var chick_l = new Topping { Id = 15, Name = "Chicken", Size = "large", Price = 1.15M };
            var beef_s = new Topping { Id = 16, Name = "Minced beef", Size = "small", Price = 0.90M };
            var beef_m = new Topping { Id = 17, Name = "Minced beef", Size = "medium", Price = 1.00M };
            var beef_l = new Topping { Id = 18, Name = "Minced beef", Size = "large", Price = 1.15M };
            var onion_s = new Topping { Id = 19, Name = "Onions", Size = "small", Price = 0.90M };
            var onion_m = new Topping { Id = 20, Name = "Onions", Size = "medium", Price = 1.00M };
            var onion_l = new Topping { Id = 21, Name = "Onions", Size = "large", Price = 1.15M };
            var gpepp_s = new Topping { Id = 22, Name = "Green peppers", Size = "small", Price = 0.90M };
            var gpepp_m = new Topping { Id = 23, Name = "Green peppers", Size = "medium", Price = 1.00M };
            var gpepp_l = new Topping { Id = 24, Name = "Green peppers", Size = "large", Price = 1.15M };
            var mush_s = new Topping { Id = 25, Name = "Mushrooms", Size = "small", Price = 0.90M };
            var mush_m = new Topping { Id = 26, Name = "Mushrooms", Size = "medium", Price = 1.00M };
            var mush_l = new Topping { Id = 27, Name = "Mushrooms", Size = "large", Price = 1.15M };
            var sweetcorn_s = new Topping { Id = 28, Name = "Sweetcorn", Size = "small", Price = 0.90M };
            var sweetcorn_m = new Topping { Id = 29, Name = "Sweetcorn", Size = "medium", Price = 1.00M };
            var sweetcorn_l = new Topping { Id = 30, Name = "Sweetcorn", Size = "large", Price = 1.15M };
            var jalp_s = new Topping { Id = 31, Name = "Jalapeno peppers", Size = "small", Price = 0.90M };
            var jalp_m = new Topping { Id = 32, Name = "Jalapeno peppers", Size = "medium", Price = 1.00M };
            var jalp_l = new Topping { Id = 33, Name = "Jalapeno peppers", Size = "large", Price = 1.15M };
            var pineapp_s = new Topping { Id = 34, Name = "Pineapple", Size = "small", Price = 0.90M };
            var pineapp_m = new Topping { Id = 35, Name = "Pineapple", Size = "medium", Price = 1.00M };
            var pineapp_l = new Topping { Id = 36, Name = "Pineapple", Size = "large", Price = 1.15M };
            var saus_s = new Topping { Id = 37, Name = "Sausage", Size = "small", Price = 0.90M };
            var saus_m = new Topping { Id = 38, Name = "Sausage", Size = "medium", Price = 1.00M };
            var saus_l = new Topping { Id = 39, Name = "Sausage", Size = "large", Price = 1.15M };
            var bacon_s = new Topping { Id = 40, Name = "Bacon", Size = "small", Price = 0.90M };
            var bacon_m = new Topping { Id = 41, Name = "Bacon", Size = "medium", Price = 1.00M };
            var bacon_l = new Topping { Id = 42, Name = "Bacon", Size = "large", Price = 1.15M };

            List<Pizza> pizzas = new List<Pizza> {
                new Pizza { Id = 1, Name = "Original", Size = "small", Price = 8.00M, Toppings = new List<Topping> {cheese_s, tom_s } },
                new Pizza { Id = 2, Name = "Original", Size = "medium", Price = 9.00M, Toppings = new List<Topping> {cheese_m, tom_m }  },
                new Pizza { Id = 3, Name = "Original", Size = "large", Price = 11.00M, Toppings = new List<Topping> {cheese_l, tom_l }  },
                new Pizza { Id = 4, Name = "Gimme the Meat", Size = "small", Price = 11.00M, Toppings = new List<Topping> { pepp_s, ham_s, chick_s, beef_s, saus_s, bacon_s } },
                new Pizza { Id = 5, Name = "Gimme the Meat", Size = "medium", Price = 14.50M, Toppings = new List<Topping> { pepp_m, ham_m, chick_m, beef_m, saus_m, bacon_m } },
                new Pizza { Id = 6, Name = "Gimme the Meat", Size = "large", Price = 16.50M, Toppings = new List<Topping> { pepp_l, ham_l, chick_l, beef_l, saus_l, bacon_l } },
                new Pizza { Id = 7, Name = "Veggie Delight", Size = "small", Price = 10.00M, Toppings = new List<Topping> { onion_s, gpepp_s, mush_s, sweetcorn_s } },
                new Pizza { Id = 8, Name = "Veggie Delight", Size = "medium", Price = 13.00M, Toppings = new List<Topping> { onion_m,  gpepp_m, mush_m, sweetcorn_m } },
                new Pizza { Id = 9, Name = "Veggie Delight", Size = "large", Price = 15.00M, Toppings = new List<Topping> { onion_l, gpepp_l, mush_l, sweetcorn_l } },
                new Pizza { Id = 10, Name = "Create Your Own", Size = "small", Price = 8.00M, Toppings = new List<Topping> {cheese_s, tom_s } },
                new Pizza { Id = 11, Name = "Create Your Own", Size = "medium", Price = 9.00M, Toppings = new List<Topping> {cheese_m, tom_m } },
                new Pizza { Id = 12, Name = "Create Your Own", Size = "large", Price = 11.00M, Toppings = new List<Topping> {cheese_l, tom_l } },
                new Pizza { Id = 13, Name = "Make Mine Hot", Size = "small", Price = 11.00M, Toppings = new List<Topping> { chick_s, onion_s, gpepp_s, jalp_s } },
                new Pizza { Id = 14, Name = "Make Mine Hot", Size = "medium", Price = 13.00M, Toppings = new List<Topping> { chick_m, onion_m, gpepp_m, jalp_m } },
                new Pizza { Id = 15, Name = "Make Mine Hot", Size = "large", Price = 15.00M, Toppings = new List<Topping> { chick_l, onion_l, gpepp_l, jalp_l } }
            };

            pizzas.ForEach(pizza => context.Pizzas.AddOrUpdate(p => p.Id, pizza));
            context.SaveChanges();
        }
    }
}
