﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.MessageBus
{
    public interface IMessageBus
    {
        Task PublichMessage(BaseMessage message,string topicName);
    }
}
