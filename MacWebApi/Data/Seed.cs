using MacWebApi.Models;

namespace MacWebApi.Data
{
    public class Seed
    {
        private DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;
        }
        public void SeedDataContext()
        {
            if(!_context.Cities.Any())
            {
                var cities = new List<City>()
                {
                    new City()
                    {
                        Name = "Dushanbe"
                    },
                    new City()
                    {
                        Name = "Panjakent"
                    },
                    new City()
                    {
                        Name = "Kulob"
                    },
                    new City()
                    {
                        Name = "Khujand"
                    }
                };
                _context.Cities.AddRange(cities);
                _context.SaveChanges();
            }
            if(!_context.Categories.Any())
            {
                var categories = new List<Category>()
                {
                    new Category
                    {
                        Name = "Завтрак", 
                        Description = "Для завтрака"
                    },
                    new Category
                    {
                        Name = "Напитки"
                    },
                    new Category
                    {
                        Name = "Соусы"
                    },
                    new Category
                    {
                        Name = "Бургеры"
                    },
                    new Category
                    {
                        Name = "Картошка"
                    },
                    new Category
                    {
                        Name = "Роллы"
                    }

                };
                _context.Categories.AddRange(categories);
                _context.SaveChanges();
            }
            if (!_context.Roles.Any())
            {
                var roles = new List<Role>()
                {
                    new Role()
                    {
                        Name = "Администратор"
                    },
                    new Role()
                    {
                        Name = "Клиент"
                    },
                    new Role()
                    {
                        Name = "Диспетчер"
                    }
                };
                _context.Roles.AddRange(roles);
                _context.SaveChanges();
            }
            if (!_context.Users.Any())
            {
                var roles = _context.Roles.ToList();
                if(roles.Any())
                {
                    var users = new List<User>()
                    {
                        new User()
                        {
                            FirstName = "Тохиров",
                            LastName = "Бахтовар",
                            Email = "bakhtovartohirov1020@gmail.com",
                            Password = "123456789+",
                            Phone = "+992909909090",
                            RoleId = roles[0].Id,
                            Role = roles[0]
                        },
                        new User()
                        {
                            FirstName = "Азимова",
                            LastName = "Санавбар",
                            Email = "sanazimova@gmail.com",
                            Password = "123456789+",
                            Phone = "+992001990099",
                            RoleId = roles[1].Id,
                            Role = roles[1]
                        },
                        new User()
                        {
                            FirstName = "Азимова",
                            LastName = "Санавбар",
                            Email = "sanazimova@gmail.com",
                            Password = "123456789+",
                            Phone = "+992001990099",
                            RoleId = roles[1].Id,
                            Role = roles[1]
                        },
                        new User()
                        {
                            FirstName = "Азимова",
                            LastName = "Санавбар",
                            Email = "sanazimova@gmail.com",
                            Password = "123456789+",
                            Phone = "+992001990099",
                            RoleId = roles[1].Id,
                            Role = roles[1]
                        },
                        new User()
                        {
                            FirstName = "Бегимкулов",
                            LastName = "Дилшод",
                            Email = "dilshodbegimkulov@gmail.com",
                            Password = "123456789+",
                            Phone = "+992557009981",
                            RoleId = roles[2].Id,
                            Role = roles[2]
                        }
                    };
                    _context.Users.AddRange(users);
                    _context.SaveChanges();
                }
             }
            if (!_context.Orders.Any())
            {
                var users = _context.Users.ToList();
                var categories = _context.Categories.ToList();
                var cities = _context.Cities.ToList();
                if(users.Any() &&  categories.Any() && cities.Any())
                {
                    var orders = new List<Order>()
                    {
                        new Order
                        {
                            Landmark = "Цум",
                            Street = "Бохтар",
                            House = 10,
                            Apartment= 3,
                            IsPaid = true,
                            IsToGo = true,
                            CityId = cities[0].Id,
                            City = cities[0],
                            Products = new List<Product>()
                            {
                                new Product()
                                {
                                    Name = "Пирожок Клубника-малина",
                                    Description = "Хрустящий пирожок с сочной начинкой из ягод клубники и малины",
                                    Price = 79,
                                    CategoryId = categories.First().Id,
                                    Category = categories.First()
                                },
                                new Product()
                                {
                                    Name = "Маффин с яйцом и индейкой",
                                    Description = "Мягкая горячая булочка (английский маффин) с яйцом, ломтиком сыра Чеддер и двумя хрустящими слайсами индейки. Идеальное начало дня.",
                                    Price = 155,
                                    CategoryId = categories.First().Id,
                                    Category = categories.First()
                                }
                            },
                            CreatedByUserId = users[2].Id,
                            CreatedByUser = users[2],
                            ConfirmedByUserId = users[0].Id,
                            ConfirmedByUser = users[0]


                        },
                        new Order
                        {
                            Landmark = "Бозори хуроквори",
                            Street = "Рудаки",
                            House = 145,
                            IsPaid = false,
                            IsToGo = true,
                            CityId = cities[1].Id,
                            City = cities[1],
                            Products= new List<Product>()
                            {
                                new Product()
                                {
                                    Name = "Утренний Ролл",
                                    Description = "Утренний Ролл на завтрак со свиной котлетой в сочетании с пышным омлетом, ломтиком сыра Чеддер и легендарным картофельным оладушком, обжаренным до румяной корочки. Всё это приправлено кетчупом и завёрнуто в ароматную, пшеничную лепешку. Успей заказать до конца завтрака — до 10:00",
                                    Price = 189,
                                    CategoryId = categories[5].Id,
                                    Category = categories[5]
                                },
                                new Product()
                                {
                                    Name = "Утренний Ролл2",
                                    Description = "Утренний Ролл на завтрак со свиной котлетой в сочетании с пышным омлетом, ломтиком сыра Чеддер и легендарным картофельным оладушком, обжаренным до румяной корочки. Всё это приправлено кетчупом и завёрнуто в ароматную, пшеничную лепешку. Успей заказать до конца завтрака — до 10:00",
                                    Price = 189,
                                    CategoryId = categories[5].Id,
                                    Category = categories[5],
                                }
                            },
                            CreatedByUserId = users[2].Id,
                            CreatedByUser = users[2]
                        },
                        new Order
                        {
                            Landmark = "Милано Мода 84 мкр",
                            Street = "Бобочон Гафуров",
                            House = 6,
                            IsPaid = true,
                            IsToGo = true,
                            CityId = cities[0].Id,
                            City = cities[0],
                            Products= new List<Product>()
                            {
                                new Product()
                                {
                                    Name = "Утренний Ролл3",
                                    Description = "Утренний Ролл на завтрак со свиной котлетой в сочетании с пышным омлетом, ломтиком сыра Чеддер и легендарным картофельным оладушком, обжаренным до румяной корочки. Всё это приправлено кетчупом и завёрнуто в ароматную, пшеничную лепешку. Успей заказать до конца завтрака — до 10:00",
                                    Price = 189,
                                    CategoryId = categories[5].Id,
                                    Category = categories[5]
                                }
                            },
                            CreatedByUserId = users[4].Id,
                            CreatedByUser = users[4],
                            ConfirmedByUserId = users[0].Id,
                            ConfirmedByUser = users[0]
                        }

                    };
                        _context.Orders.AddRange(orders);
                        _context.SaveChanges();
                }
                
            }
            
        }
    }
}
