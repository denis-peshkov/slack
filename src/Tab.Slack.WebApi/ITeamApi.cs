﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tab.Slack.Common.Model.Requests;
using Tab.Slack.Common.Model.Responses;

namespace Tab.Slack.WebApi
{
    public interface ITeamApi
    {
        TeamAccessLogs AccessLogs(int? messageCount = null, int? pageNumber = null);
        TeamResponse Info();
    }
}