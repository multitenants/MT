using System;
using System.Collections.Generic;
using System.Data.Entity; //entity frame work namespace
using System.Linq;
 
using System.Web;

namespace multitenanat.Models
{
    [DbConfigurationType(typeof(DataConfiguration))]
    public class MultiTenantContext : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }


    public class DataConfiguration : DbConfiguration
    {
        public DataConfiguration()
        {
            //constructor
            SetDatabaseInitializer(new MultiTenantContextInitializer());
            //tDataBaseInitializer(new MultiTenantContextInitializer());
        }
    }
    public class MultiTenantContextInitializer : CreateDatabaseIfNotExists<MultiTenantContext>
    {
        protected override void Seed(MultiTenantContext context)
        {

            var tenants = new List<Tenant>
            {
                new Tenant()
                {
                    Name ="Tenant  google 1",
                    Domain ="www.google.com",
                    Id =1,
                    Default =true
                },
                 new Tenant()
                {
                    Name ="Tenant  facebook 2",  
                    Domain ="www.facebook.com",
                    Id =2,
                    Default =true
                },
                  new Tenant()
                {
                    Name ="Tenant  linkedin 3",
                    Domain ="www.linkedin.com",
                    Id =3,
                    Default =true
                }
            };
            tenants.ForEach(a => context.Tenants.Add(a));
            context.SaveChanges();

            ////add using JSON 
            var list = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
        }
    }

}