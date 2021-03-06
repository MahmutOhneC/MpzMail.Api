﻿using MpzMail.Api.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class AccountRequest : BaseRequest
    {
        [XmlElement("emailaddress")]
        public string EmailAddress { get; set; }
        [XmlElement("password")]
        public string Password { get; set; }
        [XmlElement("fullname")]
        public string Fullname { get; set; }
        [XmlElement("agencyAccount")]
        public AgencyAccount? AgencyAccount { get; set; }
        public bool ShouldSerializeAgencyAccount()
        {
            return AgencyAccount.HasValue;
        }
        [XmlElement("isFreeAccount")]
        public AccountType? Type { get; set; }
        public bool ShouldSerializeType()
        {
            return Type.HasValue;
        }

        [XmlElement("userLanguage")]
        public UserLanguage? InitialUserLanguage { get; set; }
        public bool ShouldSerializeInitialUserLanguage()
        {
            return InitialUserLanguage.HasValue;
        }
    }
}
