using UnityEngine;
using UnityEngine.EventSystems;

namespace Ubongo.Puzzle.PuzzlePiece
{
    public class PuzzleDragDrop : MonoBehaviour, IDragHandler
    {

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

    }
}
