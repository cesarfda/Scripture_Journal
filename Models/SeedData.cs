using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;
using Scripture_Journal.Data;

namespace Scripture_Journal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Scripture_JournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Scripture_JournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture_Journal.Models.Scripture
                    {
                        Collection = "New Testament",
                        Book = "Matthew",
                        Chapter = 7,
                        Verse = 7,
                        Notes = "Knock and it will open"
                    },
                    new Scripture_Journal.Models.Scripture
                    {
                        Collection = "Book of Mormon",
                        Book = "Mornoni",
                        Chapter = 10,
                        Verse = 2,
                        Notes = "WOW, I CAN ADD NOTES"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
