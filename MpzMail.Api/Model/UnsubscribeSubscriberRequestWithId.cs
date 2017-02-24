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
    public class UnsubscribeSubscriberRequestWithId : BaseRequest
    {
        [XmlElement("subscriberID")]
        public int SubscriberId { get; set; }
    }
}
