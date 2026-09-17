// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Constant
{
    using System.Collections.Generic;

    internal enum MatchaOpcode
    {
        ActorControl,
        ActorControlSelf,
        CEDirector,
        CompanyAirshipStatus,
        CompanySubmersibleStatus,
        ContentFinderNotifyPop,
        ResumeEventScene32,
        EventPlay,
        EventStart,
        Examine,
        FateInfo,
        InitZone,
        InventoryTransaction,
        ItemInfo,
        MarketBoardItemListing,
        MarketBoardItemListingCount,
        MarketBoardItemListingHistory,
        MarketBoardRequestItemListingInfo,
        NpcSpawn,
        PlayerSetup,
        PlayerSpawn,
        SubmarineStatusList,
        WorldVisitQueue,
    }

    internal static class OpcodeStorage
    {
        /* Ipcs_cn.cs 7.56a (CN_2026.09.15) — direct name match
         * Client zone opcodes carry the 0x8000 direction bit (see Packet.cs).
         *
         * TODO: not named in Ipcs_cn.cs, values are still carried over from 7.56
         * and need manual verification:
         *   ItemInfo              = 0x0073
         *   InventoryTransaction  = 0x024E
         *   ResumeEventScene32 (MiniCactpotInit) = 0x0335
         */
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x025F, MatchaOpcode.ActorControl },
            { 0x0204, MatchaOpcode.ActorControlSelf },
            { 0x031E, MatchaOpcode.CEDirector },
            { 0x006C, MatchaOpcode.CompanyAirshipStatus },
            { 0x01EC, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0333, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0335, MatchaOpcode.ResumeEventScene32 },
            { 0x01FD, MatchaOpcode.EventPlay },
            { 0x02E1, MatchaOpcode.EventStart },
            { 0x01F2, MatchaOpcode.Examine },
            { 0x0154, MatchaOpcode.FateInfo },
            { 0x032B, MatchaOpcode.InitZone },
            { 0x024E, MatchaOpcode.InventoryTransaction },
            { 0x0073, MatchaOpcode.ItemInfo },
            { 0x034D, MatchaOpcode.MarketBoardItemListing },
            { 0x00C0, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0241, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8320, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x020C, MatchaOpcode.NpcSpawn },
            { 0x0093, MatchaOpcode.PlayerSetup },
            { 0x01C4, MatchaOpcode.PlayerSpawn },
            { 0x038A, MatchaOpcode.SubmarineStatusList },
            { 0x01E8, MatchaOpcode.WorldVisitQueue },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x025F, MatchaOpcode.ActorControl },
            { 0x0204, MatchaOpcode.ActorControlSelf },
            { 0x031E, MatchaOpcode.CEDirector },
            { 0x006C, MatchaOpcode.CompanyAirshipStatus },
            { 0x01EC, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0333, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0335, MatchaOpcode.ResumeEventScene32 },
            { 0x01FD, MatchaOpcode.EventPlay },
            { 0x02E1, MatchaOpcode.EventStart },
            { 0x01F2, MatchaOpcode.Examine },
            { 0x0154, MatchaOpcode.FateInfo },
            { 0x032B, MatchaOpcode.InitZone },
            { 0x024E, MatchaOpcode.InventoryTransaction },
            { 0x0073, MatchaOpcode.ItemInfo },
            { 0x034D, MatchaOpcode.MarketBoardItemListing },
            { 0x00C0, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0241, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8320, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x020C, MatchaOpcode.NpcSpawn },
            { 0x0093, MatchaOpcode.PlayerSetup },
            { 0x01C4, MatchaOpcode.PlayerSpawn },
            { 0x038A, MatchaOpcode.SubmarineStatusList },
            { 0x01E8, MatchaOpcode.WorldVisitQueue },
        };
    }
}
