using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KLD.Core.Puzzle
{
    public class BlockContent : TileContent
    {
        public override bool Move(NeighborDirection dire)
        {
            return false;
        }
    }
}
