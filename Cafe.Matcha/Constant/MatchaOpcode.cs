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
        EventPlay4,
        SystemLogMessage,
        FishCaught,
        StatusEffectList,
        ClientTrigger,
    }

    internal static class OpcodeStorage
    {
        /* Ipcs_cn.cs 7.57 (CN_2026.10.06) — direct name match
         * Client zone opcodes carry the 0x8000 direction bit (see Packet.cs).
         *
         * Not named in Ipcs_cn.cs — resolved via xivdev/opcodediff 7.57.diff.json
         * (7.56a -> 7.57; mapping validated against all 20 known opcodes):
         *   ItemInfo              0x0084 -> 0x00D1
         *   InventoryTransaction  0x023A -> 0x032D
         *   ResumeEventScene32    0x024D -> 0x01FE (MiniCactpotInit)
         *   FishCaught            0x0110 -> 0x03CB
         *
         * Client zone opcodes take the 0x8000 bit (Ipcs_cn.cs raw value shown):
         *   ClientTrigger         0x0368 -> 0x8368 (see FishingHandler.cs)
         */
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0198, MatchaOpcode.ActorControl },
            { 0x01E6, MatchaOpcode.ActorControlSelf },
            { 0x020A, MatchaOpcode.CEDirector },
            { 0x0178, MatchaOpcode.CompanyAirshipStatus },
            { 0x039C, MatchaOpcode.CompanySubmersibleStatus },
            { 0x028A, MatchaOpcode.ContentFinderNotifyPop },
            { 0x01FE, MatchaOpcode.ResumeEventScene32 },
            { 0x0256, MatchaOpcode.EventPlay },
            { 0x0286, MatchaOpcode.EventStart },
            { 0x019C, MatchaOpcode.Examine },
            { 0x0259, MatchaOpcode.FateInfo },
            { 0x02CC, MatchaOpcode.InitZone },
            { 0x032D, MatchaOpcode.InventoryTransaction },
            { 0x00D1, MatchaOpcode.ItemInfo },
            { 0x0234, MatchaOpcode.MarketBoardItemListing },
            { 0x010D, MatchaOpcode.MarketBoardItemListingCount },
            { 0x011E, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8248, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0114, MatchaOpcode.NpcSpawn },
            { 0x0302, MatchaOpcode.PlayerSetup },
            { 0x0265, MatchaOpcode.PlayerSpawn },
            { 0x0367, MatchaOpcode.SubmarineStatusList },
            { 0x007C, MatchaOpcode.WorldVisitQueue },
            { 0x0324, MatchaOpcode.EventPlay4 },
            { 0x00EB, MatchaOpcode.SystemLogMessage },
            { 0x03CB, MatchaOpcode.FishCaught },
            { 0x02CE, MatchaOpcode.StatusEffectList },
            { 0x8368, MatchaOpcode.ClientTrigger },
        };

        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0198, MatchaOpcode.ActorControl },
            { 0x01E6, MatchaOpcode.ActorControlSelf },
            { 0x020A, MatchaOpcode.CEDirector },
            { 0x0178, MatchaOpcode.CompanyAirshipStatus },
            { 0x039C, MatchaOpcode.CompanySubmersibleStatus },
            { 0x028A, MatchaOpcode.ContentFinderNotifyPop },
            { 0x01FE, MatchaOpcode.ResumeEventScene32 },
            { 0x0256, MatchaOpcode.EventPlay },
            { 0x0286, MatchaOpcode.EventStart },
            { 0x019C, MatchaOpcode.Examine },
            { 0x0259, MatchaOpcode.FateInfo },
            { 0x02CC, MatchaOpcode.InitZone },
            { 0x032D, MatchaOpcode.InventoryTransaction },
            { 0x00D1, MatchaOpcode.ItemInfo },
            { 0x0234, MatchaOpcode.MarketBoardItemListing },
            { 0x010D, MatchaOpcode.MarketBoardItemListingCount },
            { 0x011E, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8248, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0114, MatchaOpcode.NpcSpawn },
            { 0x0302, MatchaOpcode.PlayerSetup },
            { 0x0265, MatchaOpcode.PlayerSpawn },
            { 0x0367, MatchaOpcode.SubmarineStatusList },
            { 0x007C, MatchaOpcode.WorldVisitQueue },
            { 0x0324, MatchaOpcode.EventPlay4 },
            { 0x00EB, MatchaOpcode.SystemLogMessage },
            { 0x03CB, MatchaOpcode.FishCaught },
            { 0x02CE, MatchaOpcode.StatusEffectList },
            { 0x8368, MatchaOpcode.ClientTrigger },
        };
    }
}
