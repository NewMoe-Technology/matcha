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
        /*
         * CompanyAirshipStatus -> AirshipTimers
         * CompanySubmersibleStatus -> SubmarineTimers
         * ResumeEventScene32 -> MiniCactpotInit
         */
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02C8, MatchaOpcode.ActorControl },
            { 0x02B3, MatchaOpcode.ActorControlSelf },
            { 0x00F5, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x03C6, MatchaOpcode.CompanyAirshipStatus },
            { 0x0267, MatchaOpcode.CompanySubmersibleStatus },
            { 0x024F, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x03CE, MatchaOpcode.ResumeEventScene32 },
            { 0x0352, MatchaOpcode.EventPlay },
            { 0x02F8, MatchaOpcode.EventStart },
            { 0x0235, MatchaOpcode.Examine },
            { 0x020E, MatchaOpcode.FateInfo },
            { 0x01A4, MatchaOpcode.InitZone },
            { 0x01A9, MatchaOpcode.InventoryTransaction },
            { 0x0278, MatchaOpcode.ItemInfo },
            { 0x0069, MatchaOpcode.MarketBoardItemListing },
            { 0x0210, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0377, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8389, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x02E8, MatchaOpcode.NpcSpawn },
            { 0x00D7, MatchaOpcode.PlayerSetup },
            { 0x013E, MatchaOpcode.PlayerSpawn },
            { 0x0389, MatchaOpcode.WorldVisitQueue },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02C8, MatchaOpcode.ActorControl },
            { 0x02B3, MatchaOpcode.ActorControlSelf },
            { 0x00F5, MatchaOpcode.CEDirector },
            { 0x03C6, MatchaOpcode.CompanyAirshipStatus },
            { 0x0267, MatchaOpcode.CompanySubmersibleStatus },
            { 0x024F, MatchaOpcode.ContentFinderNotifyPop },
            { 0x03CE, MatchaOpcode.ResumeEventScene32 },
            { 0x0352, MatchaOpcode.EventPlay },
            { 0x02F8, MatchaOpcode.EventStart },
            { 0x0235, MatchaOpcode.Examine },
            { 0x020E, MatchaOpcode.FateInfo },
            { 0x01A4, MatchaOpcode.InitZone },
            { 0x01A9, MatchaOpcode.InventoryTransaction },
            { 0x0278, MatchaOpcode.ItemInfo },
            { 0x0069, MatchaOpcode.MarketBoardItemListing },
            { 0x0210, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0377, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8389, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x02E8, MatchaOpcode.NpcSpawn },
            { 0x00D7, MatchaOpcode.PlayerSetup },
            { 0x013E, MatchaOpcode.PlayerSpawn },
            { 0x0389, MatchaOpcode.WorldVisitQueue },
        };
    }
}
