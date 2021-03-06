﻿using MpzMail.Api.Model.Base;
using System.Xml.Serialization;

namespace MpzMail.Api.Model
{
    [XmlRoot("xml")]
    public class GroupAddResult : BaseResult
    {
        [XmlElement("groupID")]
        public string GroupId { get; set; }
    }
}
