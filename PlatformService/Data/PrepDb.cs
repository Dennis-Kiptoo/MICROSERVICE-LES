using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app){
         using (var serviceScope =app.ApplicationServices.CreateScope()){
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());


         }    



        }
        private static void SeedData (AppDbContext context){
            if(!context.Platforms.Any()){

                Console.WriteLine("--> Seeding Data...");
                context.Platforms.AddRange(
                    new Platform(){
                        Name = "Dot Net",
                        Publisher= "MicroSoft",
                        Cost = "Free"
                    },

                    new Platform (){
                        Name = "Intellij",
                        Publisher= "JetBrains",
                        Cost ="100$",    

                    },
                       new Platform (){
                        Name = "Intellij",
                        Publisher= "JetBrains",
                        Cost ="150$",    

                    }


                );

                context.SaveChanges();

            }
            else{
               Console.WriteLine("--> we already have data") ;
            }
            
        }
        
    }
}