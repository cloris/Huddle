﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Huddle.BotWebApp.Models
{
    [Serializable]
    public class TeamMember
    {
        public string Id { get; set; }

        public string DisplayName { get; set; }
    }
}