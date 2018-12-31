using UnityEngine;

namespace KLD.Core.Puzzle
{
    public class Tile : MonoBehaviour, NeighbotGrid<Tile>.INeighbor<Tile>
    {
        public TileContent Content
        {
            get
            {
                //if (transform.GetChild(0) != null)
                return transform.GetComponentInChildren<TileContent>();
            }
        }
        [SerializeField]
        public Tile[] neighbor;
        public Tile[] Neighbor
        {
            set
            {
                neighbor = value;
            }
            get
            {
                return neighbor;
            }
        }
        private void Awake()
        {
            if (Neighbor == null)
                Neighbor = new Tile[4];
        }

        public virtual bool IsEmpty()
        {
            return Content == null;
        }

        public virtual void OnContentReached()
        {
        }

        public virtual bool CanSetContent()
        {
            return IsEmpty();
        }

        public virtual bool SetContent(TileContent content)
        {
            if (!CanSetContent())
            {
                return false;
            }
            content.transform.SetParent(transform);
            return true;
        }
        public bool HasContent()
        {
            return Content != null;
        }

        public bool HasNeighbor(NeighborDirection direction)
        {
            return neighbor[(int)direction] != null;
        }

        public Tile GetNeighbor(NeighborDirection direction)
        {
            return neighbor[(int)direction];
        }
    }

}