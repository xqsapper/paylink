﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanCreditQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanCreditQueryModel : AlipayObject
    {
        /// <summary>
        /// 同提交授信接口请求参数中的out_biz_no
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
