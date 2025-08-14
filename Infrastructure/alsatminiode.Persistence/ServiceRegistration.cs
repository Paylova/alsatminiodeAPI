using Microsoft.EntityFrameworkCore;
using alsatminiode.Application.Abstractions;
using alsatminiode.Persistence.Concretes;
using alsatminiode.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alsatminiode.Application.Repositories.CustomerRepo;
using alsatminiode.Persistence.Repositories.CustomerRepo;
using alsatminiode.Application.Repositories.AdminRepo;
using alsatminiode.Persistence.Repositories.AdminRepo;
using alsatminiode.Application.Repositories.CityRepo;
using alsatminiode.Persistence.Repositories.CityRepo;
using alsatminiode.Application.Repositories.CountryRepo;
using alsatminiode.Persistence.Repositories.CountryRepo;
using alsatminiode.Application.Repositories.DistrictRepo;
using alsatminiode.Persistence.Repositories.DistrictRepo;
using alsatminiode.Application.Repositories.PhoneBrandRepo;
using alsatminiode.Persistence.Repositories.PhoneBrandRepo;
using alsatminiode.Application.Repositories.PhoneModelRepo;
using alsatminiode.Persistence.Repositories.PhoneModelRepo;
using alsatminiode.Application.Repositories.PhoneQuestionRepo;
using alsatminiode.Persistence.Repositories.PhoneQuestionRepo;
using alsatminiode.Application.Repositories.PhoneSituationRepo;
using alsatminiode.Persistence.Repositories.PhoneSituationRepo;
using alsatminiode.Application.Repositories.WebsiteOptionRepo;
using alsatminiode.Persistence.Repositories.WebsiteOptionRepo;
using alsatminiode.Application.Repositories.FileRepo;
using alsatminiode.Persistence.Repositories.FileRepo;
using alsatminiode.Application.Repositories.PhoneModelImageRepo;
using alsatminiode.Persistence.Repositories.PhoneModelImageFileRepo;
using alsatminiode.Application.Repositories.PhoneCost;
using alsatminiode.Persistence.Repositories.PhoneCost;
using alsatminiode.Domain.Entities.Identity;
using alsatminiode.Application.Abstractions.Services.Mesages;
using alsatminiode.Infrastructure.Services.Mesages;
using alsatminiode.Application.Repositories.CustomerAnswersRepo;
using alsatminiode.Persistence.Repositories.CustomerAnswersRepo;
using alsatminiode.Application.Repositories.PhoneBrandImageFileRepo;
using alsatminiode.Persistence.Repositories.PhoneBrandImageFileRepo;
using alsatminiode.Application.Repositories.PhoneModelCapacityRepo;
using alsatminiode.Persistence.Repositories.PhoneModelCapacityRepo;
using alsatminiode.Persistence.Concretes.Email;
using alsatminiode.Application.Repositories.ShippingCompanyRepo;
using alsatminiode.Persistence.Repositories.ShippingCompanyRepo;
using alsatminiode.Application.Repositories.ShippingCompanyImageFileRepo;
using alsatminiode.Persistence.Repositories.ShippingCompanyImageFileRepo;

namespace alsatminiode.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<alsatminiodeAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<alsatminiodeAPIDbContext>();

            services.AddScoped<ICustomerAnswersReadRepository, CustomerAnswersReadRepository>();
            services.AddScoped<ICustomerAnswersWriteRepository, CustomerAnswersWriteRepository>();

            services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IAdminReadRepository, AdminReadRepository>();
            services.AddScoped<IAdminWriteRepository, AdminWriteRepository>();

            services.AddScoped<ICityReadRepository, CityReadRepository>();
            services.AddScoped<ICityWriteRepository, CityWriteRepository>();

            services.AddScoped<ICountryReadRepository, CountryReadRepository>();
            services.AddScoped<ICountryWriteRepository, CountryWriteRepository>();

            services.AddScoped<IDistrictReadRepository, DistrictReadRepository>();
            services.AddScoped<IDistrictWriteRepository, DistrictWriteRepository>();

            services.AddScoped<IPhoneBrandReadRepository, PhoneBrandReadRepository>();
            services.AddScoped<IPhoneBrandWriteRepository, PhoneBrandWriteRepository>();

            services.AddScoped<IPhoneModelReadRepository, PhoneModelReadRepository>();
            services.AddScoped<IPhoneModelWriteRepository, PhoneModelWriteRepository>();

            services.AddScoped<IPhoneQuestionReadRepository, PhoneQuestionReadRepository>();
            services.AddScoped<IPhoneQuestionWriteRepository, PhoneQuestionWriteRepository>();

            services.AddScoped<IPhoneSituationReadRepository, PhoneSituationReadRepository>();
            services.AddScoped<IPhoneSituationWriteRepository, PhoneSituationWriteRepository>();

            services.AddScoped<IWebsiteOptionReadRepository, WebsiteOptionReadRepository>();
            services.AddScoped<IWebsiteOptionWriteRepository, WebsiteOptionWriteRepository>();

            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();

            services.AddScoped<IPhoneModelImageFileReadRepository, PhoneModelImageFileReadRepository>();
            services.AddScoped<IPhoneModelImageFileWriteRepository, PhoneModelImageFileWriteRepository>();

            services.AddScoped<IPhoneBrandImageFileReadRepository, PhoneBrandImageFileReadRepository>();
            services.AddScoped<IPhoneBrandImageFileWriteRepository, PhoneBrandImageFileWriteRepository>();

            services.AddScoped<IPhoneCostReadRepository, PhoneCostReadRepository>();
            services.AddScoped<IPhoneCostWriteRepository, PhoneCostWriteRepository>();

            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IMessageTemplateService, MessageTemplateService>();

            services.AddScoped<IPhoneModelCapacityReadRepository, PhoneModelCapacityReadRepository>();
            services.AddScoped<IPhoneModelCapacityWriteRepository, PhoneModelCapacityWriteRepository>();

            services.AddScoped<IMailService, MailService>();

            services.AddScoped<IShippingCompanyReadRepository, ShippingCompanyReadRepository>();
            services.AddScoped<IShippingCompanyWriteRepository, ShippingCompanyWriteRepository>();

            services.AddScoped<IShippingCompanyImageFileReadRepository, ShippingCompanyImageFileReadRepository>();
            services.AddScoped<IShippingCompanyImageFileWriteRepository, ShippingCompanyImageFileWriteRepository>();




        }
    }
}
