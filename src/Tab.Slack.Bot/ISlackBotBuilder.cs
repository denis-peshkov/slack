﻿using System.Reflection;

namespace Tab.Slack.Bot
{
    public interface ISlackBotBuilder
    {
        ISlackBot Instantiate();
        ISlackBotBuilder WithoutCoreHandlers();
        ISlackBotBuilder WithPlugin<T>();
        ISlackBotBuilder WithPluginAssembly(Assembly pluginAssembly);
        ISlackBotBuilder WithPluginPath(string pluginPath);
    }
}