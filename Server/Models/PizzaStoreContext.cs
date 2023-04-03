using System;
using Microsoft.EntityFrameworkCore; 
using BlazingPizza.Shared;

public class PizzaStoreContext : DbContext
{
	public DbSet<PizzaSpecial> Specials { get; set; }

	public PizzaStoreContext(DbContextOptions options)
		: base(options)
	{ 
	}
}
