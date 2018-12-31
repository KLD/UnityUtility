using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KLD.Core.Player
{
    public interface IStatusEffect
    {
        string Name { get; }

        void Init(Player p); 
        void Apply(Player p);
        void Revert(Player p);
    }
}
