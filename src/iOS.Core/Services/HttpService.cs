﻿using System;
using Bit.App;
using Bit.App.Abstractions;

namespace Bit.iOS.Core.Services
{
    public class HttpService : IHttpService
    {
        public ApiHttpClient Client => new ApiHttpClient();
    }
}
