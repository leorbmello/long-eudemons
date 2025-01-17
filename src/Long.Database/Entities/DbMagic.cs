﻿namespace Long.Database.Entities
{
    [Table("cq_magic")]
    public class DbMagic
    {
        [Key][Column("id")] public virtual uint Id { get; set; }
        [Column("ownerid")] public virtual uint OwnerId { get; set; }
        [Column("type")] public virtual ushort Type { get; set; }
        [Column("level")] public virtual ushort Level { get; set; }
        [Column("exp")] public virtual uint Experience { get; set; }
        [Column("unlearn")] public virtual byte Unlearn { get; set; }
        [Column("old_level")] public virtual ushort OldLevel { get; set; }

        [NotMapped] public virtual bool TempMagic { get; set; }
    }
}