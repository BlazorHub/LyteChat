﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyteChat.Shared.DataTransferObject;

namespace LyteChat.Shared.Communication
{
    public class ChatMessageResponse
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public ChatMessageDTO ChatMessageDTO { get; set; }
    }
}
