﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventTable.Models
{
    /// <summary>
    /// Класс, содержащий конфигурации бота
    /// </summary>
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://localhost:44373/{0}";

        public static string Name { get; set; } = "EventTablebot";

        public static string Key { get; set; } = "1054347333:AAHsNZrggwnqFPV3vmgi1exYxMd5hMsuEH4";

    }
}