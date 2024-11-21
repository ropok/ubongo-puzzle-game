using Ubongo.Puzzle.Interfaces;
using UnityEngine;

namespace Ubongo.Puzzle.PuzzlePiece
{
    public class PuzzleHighlight : MonoBehaviour, IHighlightable
    {
        [SerializeField] private GameObject m_puzzleHighlight;

        private bool m_IsHighlighted;
        public bool IsHighlighted => m_IsHighlighted;

        public void Highlight()
        {
            m_IsHighlighted = !m_IsHighlighted;
            m_puzzleHighlight?.SetActive(m_IsHighlighted);
        }

        public void Dehighlight()
        {
            m_IsHighlighted = false;
            m_puzzleHighlight?.SetActive(false);
        }
    }
}
