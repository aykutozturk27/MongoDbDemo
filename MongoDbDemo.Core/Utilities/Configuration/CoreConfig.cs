﻿using Microsoft.Extensions.Configuration;

namespace MongoDbDemo.Core.Utilities.Configuration
{
    public static class CoreConfig
    {
        public static IConfigurationBuilder? _configurationBuilder;
        public static IConfiguration? _configuration;

        public static IConfiguration GetConfiguration()
        {
            _configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json");
            _configuration = _configurationBuilder.Build();
            return _configuration;
        }

        public static string GetValue(string key)
        {
            return GetConfiguration().GetValue<string>(key);
        }

        public static string GetConnectionString(string connection)
        {
            return GetConfiguration().GetConnectionString(connection);
        }

    }
}
