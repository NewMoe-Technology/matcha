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
        WorldVisitQueue,
    }

    internal static class OpcodeStorage
    {
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x3D1, MatchaOpcode.ActorControl },
            { 0x120, MatchaOpcode.ActorControlSelf },
            { 0x327, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x23C, MatchaOpcode.CompanyAirshipStatus },
            { 0x2EC, MatchaOpcode.CompanySubmersibleStatus },
            { 0xC2, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x253, MatchaOpcode.ResumeEventScene32 },
            { 0x1ED, MatchaOpcode.EventPlay },
            { 0xFB, MatchaOpcode.EventStart },
            { 0x1AF, MatchaOpcode.Examine },
            { 0xEB, MatchaOpcode.FateInfo },
            { 0x309, MatchaOpcode.InitZone },
            { 0x156, MatchaOpcode.InventoryTransaction },
            { 0x1EF, MatchaOpcode.ItemInfo },
            { 0xD8, MatchaOpcode.MarketBoardItemListing },
            { 0x2C7, MatchaOpcode.MarketBoardItemListingCount },
            { 0x29B, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x1EA, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0xE0, MatchaOpcode.NpcSpawn },
            { 0x141, MatchaOpcode.PlayerSetup },
            { 0x21E, MatchaOpcode.PlayerSpawn },
            { 0x2F0, MatchaOpcode.WorldVisitQueue },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02E1, MatchaOpcode.ActorControl },
            { 0x01D2, MatchaOpcode.ActorControlSelf },
            { 0x026D, MatchaOpcode.CEDirector },
            { 0x01A3, MatchaOpcode.CompanyAirshipStatus },
            { 0x02FB, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0217, MatchaOpcode.ContentFinderNotifyPop },
            { 0x020c, MatchaOpcode.ResumeEventScene32 },
            { 0x01FB, MatchaOpcode.EventPlay },
            { 0x0072, MatchaOpcode.EventStart },
            { 0x02FD, MatchaOpcode.Examine },
            { 0x00AB, MatchaOpcode.FateInfo },
            { 0x0148, MatchaOpcode.InitZone },
            { 0x01d6, MatchaOpcode.InventoryTransaction },
            { 0x032d, MatchaOpcode.ItemInfo },
            { 0x0128, MatchaOpcode.MarketBoardItemListing },
            { 0x0248, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0190, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x810A, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00D8, MatchaOpcode.NpcSpawn },
            { 0x0299, MatchaOpcode.PlayerSetup },
            { 0x0107, MatchaOpcode.PlayerSpawn },
            { 0x039A, MatchaOpcode.WorldVisitQueue },
        };
    }
}
