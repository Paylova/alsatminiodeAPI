using alsatminiode.Domain.Entities;
using alsatminiode.Domain.Entities.Common;
using alsatminiode.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence.Contexts
{
    public class alsatminiodeAPIDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public alsatminiodeAPIDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<WebsiteOption> WebsiteOptions { get; set; }
        public DbSet<PhoneSituation> PhoneSituations { get; set; }
        public DbSet<PhoneQuestion> PhoneQuestions { get; set; }
        public DbSet<PhoneBrand> PhoneBrands { get; set; }
        public DbSet<PhoneModel> PhoneModels { get; set; }
        public DbSet<Country> Countries { get; set; } 
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAnswers> CustomersAnswers { get; set; }
        public DbSet<PhoneModelCapacity> PhoneModelCapacity { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<PhoneModelImageFile> PhoneModelImageFiles { get; set; }
        public DbSet<PhoneBrandImageFile> phoneBrandImageFiles { get; set; }
        public DbSet<PhoneCost> PhoneCosts { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
        public DbSet<ShippingCompany> shippingCompanies { get; set; }
        public DbSet<ShippingCompanyImageFile> shippingCompanyImageFiles { get; set; }




        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           var datas = ChangeTracker.Entries<BaseEntity>();
           foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
