﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tab.Slack.Common.Model;
using Tab.Slack.Common.Model.Requests;
using Tab.Slack.Common.Model.Responses;

namespace Tab.Slack.WebApi
{
    public interface IOauthApi
    {
        OauthAccessResponse Access(string clientId, string clientSecret, string callbackCode, string redirectUri = null);
    }
}
