﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NextUrl Data Structure.
    /// </summary>
    [Serializable]
    public class NextUrl : AlipayObject
    {
        /// <summary>
        /// 小宝账户详情页跳转链接
        /// </summary>
        [JsonProperty("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 跳转链接的展示文案
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
