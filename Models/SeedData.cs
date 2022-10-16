using System;
using System.Collections.Generic;
using System.Linq;
using NB_Plates.Data;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace NB_Plates.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NB_PlatesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<NB_PlatesContext>>()))
            {
                // Look for any movies.
                if (context.Plates.Any())
                {
                    return;   // DB has been seeded
                }

                context.Plates.AddRange(
             new Plates
             {

                 Size = "Small",
                 Color = "Black",
                 Weight = 3,
                 Price = 300,
                 Shape = "Round",
                 Rating = 8

             },

              new Plates
              {

                  Size = "Small",
                  Color = "Red",
                  Weight = 3,
                  Price = 350,
                  Shape = "Aquare",
                  Rating = 10

              },
               new Plates
               {

                   Size = "Medium",
                   Color = "Black",
                   Weight = 5,
                   Price = 450,
                   Shape = "Oval",
                   Rating = 8

               },
                new Plates
                {

                    Size = "Large",
                    Color = "Black",
                    Weight = 4,
                    Price = 550,
                    Shape = "Round",
                    Rating = 9

                },
                 new Plates
                 {

                     Size = "Small",
                     Color = "Sky Blue",
                     Weight = 2,
                     Price = 200,
                     Shape = "Round",
                     Rating = 10

                 },
                  new Plates
                  {

                      Size = "Medium",
                      Color = "Grey",
                      Weight = 3,
                      Price = 350,
                      Shape = "Round",
                      Rating = 9

                  },
                   new Plates
                   {

                       Size = "Small",
                       Color = "Sky Blue",
                       Weight = 2,
                       Price = 200,
                       Shape = "Round",
                       Rating = 10

                   },
                    new Plates
                    {

                        Size = "Medium",
                        Color = "Red",
                        Weight = 4,
                        Price = 203500,
                        Shape = "Rec tangle",
                        Rating = 9

                    },
                     new Plates
                     {

                         Size = "Lrage",
                         Color = "Red",
                         Weight = 5,
                         Price = 550,
                         Shape = "Round",
                         Rating = 10

                     },
                      new Plates
                      {

                          Size = "Large",
                          Color = "Black",
                          Weight = 4,
                          Price = 450,
                          Shape = "Rac Tangle",
                          Rating = 9

                      },
                       new Plates
                       {

                           Size = "Large",
                           Color = "Grey",
                           Weight = 5,
                           Price = 550,
                           Shape = "Rec tangle",
                           Rating = 10

                       }
                 );
                 context.SaveChanges();
            }
        }
    }
 }
