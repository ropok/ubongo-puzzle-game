using Assets.Scripts.Puzzle.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Puzzle
{
    public class PuzzleDropCheck : MonoBehaviour, IEndDragHandler, IDroppable
    {

        private bool _isValidDrop;
        public bool IsValidDrop => _isValidDrop;

        private Vector2 _initialPosition;

        private void Awake()
        {
            _initialPosition = transform.localPosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (!_isValidDrop)
            {
                transform.localPosition = _initialPosition;
                return;
            }

            _isValidDrop = false;
        }

        public void DroppingPuzzle()
        {
            _isValidDrop = true;
        }


    }
}
