using KLD.Core.Configuration;
using KLD.Core.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KLD.Core.Configuration
{
    public class PlayerEnjectorConfig : ConfigMapper<Enjection>
    {
        public Player.Player Player;

        public override void Configure(Enjection obj)
        {
            obj.Enject(Player);
        }
    } 
}
