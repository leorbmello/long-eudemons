﻿using Long.Database.Entities;
using Long.Kernel.Database;

namespace Long.Kernel.Database.Repositories
{
    public static class SyndicateAttrRepository
    {
        public static async Task<List<DbSyndicateAttr>> GetAsync(uint idSyn)
        {
            await using var db = new ServerDbContext();
            return db.SyndicatesAttr.Where(x => x.SynId == idSyn).ToList();
        }
    }
}
