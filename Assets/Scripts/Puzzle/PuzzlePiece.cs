using Assets.Scripts.Puzzle;
using UnityEngine;

namespace Ubongo.PuzzlePieces
{
    public class PuzzlePiece : MonoBehaviour, IHighlightable, ISelectable
    {

        [SerializeField] private GameObject m_puzzleHighlight;

        public bool IsHighlighted => m_IsHighlighted;
        private bool m_IsHighlighted;

        public void Highlight()
        {
            m_IsHighlighted = !m_IsHighlighted;

            if (m_IsHighlighted)
            {
                Debug.Log("item highlighted: " + gameObject.name);
                m_puzzleHighlight.SetActive(true);
            }
            else if (!m_IsHighlighted)
            {
                Debug.Log("item not highlighted anymore: " + gameObject.name);
                m_puzzleHighlight.SetActive(false);
            }
        }

        public void Select()
        {
            Debug.Log("item clicked: " + gameObject.name);
            Highlight();
        }

        public void Deselect()
        {
            m_IsHighlighted = false;
            m_puzzleHighlight.SetActive(false);
        }
    }
}
