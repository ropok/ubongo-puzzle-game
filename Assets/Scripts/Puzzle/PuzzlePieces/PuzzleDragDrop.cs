using UnityEngine;
using UnityEngine.EventSystems;

namespace Ubongo.Puzzle.PuzzlePieces
{
    public class PuzzleDragDrop : MonoBehaviour, IDragHandler
    {

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

    }
}
