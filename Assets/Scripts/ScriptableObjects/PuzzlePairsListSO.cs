using System.Collections.Generic;
using Ubongo.Puzzle.PuzzleBases;
using Ubongo.Puzzle.PuzzlePieces;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PuzzlePair")]
    public class PuzzlePairsListSO : ScriptableObject
    {
        public List<PuzzlePiece> PuzzlePieces;
        public List<PuzzleBase> PuzzleBases;
    }
}
