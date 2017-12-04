﻿using System;
using System.Collections.Generic;

namespace Dwolla.Client.Models.Responses
{
    public class DocumentResponse : BaseResponse
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
    }
}