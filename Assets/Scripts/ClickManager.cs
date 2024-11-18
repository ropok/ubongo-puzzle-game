using Assets.Scripts.Puzzle;
using UnityEngine;

public class ClickManager : MonoBehaviour
{

    private GameObject _selectedPuzzle;
    private GameObject _previousPuzzle;

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
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
        ISelectable selectable = hit.collider.GetComponent<ISelectable>();

        if (selectable == null) return null;
        selectable?.Select();

        return hit.transform.gameObject;
    }

    private void ClearPreviousPuzzle(GameObject selectedPuzzle)
    {
        if (selectedPuzzle == null) return;

        // set the previous selected clear
        var selectablePuzzle = _selectedPuzzle.GetComponent<ISelectable>();
        selectablePuzzle?.Deselect();
        Debug.Log("Deselected");

        selectedPuzzle = null;

    }
}
