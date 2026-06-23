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
         * ResumeEventScene32 -> MiniCactpotInit (EventPlay32: 0x018D -> 0x8A via diff)
         * InventoryTransaction -> InventoryActionAck (0x00C6 -> 0x219 via diff)
         * ItemInfo -> UpdateInventorySlot (0x00E2 -> 0x123 via diff)
         */
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x019F, MatchaOpcode.ActorControl },
            { 0x0164, MatchaOpcode.ActorControlSelf },
            { 0x0377, MatchaOpcode.CEDirector },
            { 0x03C5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0066, MatchaOpcode.CompanySubmersibleStatus },
            { 0x024B, MatchaOpcode.ContentFinderNotifyPop },
            { 0x008A, MatchaOpcode.ResumeEventScene32 },
            { 0x013E, MatchaOpcode.EventPlay },
            { 0x0202, MatchaOpcode.EventStart },
            { 0x032C, MatchaOpcode.Examine },
            { 0x022E, MatchaOpcode.FateInfo },
            { 0x0337, MatchaOpcode.InitZone },
            { 0x0219, MatchaOpcode.InventoryTransaction },
            { 0x0123, MatchaOpcode.ItemInfo },
            { 0x00ED, MatchaOpcode.MarketBoardItemListing },
            { 0x0227, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0353, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x80AA, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0378, MatchaOpcode.NpcSpawn },
            { 0x0110, MatchaOpcode.PlayerSetup },
            { 0x02E0, MatchaOpcode.PlayerSpawn },
            { 0x0329, MatchaOpcode.WorldVisitQueue },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x019F, MatchaOpcode.ActorControl },
            { 0x0164, MatchaOpcode.ActorControlSelf },
            { 0x0377, MatchaOpcode.CEDirector },
            { 0x03C5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0066, MatchaOpcode.CompanySubmersibleStatus },
            { 0x024B, MatchaOpcode.ContentFinderNotifyPop },
            { 0x008A, MatchaOpcode.ResumeEventScene32 },
            { 0x013E, MatchaOpcode.EventPlay },
            { 0x0202, MatchaOpcode.EventStart },
            { 0x032C, MatchaOpcode.Examine },
            { 0x022E, MatchaOpcode.FateInfo },
            { 0x0337, MatchaOpcode.InitZone },
            { 0x0219, MatchaOpcode.InventoryTransaction },
            { 0x0123, MatchaOpcode.ItemInfo },
            { 0x00ED, MatchaOpcode.MarketBoardItemListing },
            { 0x0227, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0353, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x80AA, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0378, MatchaOpcode.NpcSpawn },
            { 0x0110, MatchaOpcode.PlayerSetup },
            { 0x02E0, MatchaOpcode.PlayerSpawn },
            { 0x0329, MatchaOpcode.WorldVisitQueue },
        };
    }
}
