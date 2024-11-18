using Assets.Scripts.Puzzle;
using UnityEngine;

public class ClickManager : MonoBehaviour
{

    private GameObject _selectedPuzzle;

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (!hit) return;

            // add click interaction
            IClickable clickable = hit.collider.GetComponent<IClickable>();
            if (clickable == null) return;
            clickable?.Click();

            // set the previous selected clear
            if (_selectedPuzzle != null)
            {
                var clickablePuzzle = _selectedPuzzle.GetComponent<IClickable>();
                clickablePuzzle?.Click();
            }

            // store the selected puzzle
            _selectedPuzzle = hit.collider.gameObject;


        }
    }
}
