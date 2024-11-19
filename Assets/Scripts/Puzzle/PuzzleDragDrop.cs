using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Puzzle
{
    public class PuzzleDragDrop : MonoBehaviour, IDragHandler
    {

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

    }
}
