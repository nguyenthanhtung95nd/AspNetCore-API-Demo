using Book_API.Data.Static;
using Book_API.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_API.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Publishers
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>
                    {
                        new Publisher
                        {
                            Name = "Publisher 1"
                        },
                        new Publisher
                        {
                            Name = "Publisher 2"
                        }
                    });
                    context.SaveChanges();
                }
                //Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "2nd Book Title",
                        Description = "2nd Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "3rd Book Title",
                        Description = "3rd Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "4th Book Title",
                        Description = "4th Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "5th Book Title",
                        Description = "5th Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "6th Book Title",
                        Description = "6th Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "7th Book Title",
                        Description = "7th Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "8th Book Title",
                        Description = "8th Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "9th Book Title",
                        Description = "9th Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    },
                    new Book()
                    {
                        Title = "10th Book Title",
                        Description = "10th Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                        PublisherId = 1
                    });

                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedRoles(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                // Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.Publisher))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Publisher));

                if (!await roleManager.RoleExistsAsync(UserRoles.Author))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Author));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin",
                        UserName = "admin",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Admin123!@#");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "User",
                        UserName = "user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "User123!@#");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }

                string publisherEmail = "publisher@gmail.com";

                var publisherUser= await userManager.FindByEmailAsync(publisherEmail);
                if (publisherUser == null)
                {
                    var newPublisherUser = new ApplicationUser()
                    {
                        FullName = "Publisher",
                        UserName = "publisher",
                        Email = publisherEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newPublisherUser, "Publisher123!@#");
                    await userManager.AddToRoleAsync(newPublisherUser, UserRoles.Publisher);
                }

                string authorUserEmail = "admin@gmail.com";

                var authorUser = await userManager.FindByEmailAsync(authorUserEmail);
                if (authorUser == null)
                {
                    var newAuthorUser = new ApplicationUser()
                    {
                        FullName = "Author",
                        UserName = "author",
                        Email = authorUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAuthorUser, "Author123!@#");
                    await userManager.AddToRoleAsync(newAuthorUser, UserRoles.Author);
                }
            }
        }
    }
}
