using Assets.Scripts.Puzzle.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Puzzle.PuzzleBase
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
                _isOccupied = false;
                _droppedPuzzle = null;
            }

        }
    }
}
