using UnityEngine;

namespace KLD.Core.Puzzle
{
    public class NeighborGridBuilder : MonoBehaviour
    {
        public int Width;
        public int Height;

        public float TileWidth = 1;
        public float TileHeight = 1;

        public Transform TilesParent;

        public GameObject TilePrefab;

        // Start is called before the first frame update
        void Start()
        {
            NeighbotGrid<Tile> gridBuilder = new NeighbotGrid<Tile>(Width, Height, (x, y) =>
            {
                var tile = Instantiate(TilePrefab, TilesParent?? transform).AddComponent<Tile>();

                tile.name = $"{x} - {y}";

                tile.transform.localPosition = new Vector3((x - ((float)Width / 2) + TileWidth), (y - ((float)Height / 2) + TileHeight), 0);

                return tile;
            });
        }
    }

}