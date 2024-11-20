using Ubongo.Puzzle.Interfaces;
using UnityEngine;

namespace Ubongo.Puzzle.PuzzleBase
{
    public class PuzzleBase : MonoBehaviour
    {
        private bool _isOccupied;
        private GameObject _droppedPuzzle;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (_isOccupied) return;

            Debug.Log($"TriggerEnter: {collision.gameObject.name}");
            IDroppable droppable = collision.GetComponent<IDroppable>();
            droppable.DroppingPuzzle();
            droppable.HoveredPuzzle += 1;

            droppable.DestinationPosition = transform.position;

            _isOccupied = true;

            _droppedPuzzle = collision.gameObject;

        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            // if it's not occupied yet, no need to do exit detection
            if (!_isOccupied) return;


            IDroppable droppable = collision.GetComponent<IDroppable>();
            bool isSamePuzzle = _droppedPuzzle == collision.gameObject;
            if (droppable != null && isSamePuzzle)
            {
                droppable.HoveredPuzzle -= 1;
                _isOccupied = false;
                _droppedPuzzle = null;
            }

            if (droppable.HoveredPuzzle < 0)
            {
                droppable.HoveredPuzzle = 0;
            }
        }
    }
}
