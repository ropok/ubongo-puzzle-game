using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Puzzle
{
    public class PuzzleDragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("Begin Drag");
        }

        public void OnDrag(PointerEventData eventData)
        {
            Debug.Log($"Dragging: {Input.mousePosition}");

            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("End Drag");
        }
    }
}
