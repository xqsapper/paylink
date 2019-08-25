﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsWarehouseModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsWarehouseModifyModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息  ADMIN_PHONE:管理员电话  CITY_MANAGER_PHONE:城市经理电话  PURCHASE_MANAGER_PHONE:采购经理电话
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否开启安全库存开关 ON打开 OFF关闭
        /// </summary>
        [JsonProperty("safety_inventory_switch")]
        public string SafetyInventorySwitch { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
