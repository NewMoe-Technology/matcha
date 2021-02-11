﻿// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Models
{
    using Newtonsoft.Json;

    public class InstanceData
    {
        [JsonProperty("name")]
        public ItemName Name;

        [JsonProperty("type")]
        public int Type;

        [JsonProperty("level")]
        public int Level;

        [JsonProperty("levelSync")]
        public int LevelSync;

        [JsonProperty("item")]
        public int ItemLevel;

        [JsonProperty("itemSync")]
        public int ItemLevelSync;

        [JsonProperty("memberType")]
        public int MemberType;
    }
}