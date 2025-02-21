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
            { 0x1E2, MatchaOpcode.ActorControl },
            { 0x393, MatchaOpcode.ActorControlSelf },
            { 0x335, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x1EC, MatchaOpcode.CompanyAirshipStatus },
            { 0x26C, MatchaOpcode.CompanySubmersibleStatus },
            { 0x2FD, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x35B, MatchaOpcode.ResumeEventScene32 },
            { 0x0159, MatchaOpcode.EventPlay },
            { 0x00c1, MatchaOpcode.EventStart },
            { 0x1B3, MatchaOpcode.Examine },
            { 0x1C0, MatchaOpcode.FateInfo },
            { 0x2F0, MatchaOpcode.InitZone },
            { 0x18A, MatchaOpcode.InventoryTransaction },
            { 0x0119, MatchaOpcode.ItemInfo },
            { 0x1DE, MatchaOpcode.MarketBoardItemListing },
            { 0x27B, MatchaOpcode.MarketBoardItemListingCount },
            { 0xBF, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x166, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x39A, MatchaOpcode.NpcSpawn },
            { 0x36A, MatchaOpcode.PlayerSetup },
            { 0x325, MatchaOpcode.PlayerSpawn },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02BF, MatchaOpcode.ActorControl },
            { 0x0119, MatchaOpcode.ActorControlSelf },
            { 0x036A, MatchaOpcode.CEDirector },
            { 0x0291, MatchaOpcode.CompanyAirshipStatus },
            { 0x01B4, MatchaOpcode.CompanySubmersibleStatus },
            { 0x01AD, MatchaOpcode.ContentFinderNotifyPop },
            { 0x01FE, MatchaOpcode.ResumeEventScene32 },
            { 0x008A, MatchaOpcode.EventPlay },
            { 0x02BD, MatchaOpcode.Examine },
            { 0x02B4, MatchaOpcode.FateInfo },
            { 0x0108, MatchaOpcode.InitZone },
            { 0x0162, MatchaOpcode.InventoryTransaction },
            { 0x03A9, MatchaOpcode.ItemInfo },
            { 0x0207, MatchaOpcode.MarketBoardItemListing },
            { 0x026E, MatchaOpcode.MarketBoardItemListingCount },
            { 0x010E, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x81BF, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x03BB, MatchaOpcode.NpcSpawn },
            { 0x0215, MatchaOpcode.PlayerSetup },
            { 0x01DD, MatchaOpcode.PlayerSpawn },
        };
    }
}
