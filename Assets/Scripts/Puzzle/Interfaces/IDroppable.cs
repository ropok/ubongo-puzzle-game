
using UnityEngine;

namespace Assets.Scripts.Puzzle.Interfaces
{
    public interface IDroppable
    {
        public bool IsValidDrop { get; }
        public int HoveredPuzzle { get; set; }
        public void DroppingPuzzle();
        public void HoveringPuzzle();
        public Vector2 DestinationPosition { get; set; }
    }
}
