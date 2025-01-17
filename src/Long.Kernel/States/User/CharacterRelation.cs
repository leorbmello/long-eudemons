﻿using Long.Kernel.Modules.Systems.Relation;
using Long.Kernel.Modules.Systems.Trade;
using Long.Kernel.Network.Game.Packets;

namespace Long.Kernel.States.User
{
    public partial class Character
    {
        #region Marriage

        public bool IsMate(Character user)
        {
            return user.Identity == MateIdentity;
        }

        public bool IsMate(uint idMate)
        {
            return idMate == MateIdentity;
        }

        #endregion

        #region Relation

        public IRelation Relation { get; set; }

        #endregion

        #region Trade Partner

        public ITradePartnerRelation TradePartnerRelation { get; set; }

        public bool IsValidTradePartner(uint userId)
        {
            if (TradePartnerRelation == null)
            {
                return true;
            }

            return TradePartnerRelation.IsValidTradePartner(userId);
        }

        #endregion
    }
}
