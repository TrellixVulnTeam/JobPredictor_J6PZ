﻿using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelecomSTE.DE3.ResumeAnalyzer.Api.Configuration
{
    public class Settings
    {
        public string MongoConnectionString { get; set; }
        public string MongoDataBaseName { get; set; }
        public string BucketName { get; set; }
    }
}
