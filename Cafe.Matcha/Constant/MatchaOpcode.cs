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
            { 0x02e0, MatchaOpcode.ActorControl },
            { 0x01f4, MatchaOpcode.ActorControlSelf },
            { 0x038B, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x037f, MatchaOpcode.CompanyAirshipStatus },
            { 0x01b0, MatchaOpcode.CompanySubmersibleStatus },
            { 0x019f, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x039a, MatchaOpcode.ResumeEventScene32 },
            { 0x00a3, MatchaOpcode.EventPlay },
            { 0x0253, MatchaOpcode.EventStart },
            { 0x031b, MatchaOpcode.Examine },
            { 0x0141, MatchaOpcode.FateInfo },
            { 0x036c, MatchaOpcode.InitZone },
            { 0x0192, MatchaOpcode.InventoryTransaction },
            { 0x02a4, MatchaOpcode.ItemInfo },
            { 0x0103, MatchaOpcode.MarketBoardItemListing },
            { 0x03cd, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0077, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x012A, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00c4, MatchaOpcode.NpcSpawn },
            { 0x0359, MatchaOpcode.PlayerSetup },
            { 0x037a, MatchaOpcode.PlayerSpawn },
            { 0x00A8, MatchaOpcode.WorldVisitQueue },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0099, MatchaOpcode.ActorControl },
            { 0x025E, MatchaOpcode.ActorControlSelf },
            { 0x014E, MatchaOpcode.CEDirector },
            { 0x019A, MatchaOpcode.CompanyAirshipStatus },
            { 0x02DD, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0246, MatchaOpcode.ContentFinderNotifyPop },
            { 0x020C, MatchaOpcode.ResumeEventScene32 },
            { 0x0380, MatchaOpcode.EventPlay },
            { 0x02B9, MatchaOpcode.EventStart },
            { 0x0097, MatchaOpcode.Examine },
            { 0x02A3, MatchaOpcode.FateInfo },
            { 0x00CE, MatchaOpcode.InitZone },
            { 0x01D6, MatchaOpcode.InventoryTransaction },
            { 0x032D, MatchaOpcode.ItemInfo },
            { 0x020E, MatchaOpcode.MarketBoardItemListing },
            { 0x01BE, MatchaOpcode.MarketBoardItemListingCount },
            { 0x03AD, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x80EF, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x01F6, MatchaOpcode.NpcSpawn },
            { 0x00D8, MatchaOpcode.PlayerSetup },
            { 0x0222, MatchaOpcode.PlayerSpawn },
            { 0x0334, MatchaOpcode.WorldVisitQueue },
        };
    }
}
