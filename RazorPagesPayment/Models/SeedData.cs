using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesPayment.Data;
using System;
using System.Linq;

namespace RazorPagesPayment.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesPaymentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesPaymentContext>>()))
            {
                // Look for any movies.
                if (context.Payment.Any())
                {
                    return;   // DB has been seeded
                }

                context.Payment.AddRange(
                    new Payment
                    {
                        Pago = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        //AskReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Romantic Comedy",
                        Price = "hola"
                    },

                    new Payment
                    {
                        Pago = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        //AskReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = "hola"
                    },

                    new Payment
                    {
                        Pago = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        //AskReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = "hola"
                    },

                    new Payment
                    {
                        Pago = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        //AskReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Western",
                        Price = "hola"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}