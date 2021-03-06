﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WolfPeopleKill.Models;

namespace WolfPeopleKill.Interfaces
{
    public interface IShopRepo
    {
        /// <summary>
        /// get shop
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Shop> GetShop();
    }
}
