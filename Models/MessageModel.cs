﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HP_Messaging.Models
{
    public class MessageModel
    {
        public int MessageId { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public int ActiveStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual UserModel User { get; set; }
        public virtual List<MessageReplyModel> MessageReplys { get; set; }
    }
}
