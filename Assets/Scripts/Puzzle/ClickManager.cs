using Assets.Scripts.ScriptableObjects;
using Ubongo.Puzzle.Interfaces;
using Ubongo.Puzzle.PuzzlePieces;
using UnityEngine;

namespace Ubongo.Puzzle
{
    public class ClickManager : MonoBehaviour
    {
        [SerializeField] private PuzzlePairSO PuzzlePairSO;

        private GameObject _selectedPuzzle;
        private GameObject _previousPuzzle;

        private void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector2 mousePosition = Input.mousePosition;
                RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

                if (!hit) return;

                if (_selectedPuzzle != null)
                    _previousPuzzle = _selectedPuzzle;

                ClearPreviousPuzzle(_previousPuzzle);

                _selectedPuzzle = GetSelectedPuzzle(hit);


                if (_selectedPuzzle == _previousPuzzle)
                {
                    ClearPreviousPuzzle(_selectedPuzzle);
                    ClearPreviousPuzzle(_previousPuzzle);
                    _selectedPuzzle = null;
                    _previousPuzzle = null;
                }

            }
        }

        private GameObject GetSelectedPuzzle(RaycastHit2D hit)
        {
            // add click interaction
            IHighlightable highlightable = hit.collider.GetComponent<IHighlightable>();
            PuzzlePiece puzzlePiece = hit.collider.GetComponent<PuzzlePiece>();

            if (highlightable == null) return null;
            highlightable?.Highlight();

            UpdateSelectedPuzzlePiece(puzzlePiece, PuzzlePairSO);

            return hit.transform.gameObject;
        }

        private void ClearPreviousPuzzle(GameObject selectedPuzzle)
        {
            if (selectedPuzzle == null) return;

            // set the previous selected clear
            var highlightable = _selectedPuzzle?.GetComponent<IHighlightable>();
            highlightable?.Dehighlight();

            selectedPuzzle = null;

        }

        private void UpdateSelectedPuzzlePiece(PuzzlePiece puzzlePiece, PuzzlePairSO puzzlePairSO)
        {
            puzzlePairSO.PuzzlePiece = puzzlePiece;
        }
    }
}

