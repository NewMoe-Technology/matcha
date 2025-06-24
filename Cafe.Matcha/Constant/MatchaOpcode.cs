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
            { 0x28C, MatchaOpcode.ActorControl },
            { 0x272, MatchaOpcode.ActorControlSelf },
            { 0x8B, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x255, MatchaOpcode.CompanyAirshipStatus },
            { 0x201, MatchaOpcode.CompanySubmersibleStatus },
            { 0x3BE, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0xEA, MatchaOpcode.ResumeEventScene32 },
            { 0x335, MatchaOpcode.EventPlay },
            { 0x3A2, MatchaOpcode.EventStart },
            { 0x1A6, MatchaOpcode.Examine },
            { 0x27A, MatchaOpcode.FateInfo },
            { 0xCE, MatchaOpcode.InitZone },
            { 0x2D1, MatchaOpcode.InventoryTransaction },
            { 0x1F3, MatchaOpcode.ItemInfo },
            { 0x241, MatchaOpcode.MarketBoardItemListing },
            { 0x268, MatchaOpcode.MarketBoardItemListingCount },
            { 0x297, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x2CA, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x3BF, MatchaOpcode.NpcSpawn },
            { 0x31D, MatchaOpcode.PlayerSetup },
            { 0x266, MatchaOpcode.PlayerSpawn },
            { 0x358, MatchaOpcode.WorldVisitQueue },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0344, MatchaOpcode.ActorControl },
            { 0x0393, MatchaOpcode.ActorControlSelf },
            { 0x02D4, MatchaOpcode.CEDirector },
            { 0x01D7, MatchaOpcode.CompanyAirshipStatus },
            { 0x03D7, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0181, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0133, MatchaOpcode.ResumeEventScene32 },
            { 0x031F, MatchaOpcode.EventPlay },
            { 0x01F9, MatchaOpcode.EventStart },
            { 0x02F9, MatchaOpcode.Examine },
            { 0x032E, MatchaOpcode.FateInfo },
            { 0x012A, MatchaOpcode.InitZone },
            { 0x009A, MatchaOpcode.InventoryTransaction },
            { 0x030F, MatchaOpcode.ItemInfo },
            { 0x0085, MatchaOpcode.MarketBoardItemListing },
            { 0x01C8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x00E7, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8069, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x014F, MatchaOpcode.NpcSpawn },
            { 0x00CD, MatchaOpcode.PlayerSetup },
            { 0x00DC, MatchaOpcode.PlayerSpawn },
            { 0x025D, MatchaOpcode.WorldVisitQueue },
        };
    }
}
