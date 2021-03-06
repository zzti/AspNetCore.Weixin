﻿using System;
namespace AspNetCore.Weixin
{
    interface IJsapiTicketBagsRepository
    {
        string GetTicket(string accessToken);
        bool IsExpired(string accessToken);
        JsapiTicketBag Load(string accessToken);
        void SetExpired(string accessToken);
        void Store(string accessToken, JsapiTicketBag bag);
    }
}
