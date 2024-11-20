﻿using Assets.Scripts.Puzzle.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Puzzle
{
    public class PuzzleDropCheck : MonoBehaviour, IEndDragHandler, IDroppable
    {

        private bool _isValidDrop;
        public bool IsValidDrop => _isValidDrop;

        private int _hoveredPuzzle;
        public int HoveredPuzzle
        {
            get => _hoveredPuzzle;
            set => _hoveredPuzzle = value;
        }

        private Vector2 _initialPosition;

        private void Awake()
        {
            _initialPosition = transform.localPosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (!_isValidDrop || _hoveredPuzzle > 1)
            {
                transform.localPosition = _initialPosition;
                _hoveredPuzzle = 0;
                return;
            }

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
