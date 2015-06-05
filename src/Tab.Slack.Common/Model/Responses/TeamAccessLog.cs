﻿namespace Tab.Slack.Common.Model.Responses
{
    public class TeamAccessLog : FlexibleJsonModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public int DateFirst { get; set; }
        public int DateLast { get; set; }
        public int Count { get; set; }
        public string Ip { get; set; }
        public string UserAgent { get; set; }
        public string Isp { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
    }
}