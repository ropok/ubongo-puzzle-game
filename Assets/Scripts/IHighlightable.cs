namespace Ubongo.PuzzlePieces
{
    public interface IHighlightable
    {
        public bool IsHighlighted { get; }
        public void Highlight();
    }
}
