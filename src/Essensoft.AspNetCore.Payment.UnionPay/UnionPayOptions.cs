﻿using Essensoft.AspNetCore.Payment.UnionPay.Utility;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public class UnionPayOptions
    {
        private string encryptCert;

        /// <summary>
        /// 加密证书 
        /// </summary>
        internal UnionPayCertificate EncryptCertificate;

        private string middleCert;

        /// <summary>
        /// 验签中级证书
        /// </summary>
        internal UnionPayCertificate MiddleCertificate;

        private string rootCert;

        /// <summary>
        /// 验签根证书 
        /// </summary>
        internal UnionPayCertificate RootCertificate;

        /// <summary>
        /// 商户代码
        /// </summary>
        public string MerId { get; set; }

        /// <summary>
        /// 接入类型
        /// 0：普通商户直连接入
        /// 2：平台类商户接入
        /// </summary>
        public string AccessType { get; set; } = "0";

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; } = "5.1.0";

        /// <summary>
        /// 编码方式
        /// </summary>
        public string Encoding { get; } = "UTF-8";

        /// <summary>
        /// 签名方法
        /// 01（表示采用RSA签名）
        /// HASH表示散列算法
        /// 11：支持散列方式验证SHA-256
        /// 12：支持散列方式验证SM3
        /// </summary>
        public string SignMethod { get; set; } = "01";

        /// <summary>
        /// 签名证书 
        /// </summary>
        public string SignCert { get; set; }

        /// <summary>
        /// 签名证书密码
        /// </summary>
        public string SignCertPassword { get; set; }

        internal UnionPayCertificate SignCertificate => UnionPaySignature.GetSignCertificate(SignCert, SignCertPassword);

        public string EncryptCert
        {
            get => encryptCert;
            set
            {
                encryptCert = value;
                if (!string.IsNullOrEmpty(encryptCert))
                {
                    EncryptCertificate = UnionPaySignature.GetCertificate(encryptCert);
                }
            }
        }

        public string MiddleCert
        {
            get => middleCert;
            set
            {
                middleCert = value;
                if (!string.IsNullOrEmpty(middleCert))
                {
                    MiddleCertificate = UnionPaySignature.GetCertificate(middleCert);
                }
            }
        }

        public string RootCert
        {
            get => rootCert;
            set
            {
                rootCert = value;
                if (!string.IsNullOrEmpty(rootCert))
                {
                    RootCertificate = UnionPaySignature.GetCertificate(rootCert);
                }
            }
        }

        /// <summary>
        /// 散列方式签名密钥
        /// </summary>
        public string SecureKey { get; set; }

        /// <summary>
        /// 测试模式
        /// </summary>
        public bool TestMode { get; set; }
    }
}
