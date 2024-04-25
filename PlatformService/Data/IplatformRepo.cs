using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IplatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPLatforms();

        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);

    }
}