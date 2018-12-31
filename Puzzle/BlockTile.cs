using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KLD.Core.Puzzle
{
    public class BlockTile : Tile
    {
        public override bool SetContent(TileContent content)
        {
            return false;
        }
    }
}
