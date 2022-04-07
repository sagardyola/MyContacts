using Microsoft.EntityFrameworkCore;
using MyContacts.DataAccessLayer.ContactInformation;

namespace MyContacts.DataAccessLayer.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Label> Labels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactDetail>()
                .HasMany<PhoneNumber>(x => x.PhoneNumbers)
                .WithOne(x => x.ContactDetail)
                .OnDelete(DeleteBehavior.ClientCascade);

            /*
            // configures one-to-many relationship
            modelBuilder.Entity<ContactDetail>()
                .HasOne<Label>(x => x.Label);

            modelBuilder.Entity<ContactDetail>()
                .HasMany<ContactNumber>(x => x.ContactNumbers)
                .WithOne(x => x.ContactDetail)
                .HasForeignKey(x => x.ContactDetailId);
            */
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

            modelBuilder.Entity<PhoneNumber>().HasData(
                new PhoneNumber { Id = 1, Title = "Mobile", ContactNumber = "+447470855303", ContactDetailId = 1 },
                new PhoneNumber { Id = 2, Title = "Home", ContactNumber = "+97715536178", ContactDetailId = 1 },
                new PhoneNumber { Id = 3, Title = "Mobile (Nepal)", ContactNumber = "+9779841751478", ContactDetailId = 1 },
                new PhoneNumber { Id = 4, Title = "Mobile", ContactNumber = "+447727353665", ContactDetailId = 2 },
                new PhoneNumber { Id = 5, Title = "Home", ContactNumber = "+97714983404", ContactDetailId = 2 },
                new PhoneNumber { Id = 6, Title = "Mobile", ContactNumber = "+9779851085563", ContactDetailId = 3 },
                new PhoneNumber { Id = 7, Title = "Mobile", ContactNumber = "+9779841520663", ContactDetailId = 4 },
                new PhoneNumber { Id = 8, Title = "Mobile", ContactNumber = "+9779843335072", ContactDetailId = 5 },
                new PhoneNumber { Id = 9, Title = "Mobile", ContactNumber = "+9779810357026", ContactDetailId = 6 }
            );

            modelBuilder.Entity<Label>().HasData(
                new Label { Id = 1, Title = "Family" },
                new Label { Id = 2, Title = "School Friends" },
                new Label { Id = 3, Title = "Colleagues" }
            );
        }
    }
}
