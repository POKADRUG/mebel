using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

public class ApplicationConnect : DbContext
{
    public DbSet<Cinema> Cinema { get; set; } = null!;
    public DbSet<mebels> mebels { get; set; } = null!;
    public DbSet<firma> firma { get; set; } = null!;

    public ApplicationConnect()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=mysql80.hostland.ru;user=host1849318_azbaev;password=qwerty123!;database=host1849318_azbaev;",
            new MySqlServerVersion(new Version(8, 0, 25)));
    }

}