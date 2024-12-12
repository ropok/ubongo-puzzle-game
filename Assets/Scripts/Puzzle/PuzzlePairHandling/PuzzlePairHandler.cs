using Assets.Scripts.ScriptableObjects;
using Ubongo.Puzzle.PuzzleBases;
using Ubongo.Puzzle.PuzzlePieces;
using UnityEngine;

namespace Assets.Scripts.Puzzle.PuzzlePairHandling
{
    public class PuzzlePairHandler : MonoBehaviour
    {
        [SerializeField] private PuzzlePairsListSO m_puzzlePairsSO;
        [HideInInspector] public PuzzlePairsListSO PuzzlePairsSO;

        public int IndexPuzzlePiece;
        public int IndexPuzzleBase;

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

        public int GetIndexPuzzlePiece(PuzzlePiece puzzlePiece)
        {
            var index = m_puzzlePairsSO.PuzzlePieces.IndexOf(puzzlePiece);
            IndexPuzzlePiece = index;

            return IndexPuzzlePiece;
        }

        public int GetIndexPuzzleBase(PuzzleBase puzzleBase)
        {
            var index = m_puzzlePairsSO.PuzzleBases.IndexOf(puzzleBase);
            IndexPuzzleBase = index;

            return IndexPuzzleBase;
        }
    }
}
