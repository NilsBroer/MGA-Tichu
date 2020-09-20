using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TE = Entities.CardEnums.Tichu;

namespace Entities
{
    public static class CardFeatures
    {
        public static readonly List<string> Names = Enum.GetNames(typeof(TE.Names)).ToList();
        public static readonly List<string> Suits = Enum.GetNames(typeof(TE.Suits)).ToList();
        public static readonly Dictionary<string, int> Values = EnumDictionary<TE.Values>();
        //public static readonly Dictionary<string, int> Points = EnumDictionary<TE.Points>();
        public static readonly Dictionary<string, int> Points = new Dictionary<string, int>()
        {
            {"Five",5},
            {"Ten",10},
            {"King",10},
            {"Phoenix",-25},
            {"Dragon",25}
        };

        private static Dictionary<string, int> EnumDictionary<T>()
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("Type must be an enum");
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .ToDictionary( t => t.ToString(),t => (int)(object)t);
        }
    }
}