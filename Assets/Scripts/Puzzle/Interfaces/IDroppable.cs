namespace Assets.Scripts.Puzzle.Interfaces
{
    public interface IDroppable
    {
        public bool IsValidDrop { get; }
        public int HoveredPuzzle { get; set; }
        public void DroppingPuzzle();
        public void HoveringPuzzle();
    }
}
