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
        DirectorStart,
        EventPlay,
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
    }

    internal static class OpcodeStorage
    {
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0178, MatchaOpcode.ActorControl },
            { 0x02a7, MatchaOpcode.ActorControlSelf },
            { 0x0262, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x0371, MatchaOpcode.CompanyAirshipStatus },
            { 0x00f8, MatchaOpcode.CompanySubmersibleStatus },
            { 0x014f, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0083, MatchaOpcode.DirectorStart },
            { 0x026d, MatchaOpcode.EventPlay },
            { 0x0326, MatchaOpcode.Examine },
            { 0x020a, MatchaOpcode.FateInfo },
            { 0x01f1, MatchaOpcode.InitZone },
            { 0x00e8, MatchaOpcode.InventoryTransaction },
            { 0x0236, MatchaOpcode.ItemInfo },
            { 0x01c3, MatchaOpcode.MarketBoardItemListing },
            { 0x00a0, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0102, MatchaOpcode.MarketBoardItemListingHistory },
            { 0xf010, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0186, MatchaOpcode.NpcSpawn },
            { 0x00c6, MatchaOpcode.PlayerSetup },
            { 0x024f, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0311, MatchaOpcode.ActorControl },
            { 0x01a9, MatchaOpcode.ActorControlSelf },
            { 0x02c9, MatchaOpcode.CEDirector },
            { 0x018b, MatchaOpcode.CompanyAirshipStatus },
            { 0x0371, MatchaOpcode.CompanySubmersibleStatus },
            { 0x00bf, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0089, MatchaOpcode.DirectorStart },
            { 0x039a, MatchaOpcode.EventPlay },
            { 0x02dd, MatchaOpcode.Examine },
            { 0x00a3, MatchaOpcode.FateInfo },
            { 0x025d, MatchaOpcode.InitZone },
            { 0x0356, MatchaOpcode.InventoryTransaction },
            { 0x0110, MatchaOpcode.ItemInfo },
            { 0x0171, MatchaOpcode.MarketBoardItemListing },
            { 0x0323, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0382, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8142, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x021a, MatchaOpcode.NpcSpawn },
            { 0x0212, MatchaOpcode.PlayerSetup },
            { 0x03c5, MatchaOpcode.PlayerSpawn },
        };
    }
}
