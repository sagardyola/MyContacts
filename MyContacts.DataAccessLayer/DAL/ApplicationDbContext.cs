using Microsoft.EntityFrameworkCore;
using MyContacts.DataAccessLayer.ContactInformation;
using Newtonsoft.Json;

namespace MyContacts.DataAccessLayer.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

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

            List<string> _files = new List<string>();
            string _filePath = Path.GetFullPath(@"..\MyContacts.Shared\Data\TestData");
            _files.AddRange(Directory.GetFiles(_filePath, "*.json"));

            foreach (var _file in _files)
            {
                using (StreamReader sr = new StreamReader(_file))
                {
                    if (_file.ToLower().Contains("contactdetail"))
                    {
                        List<ContactDetail> contactDetailSeed = new List<ContactDetail>();
                        contactDetailSeed = JsonConvert.DeserializeObject<List<ContactDetail>>(sr.ReadToEnd());
                        modelBuilder.Entity<ContactDetail>().HasData(contactDetailSeed);
                    }
                    else if (_file.ToLower().Contains("label"))
                    {
                        List<Label> labelSeed = new List<Label>();
                        labelSeed = JsonConvert.DeserializeObject<List<Label>>(sr.ReadToEnd());
                        modelBuilder.Entity<Label>().HasData(labelSeed);
                    }
                    else if (_file.ToLower().Contains("phonenumber"))
                    {
                        List<PhoneNumber> numberSeed = new List<PhoneNumber>();
                        numberSeed = JsonConvert.DeserializeObject<List<PhoneNumber>>(sr.ReadToEnd());
                        modelBuilder.Entity<PhoneNumber>().HasData(numberSeed);
                    }
                }
            }
        }
    }
}
