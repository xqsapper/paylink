﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionQueryModel : AlipayObject
    {
        /// <summary>
        /// 淘宝
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("first_sort_col")]
        public string FirstSortCol { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("first_sort_col_order")]
        public string FirstSortColOrder { get; set; }

        /// <summary>
        /// 组合状态
        /// </summary>
        [JsonProperty("group_status_list")]
        public List<string> GroupStatusList { get; set; }

        /// <summary>
        /// 租户类型
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 页数-从0开始
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，最大20
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 版本列表
        /// </summary>
        [JsonProperty("version_list")]
        public List<string> VersionList { get; set; }
    }
}
