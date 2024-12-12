using Ubongo.Puzzle.PuzzleBases;
using Ubongo.Puzzle.PuzzlePieces;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PuzzlePair")]
    public class PuzzlePairSO : ScriptableObject
    {
        public PuzzlePiece PuzzlePiece;
        public PuzzleBase PuzzleBase;
    }
}
