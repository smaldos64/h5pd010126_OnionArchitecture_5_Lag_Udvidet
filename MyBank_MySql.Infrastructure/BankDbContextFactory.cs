using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Infrastructure.Persistence.MySQL
{
    //internal class MyBankDbContextFactory
    //{
    //}
    public class BankDbContextFactory : IDesignTimeDbContextFactory<BankDbContext>
    {
        public BankDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankDbContext>();

            throw new Exception("STOP: Min Factory bliver rent faktisk brugt!");

            // Vi bruger den præcise streng her til design-time
            var connectionString = "server=localhost;port=3306;database=MyBankOnionArchitecture_5_Lags_MySQL;uid=myltpe;pwd=Buchwald34;AllowPublicKeyRetrieval=True;SslMode=None;";
            //var connectionString = "server=127.0.0.1;port=3306;database=MyBankOnionArchitecture_5_Lags_MySQL;user=myltpe;password=Buchwald34;AllowPublicKeyRetrieval=True;SslMode=None;";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new BankDbContext(optionsBuilder.Options);
        }
    }
}
