using Ubongo.Puzzle.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Ubongo.Puzzle.PuzzlePiece
{
    public class PuzzleDropCheck : MonoBehaviour, IEndDragHandler, IDroppable
    {

        [SerializeField] private PuzzlePiece m_puzzlePieces;
        private IHighlightable _highlightable;

        private bool _isValidDrop;
        public bool IsValidDrop => _isValidDrop;

        private int _hoveredPuzzle;
        public int HoveredPuzzle
        {
            get => _hoveredPuzzle;
            set => _hoveredPuzzle = value;
        }

        private Vector2 _destinationPosition;
        public Vector2 DestinationPosition
        {
            get => _destinationPosition;
            set => _destinationPosition = value;
        }

        private Vector2 _initialPosition;

        private void Awake()
        {
            _initialPosition = transform.localPosition;
            _highlightable = m_puzzlePieces.GetComponent<IHighlightable>();

        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (!_isValidDrop || _hoveredPuzzle > 1)
            {
                transform.localPosition = _initialPosition;
                _hoveredPuzzle = 0;
                return;
            }

            // place the puzzle snap into base position
            if (_destinationPosition != Vector2.zero)
            {
                transform.position = _destinationPosition;
                _highlightable?.Dehighlight();
            }

            // reset status
            _isValidDrop = false;
        }

        public void DroppingPuzzle()
        {
            _isValidDrop = true;
        }

        public void HoveringPuzzle()
        {
            _hoveredPuzzle += 1;
        }


    }
}
