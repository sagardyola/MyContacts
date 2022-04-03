using Microsoft.EntityFrameworkCore;

namespace MyContacts.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactNumber> ContactNumbers { get; set; }
        public DbSet<Label> Labels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ContactDetail>()
            //            .HasMany(c => c.ContactNumbers)
            //            .WithOne(e => e.ContactDetail);

            modelBuilder.Entity<ContactDetail>().HasData(
                new ContactDetail { 
                    Id = 1, 
                    FirstName = "Sagar", 
                    LastName = "Dyola", 
                    Address = "8B Court Parade, HA0 3HY", 
                    Notes = "Nothing for now", 
                    LabelId = 2
                },
                new ContactDetail { 
                    Id = 2,
                    FirstName = "Sunita",
                    LastName = "Ghale",
                    Address = "8A Court Parade, HA0 3HY",
                    Notes = "Hey this is Sunita Ghale",
                    LabelId = 3
                },
                new ContactDetail { 
                    Id = 3,
                    FirstName = "Surya Lal",
                    LastName = "Dyola",
                    Address = "Lagankhel, Nepal",
                    Notes = "Surya here. Nothing for now",
                    LabelId = 1
                },
                new ContactDetail { 
                    Id = 4,
                    FirstName = "Sumitra",
                    LastName = "Dyola",
                    Address = "Lagankhel, Nepal",
                    Notes = "Sumitra here. Nothing for now",
                    LabelId = 2
                },
                new ContactDetail { 
                    Id = 5,
                    FirstName = "Sunita",
                    LastName = "Dyola",
                    Address = "Lagankhel, Nepal",
                    Notes = "Sunita here. Nothing for now",
                    LabelId = 3
                },
                new ContactDetail { 
                    Id = 6,
                    FirstName = "Subita",
                    LastName = "Ghale",
                    Address = "Samakhushi, Nepal",
                    Notes = "Subita here. Nothing for now",
                    LabelId = 1
                }
            );

            modelBuilder.Entity<ContactNumber>().HasData(
                new ContactNumber { Id = 1, Title = "Mobile", Number = "+447470855303", ContactDetailId = 1 },
                new ContactNumber { Id = 2, Title = "Home", Number = "+97715536178", ContactDetailId = 1 },
                new ContactNumber { Id = 3, Title = "Mobile (Nepal)", Number = "+9779841751478", ContactDetailId = 1 },
                new ContactNumber { Id = 4, Title = "Mobile", Number = "+447727353665", ContactDetailId = 2 },
                new ContactNumber { Id = 5, Title = "Home", Number = "+97714983404", ContactDetailId = 2 },
                new ContactNumber { Id = 6, Title = "Mobile", Number = "+9779851085563", ContactDetailId = 3 },
                new ContactNumber { Id = 7, Title = "Mobile", Number = "+9779841520663", ContactDetailId = 4 },
                new ContactNumber { Id = 8, Title = "Mobile", Number = "+9779843335072", ContactDetailId = 5 },
                new ContactNumber { Id = 9, Title = "Mobile", Number = "+9779810357026", ContactDetailId = 6 }
            );

            modelBuilder.Entity<Label>().HasData(
                new Label { Id = 1, LabelName = "Family" },
                new Label { Id = 2, LabelName = "School Friends" },
                new Label { Id = 3, LabelName = "Colleagues" }
            );
        }
    }
}
