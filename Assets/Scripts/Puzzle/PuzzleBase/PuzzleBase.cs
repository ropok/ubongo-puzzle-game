using Assets.Scripts.Puzzle.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Puzzle.PuzzleBase
{
    public class PuzzleBase : MonoBehaviour
    {
        private bool _isOccupied;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (_isOccupied) return;

            Debug.Log($"TriggerEnter: {collider.gameObject.name}");
            IDroppable droppable = collider.GetComponent<IDroppable>();
            droppable.DroppingPuzzle();

        }
    }
}
