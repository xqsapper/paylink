﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdCreativeBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 创意分组标识，多个创意可按业务逻辑标识为一个分组
        /// </summary>
        [JsonProperty("batch_tag")]
        public string BatchTag { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonProperty("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 分页查询当前页(从第1页开始)，默认值为1
        /// </summary>
        [JsonProperty("current")]
        public long Current { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放单元对应的外部资源ID
        /// </summary>
        [JsonProperty("group_outer_id")]
        public string GroupOuterId { get; set; }

        /// <summary>
        /// 分页查询单页记录数，默认值为20，单页不能超过1w
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放计划对应的外部资源ID
        /// </summary>
        [JsonProperty("plan_outer_id")]
        public string PlanOuterId { get; set; }

        /// <summary>
        /// 创意状态，ENABLE-生效；PAUSE-暂停；DELETE-删除；AUDIT-审核中；REFUSED-审核拒绝
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
