namespace Assets.Scripts.Puzzle.Interfaces
{
    public interface IDroppable
    {
        public bool IsValidDrop { get; }
        public void DroppingPuzzle();
    }
}
