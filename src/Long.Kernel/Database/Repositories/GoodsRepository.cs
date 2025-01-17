﻿using Long.Database.Entities;

namespace Long.Kernel.Database.Repositories
{
    public static class GoodsRepository
    {
        public static async Task<List<DbGoods>> GetAsync(uint idNpc)
        {
            await using ServerDbContext context = new();
            return context.Goods.Where(x => x.OwnerIdentity == idNpc).ToList();
        }

        public static async Task<List<DbGoodsReminiscence>> GetExAsync(uint idNpc)
        {
            await using ServerDbContext context = new();
            return context.GoodsReminiscences.Where(x => x.OwnerIdentity == idNpc).ToList();
        }
    }
}
