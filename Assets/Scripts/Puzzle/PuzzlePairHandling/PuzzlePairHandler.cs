using Assets.Scripts.ScriptableObjects;
using System.Collections.Generic;
using Ubongo.Puzzle.PuzzleBases;
using Ubongo.Puzzle.PuzzlePieces;
using UnityEngine;

namespace Assets.Scripts.Puzzle.PuzzlePairHandling
{
    public class PuzzlePairHandler : MonoBehaviour
    {
        [SerializeField] private PuzzlePairsListSO m_puzzlePairsSO;
        [HideInInspector] public PuzzlePairsListSO PuzzlePairsSO;

        public int IndexPuzzlePiece = -1;
        public int IndexPuzzleBase = 0;

        private bool m_IsPuzzleMatch;

        private void Awake()
        {
            try
            {
                PuzzlePairsSO = m_puzzlePairsSO;
            }
            catch (System.Exception e)
            {
                throw new System.ArgumentException($"Error: {e}");
            }
        }


        public int GetPuzzleIndex<T>(T item, List<T> list)
        {
            var index = list.IndexOf(item);

            return index;
        }

        public bool IsPuzzleMatch(PuzzlePiece puzzlePiece, PuzzleBase puzzleBase)
        {
            var puzzlePieceIndex = GetPuzzleIndex<PuzzlePiece>(puzzlePiece, m_puzzlePairsSO.PuzzlePieces);
            var puzzleBaseIndex = GetPuzzleIndex<PuzzleBase>(puzzleBase, m_puzzlePairsSO.PuzzleBases);

            bool isPuzzleMatch = puzzlePieceIndex == puzzleBaseIndex;
            return isPuzzleMatch;
        }

    }
}
