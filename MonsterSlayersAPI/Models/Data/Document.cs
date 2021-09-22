using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.Models.Data
{
    public abstract class Document : IDocument
    {
        public string UserId { get; set; }
    }
}
