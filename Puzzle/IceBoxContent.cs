using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KLD.Core.Puzzle
{
    public class IceBoxContent : TileContent
    {
        public override bool Move(NeighborDirection dire)
        {
            while (base.Move(dire)) { }
            return true;
        }
    }
}
