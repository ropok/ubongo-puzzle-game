using UnityEngine;
using UnityEngine.EventSystems;

namespace Ubongo.PuzzlePieces
{
    public class PuzzlePiece : MonoBehaviour, IHighlightable, IPointerClickHandler
    {

        private bool m_IsHighlighted;

        public bool IsHighlighted => m_IsHighlighted;

        public void Highlight()
        {
            m_IsHighlighted = !m_IsHighlighted;

            if (m_IsHighlighted)
            {
                Debug.Log("item highlighted");
            }
            else if (!m_IsHighlighted)
            {
                Debug.Log("item not highlighted");
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Highlight();

        }
    }
}
