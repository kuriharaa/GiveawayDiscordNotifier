﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiveawayFreeSteamBot.GiveawayDiscordNotifier.src.Models
{
    public class Giveaway
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string ExternalId { get; set; }
        public string Url { get; set; }
        public bool Sent { get; set; }
        public string Title { get; set; }
        public string Store { get; set; }
        public string DirectUrl { get; set; }
        public string PhotoUrl { get; set; }
    }
}
