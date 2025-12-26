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
            { 0x019B, MatchaOpcode.ActorControl },
            { 0x0347, MatchaOpcode.ActorControlSelf },
            { 0x0305, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x03D5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0139, MatchaOpcode.CompanySubmersibleStatus },
            { 0x03A7, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0199, MatchaOpcode.ResumeEventScene32 },
            { 0x0332, MatchaOpcode.EventPlay },
            { 0x03DA, MatchaOpcode.EventStart },
            { 0x0070, MatchaOpcode.Examine },
            { 0x038A, MatchaOpcode.FateInfo },
            { 0x0242, MatchaOpcode.InitZone },
            { 0x02B7, MatchaOpcode.InventoryTransaction },
            { 0x00EB, MatchaOpcode.ItemInfo },
            { 0x01AD, MatchaOpcode.MarketBoardItemListing },
            { 0x01D8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x025C, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x836F, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x039B, MatchaOpcode.NpcSpawn },
            { 0x0256, MatchaOpcode.PlayerSetup },
            { 0x00CA, MatchaOpcode.PlayerSpawn },
            { 0x036F, MatchaOpcode.WorldVisitQueue },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x019B, MatchaOpcode.ActorControl },
            { 0x0347, MatchaOpcode.ActorControlSelf },
            { 0x0305, MatchaOpcode.CEDirector },
            { 0x03D5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0139, MatchaOpcode.CompanySubmersibleStatus },
            { 0x03A7, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0199, MatchaOpcode.ResumeEventScene32 },
            { 0x0332, MatchaOpcode.EventPlay },
            { 0x03DA, MatchaOpcode.EventStart },
            { 0x0070, MatchaOpcode.Examine },
            { 0x038A, MatchaOpcode.FateInfo },
            { 0x0242, MatchaOpcode.InitZone },
            { 0x02B7, MatchaOpcode.InventoryTransaction },
            { 0x00EB, MatchaOpcode.ItemInfo },
            { 0x01AD, MatchaOpcode.MarketBoardItemListing },
            { 0x01D8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x025C, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x836F, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x039B, MatchaOpcode.NpcSpawn },
            { 0x0256, MatchaOpcode.PlayerSetup },
            { 0x00CA, MatchaOpcode.PlayerSpawn },
            { 0x036F, MatchaOpcode.WorldVisitQueue },
        };
    }
}
