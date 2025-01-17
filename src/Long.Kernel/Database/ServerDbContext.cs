﻿using Long.Database;
using Long.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data;
using Long.Database.Entities.Long.Database.Entities;

namespace Long.Kernel.Database
{
    public class ServerDbContext : AbstractDbContext
    {
        private static readonly ILogger logger = Log.ForContext<ServerDbContext>();

        public virtual DbSet<DbAnnounce> Announces { get; set; }
        public virtual DbSet<DbUser> Users { get; set; }
        public virtual DbSet<DbDelUser> Delusers { get; set; }
        public virtual DbSet<DbNobility> Nobilities { get; set; }
        public virtual DbSet<DbMap> Maps { get; set; }
        public virtual DbSet<DbDynamap> DynaMaps { get; set; }
        public virtual DbSet<DbPassway> Passways { get; set; }
        public virtual DbSet<DbPortal> Portals { get; set; }
        public virtual DbSet<DbRegion> Regions { get; set; }
        public virtual DbSet<DbPointAllot> PointAllots { get; set; }
        public virtual DbSet<DbNewbieInfo> NewbieInfo { get; set; }
        public virtual DbSet<DbItemtype> Itemtypes { get; set; }
        public virtual DbSet<DbItemAddition> ItemAdditions { get; set; }
        public virtual DbSet<DbFlower> Flowers { get; set; }
        public virtual DbSet<DbGetFlower> GetFlowers { get; set; }
        public virtual DbSet<DbLeaveword> Leavewords { get; set; }
        public virtual DbSet<DbSysLeaveword> SysLeavewords { get; set; }
        public virtual DbSet<DbDynaRankRec> DynaRankRecs { get; set; }
        public virtual DbSet<DbDynaRankRecType> DynaRankRecTypes { get; set; }
        public virtual DbSet<DbItem> Items { get; set; }
        public virtual DbSet<DbItemStatus> ItemStatus { get; set; }
        public virtual DbSet<DbWeaponSkill> WeaponSkills { get; set; }
        public virtual DbSet<DbWeaponSkillUp> WeaponSkillUps { get; set; }
        public virtual DbSet<DbMonstertype> Monstertypes { get; set; }
        public virtual DbSet<DbMonsterTypeMagic> MonsterTypeMagics { get; set; }
        public virtual DbSet<DbItemDrop> ItemDrops { get; set; }
        public virtual DbSet<DbItemPickUp> ItemPickUps { get; set; }
        public virtual DbSet<DbSuperFlag> SuperFlags { get; set; }
        public virtual DbSet<DbGoods> Goods { get; set; }
        public virtual DbSet<DbGoodsReminiscence> GoodsReminiscences { get; set; }
        public virtual DbSet<DbAction> Actions { get; set; }
        public virtual DbSet<DbTask> Tasks { get; set; }
        public virtual DbSet<DbNpc> Npcs { get; set; }
        public virtual DbSet<DbDynanpc> DynamicNpcs { get; set; }
        public virtual DbSet<DbConfig> Configs { get; set; }
        public virtual DbSet<DbDynaGlobalData> DynaGlobalDatas { get; set; }
        public virtual DbSet<DbStatistic> Statistics { get; set; }
        public virtual DbSet<DbStatisticDaily> DailyStatistics { get; set; }
        public virtual DbSet<DbTaskDetail> TaskDetails { get; set; }
        public virtual DbSet<DbMagic> Magics { get; set; }
        public virtual DbSet<DbItemLimit> ItemsLimit { get; set; }
        public virtual DbSet<DbMagic> Magic { get; set; }
        public virtual DbSet<DbMagictype> Magictypes { get; set; }
        public virtual DbSet<DbTrack> Tracks { get; set; }
        public virtual DbSet<DbStatus> Status { get; set; }
        public virtual DbSet<DbLevelExperience> LevelExperiences { get; set; }
        public virtual DbSet<DbSoulValueLev>SoulValueLevs { get; set; }
        public virtual DbSet<DbSuperman> Supermen { get; set; }
        public virtual DbSet<DbInstanceType> InstanceTypes { get; set; }
        public virtual DbSet<DbFriend> Friends { get; set; }
        public virtual DbSet<DbEnemy> Enemies { get; set; }
        public virtual DbSet<DbPartner> Partners { get; set; }
        public virtual DbSet<DbTrade> Trades { get; set; }
        public virtual DbSet<DbTradeItem> TradeItems { get; set; }
        public virtual DbSet<DbGhostContract> GhostContracts { get; set; }
        public virtual DbSet<DbQuiz> QuizQuestions { get; set; }
        public virtual DbSet<DbVipTransPoint> VipTransPoints { get; set; }
        public virtual DbSet<DbVipMineTime> VipMineTime { get; set; }
        public virtual DbSet<DbFamily> Families { get; set; }
        public virtual DbSet<DbFamilyAttr> FamilyAttrs { get; set; }
        public virtual DbSet<DbFamilyBattleEffectShareLimit> FamilyBattleEffectShareLimits { get; set; }
        public virtual DbSet<DbSyndicate> Syndicates { get; set; }
        public virtual DbSet<DbSyndicateAttr> SyndicatesAttr { get; set; }
        public virtual DbSet<DbSyndicateMemberHistory> SyndicateMemberHistories { get; set; }
        public virtual DbSet<DbTotemAdd> TotemAdds { get; set; }
        public virtual DbSet<DbSynAdvertisingInfo> SynAdvertisingInfos { get; set; }
        public virtual DbSet<DbPigeon> Pigeons { get; set; }
        public virtual DbSet<DbPigeonQueue> PigeonQueues { get; set; }
        public virtual DbSet<DbAchievement> Achievements { get; set; }
        public virtual DbSet<DbAchievementType> AchievementTypes { get; set; }
        public virtual DbSet<DbMail> Mails { get; set; }
        public virtual DbSet<DbAuction> Auctions { get; set; }
        public virtual DbSet<DbAuctionAskBuy> AuctionAskBuys { get; set; }
        public virtual DbSet<DbTutor> Tutor { get; set; }
        public virtual DbSet<DbTutorAccess> TutorAccess { get; set; }
        public virtual DbSet<DbTutorBattleLimitType> TutorBattleLimitTypes { get; set; }
        public virtual DbSet<DbTutorContribution> TutorContributions { get; set; }
        public virtual DbSet<DbTutorType> TutorTypes { get; set; }
        public virtual DbSet<DbActivityRewardType> ActivityRewardTypes { get; set; }
        public virtual DbSet<DbActivityTaskType> ActivityTaskTypes { get; set; }
        public virtual DbSet<DbActivityUserTask> ActivityUserTasks { get; set; }
        public virtual DbSet<DbDailyReset> DailyResets { get; set; }
        public virtual DbSet<DbDisdain>Disdains { get; set; }
        public virtual DbSet<DbMessageLog> MessageLogs { get; set; }
        public virtual DbSet<DbEMoney> EMoneyLogs { get; set; }
        public virtual DbSet<DbEMoneyMono> EMoneyMonoLogs { get; set; }
        public virtual DbSet<DbGrade> Grades { get; set; }
        public virtual DbSet<DbDropItemRule> DropItemRules { get; set; }
        public virtual DbSet<DbShortcutKey> ShortcutKeys { get; set; }
        public virtual DbSet<DbLottery> Lottery { get; set; }
        public virtual DbSet<DbTrap> Traps { get; set; }
        public virtual DbSet<DbTrapType> TrapTypes { get; set; }

        public virtual DbSet<DbEudemon> Eudemons { get; set; }
        public virtual DbSet<DbEudemonRbnRqr> EudemonRbnRqrs { get; set; }
        public virtual DbSet<DbEudemonRbnType> EudemonRbnTypes { get; set; }
        public virtual DbSet<DbOfficialType> OfficialTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DbLevelExperience>().HasNoKey();
            modelBuilder.Entity<DbSuperman>().Property(x => x.UserIdentity).ValueGeneratedNever();
        }

        public static async Task<bool> CreateAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class
        {
            try
            {
                await using var serverDbContext = new ServerDbContext();
                serverDbContext.Add<T>(entity);
                await serverDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "[{0}] CreateAsync has throw: {1}", typeof(T).FullName, ex.Message);
                return false;
            }
        }

        public async static Task<bool> CreateRangeAsync<T>(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            try
            {
                await using var serverDbContext = new ServerDbContext();
                foreach (var entity in entities)
                {
                    serverDbContext.Add(entity);
                }
                await serverDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "[{0}] CreateRangeAsync has throw: {1}", typeof(T).FullName, ex.Message);
                return false;
            }
        }

        public static async Task<bool> UpdateAsync<T>(T entity, CancellationToken cancellationToken = default)
        {
            try
            {
                await using var serverDbContext = new ServerDbContext();
                serverDbContext.Update(entity);
                await serverDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "[{0}] SaveAsync has throw: {1}", typeof(T).FullName, ex.Message);
                return false;
            }
        }

        public static async Task<bool> UpdateRangeAsync<T>(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            try
            {
                await using var serverDbContext = new ServerDbContext();
                foreach (var entity in entities)
                {
                    serverDbContext.Update(entity);
                }
                await serverDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "[{0}] SaveRangeAsync has throw: {1}", typeof(T).FullName, ex.Message);
                return false;
            }
        }

        public static async Task<bool> DeleteAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class
        {
            try
            {
                await using var serverDbContext = new ServerDbContext();
                serverDbContext.Remove(entity);
                await serverDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "[{0}] DeleteAsync has throw: {1}", typeof(T).FullName, ex.Message);
                return false;
            }
        }

        public static async Task<bool> DeleteRangeAsync<T>(IEnumerable<T> entities, CancellationToken cancellationToken = default)
            where T : class
        {
            try
            {
                await using var serverDbContext = new ServerDbContext();
                foreach (var entity in entities)
                {
                    serverDbContext.Remove(entity);
                }
                await serverDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "[{0}] DeleteRangeAsync has throw: {1}", typeof(T).FullName, ex.Message);
                return false;
            }
        }

        public static async Task<string> ScalarAsync(string query)
        {
            await using var db = new ServerDbContext();
            DbConnection connection = db.Database.GetDbConnection();
            string result;
            try
            {
                if ((connection.State & ConnectionState.Open) == 0)
                {
                    await connection.OpenAsync();
                }

                DbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                result = (await cmd.ExecuteScalarAsync())?.ToString();
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    await connection.CloseAsync();
                }
            }
            return result;
        }
    }
}
