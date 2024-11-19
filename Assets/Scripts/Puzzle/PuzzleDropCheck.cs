using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Puzzle
{
    public class PuzzleDropCheck : MonoBehaviour, IEndDragHandler
    {
        private Vector2 _initialPosition;
        public bool _IsValidDrop { get; set; }
        private bool _isValidDrop => _IsValidDrop;

        private void Awake()
        {
            _initialPosition = transform.localPosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (!_isValidDrop)
            {
                transform.localPosition = _initialPosition;
            }
        }

    }
}
