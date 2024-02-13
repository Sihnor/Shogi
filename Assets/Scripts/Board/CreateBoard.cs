using System;
using System.Collections.Generic;
using GameFigures;
using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    [SerializeField] private GameObject TilePrefab;
    private List<List<GameObject>> BoardTiles;

    [SerializeField] private List<GameObject> Pieces;
    private List<GameObject> Temp = new List<GameObject>();




    // Start is called before the first frame update
    private void Start()
    {
        CreateBoardTiles();
    }

    private void CreateBoardTiles()
    {
        this.BoardTiles = new List<List<GameObject>>();

        for (int i = 0; i <= 8; i++)
        {
            List<GameObject> row = new List<GameObject>();

            for (int j = 0; j <= 8; j++)
            {
                GameObject tile = Instantiate(TilePrefab, new Vector3(i, 0, j), Quaternion.identity);
                tile.transform.parent = this.transform;
                tile.name = "Tile_" + i + "_" + j;
                tile.GetComponent<Tile>().InitVariables(i, j, (i + j) % 2 == 0 ? Color.black : Color.white);
                row.Add(tile);

                SpawnPieces(new Tuple<int, int>(i, j));
            }

            this.BoardTiles.Add(row);
        }
    }

    private void SpawnPieces(Tuple<int, int> position)
    {
        #region Spielerfiguren Platzierung

        Tuple<int, int> kingWhitePosition = new Tuple<int, int>(0, 4);
        Tuple<int, int> goldOneWhitePosition = new Tuple<int, int>(0, 3);
        Tuple<int, int> goldTwoWhitePosition = new Tuple<int, int>(0, 5);
        Tuple<int, int> silverOneWhitePosition = new Tuple<int, int>(0, 2);
        Tuple<int, int> silverTwoWhitePosition = new Tuple<int, int>(0, 6);
        Tuple<int, int> knightOneWhitePosition = new Tuple<int, int>(0, 1);
        Tuple<int, int> knightTwoWhitePosition = new Tuple<int, int>(0, 7);
        Tuple<int, int> lanceOneWhitePosition = new Tuple<int, int>(0, 0);
        Tuple<int, int> lanceTwoWhitePosition = new Tuple<int, int>(0, 8);
        Tuple<int, int> bishopWhitePosition = new Tuple<int, int>(1, 1);
        Tuple<int, int> rookWhitePosition = new Tuple<int, int>(1, 7);
        Tuple<int, int> pawnOneWhitePosition = new Tuple<int, int>(2, 0);
        Tuple<int, int> pawnTwoWhitePosition = new Tuple<int, int>(2, 1);
        Tuple<int, int> pawnThreeWhitePosition = new Tuple<int, int>(2, 2);
        Tuple<int, int> pawnFourWhitePosition = new Tuple<int, int>(2, 3);
        Tuple<int, int> pawnFiveWhitePosition = new Tuple<int, int>(2, 4);
        Tuple<int, int> pawnSixWhitePosition = new Tuple<int, int>(2, 5);
        Tuple<int, int> pawnSevenWhitePosition = new Tuple<int, int>(2, 6);
        Tuple<int, int> pawnEightWhitePosition = new Tuple<int, int>(2, 7);
        Tuple<int, int> pawnNineWhitePosition = new Tuple<int, int>(2, 8);

        Tuple<int, int> kingBlackPosition = new Tuple<int, int>(8, 4);
        Tuple<int, int> goldOneBlackPosition = new Tuple<int, int>(8, 3);
        Tuple<int, int> goldTwoBlackPosition = new Tuple<int, int>(8, 5);
        Tuple<int, int> silverOneBlackPosition = new Tuple<int, int>(8, 2);
        Tuple<int, int> silverTwoBlackPosition = new Tuple<int, int>(8, 6);
        Tuple<int, int> knightOneBlackPosition = new Tuple<int, int>(8, 1);
        Tuple<int, int> knightTwoBlackPosition = new Tuple<int, int>(8, 7);
        Tuple<int, int> lanceOneBlackPosition = new Tuple<int, int>(8, 0);
        Tuple<int, int> lanceTwoBlackPosition = new Tuple<int, int>(8, 8);
        Tuple<int, int> bishopBlackPosition = new Tuple<int, int>(7, 7);
        Tuple<int, int> rookBlackPosition = new Tuple<int, int>(7, 1);
        Tuple<int, int> pawnOneBlackPosition = new Tuple<int, int>(6, 0);
        Tuple<int, int> pawnTwoBlackPosition = new Tuple<int, int>(6, 1);
        Tuple<int, int> pawnThreeBlackPosition = new Tuple<int, int>(6, 2);
        Tuple<int, int> pawnFourBlackPosition = new Tuple<int, int>(6, 3);
        Tuple<int, int> pawnFiveBlackPosition = new Tuple<int, int>(6, 4);
        Tuple<int, int> pawnSixBlackPosition = new Tuple<int, int>(6, 5);
        Tuple<int, int> pawnSevenBlackPosition = new Tuple<int, int>(6, 6);
        Tuple<int, int> pawnEightBlackPosition = new Tuple<int, int>(6, 7);
        Tuple<int, int> pawnNineBlackPosition = new Tuple<int, int>(6, 8);

        #endregion

        Quaternion rotation;
        GameObject piece = null;
        if (Equals(position, kingWhitePosition)) piece = this.Pieces.Find(p => p.name == "King");
        if (Equals(position, goldOneWhitePosition)) piece = this.Pieces.Find(p => p.name == "Gold");
        if (Equals(position, goldTwoWhitePosition)) piece = this.Pieces.Find(p => p.name == "Gold");
        if (Equals(position, silverOneWhitePosition)) piece = this.Pieces.Find(p => p.name == "Silver");
        if (Equals(position, silverTwoWhitePosition)) piece = this.Pieces.Find(p => p.name == "Silver");
        if (Equals(position, knightOneWhitePosition)) piece = this.Pieces.Find(p => p.name == "Knight");
        if (Equals(position, knightTwoWhitePosition)) piece = this.Pieces.Find(p => p.name == "Knight");
        if (Equals(position, lanceOneWhitePosition)) piece = this.Pieces.Find(p => p.name == "Lance");
        if (Equals(position, lanceTwoWhitePosition)) piece = this.Pieces.Find(p => p.name == "Lance");
        if (Equals(position, bishopWhitePosition)) piece = this.Pieces.Find(p => p.name == "Bishop");
        if (Equals(position, rookWhitePosition)) piece = this.Pieces.Find(p => p.name == "Rook");
        if (Equals(position, pawnOneWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnTwoWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnThreeWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnFourWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnFiveWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnSixWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnSevenWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnEightWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnNineWhitePosition)) piece = this.Pieces.Find(p => p.name == "Pawn");

        rotation = piece != null ? Quaternion.Euler(0, -90, 0) : Quaternion.Euler(0, 90, 0);

        if (Equals(position, kingBlackPosition)) piece = this.Pieces.Find(p => p.name == "King");
        if (Equals(position, goldOneBlackPosition)) piece = this.Pieces.Find(p => p.name == "Gold");
        if (Equals(position, goldTwoBlackPosition)) piece = this.Pieces.Find(p => p.name == "Gold");
        if (Equals(position, silverOneBlackPosition)) piece = this.Pieces.Find(p => p.name == "Silver");
        if (Equals(position, silverTwoBlackPosition)) piece = this.Pieces.Find(p => p.name == "Silver");
        if (Equals(position, knightOneBlackPosition)) piece = this.Pieces.Find(p => p.name == "Knight");
        if (Equals(position, knightTwoBlackPosition)) piece = this.Pieces.Find(p => p.name == "Knight");
        if (Equals(position, lanceOneBlackPosition)) piece = this.Pieces.Find(p => p.name == "Lance");
        if (Equals(position, lanceTwoBlackPosition)) piece = this.Pieces.Find(p => p.name == "Lance");
        if (Equals(position, bishopBlackPosition)) piece = this.Pieces.Find(p => p.name == "Bishop");
        if (Equals(position, rookBlackPosition)) piece = this.Pieces.Find(p => p.name == "Rook");
        if (Equals(position, pawnOneBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnTwoBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnThreeBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnFourBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnFiveBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnSixBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnSevenBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnEightBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");
        if (Equals(position, pawnNineBlackPosition)) piece = this.Pieces.Find(p => p.name == "Pawn");

        if (piece != null)
        {
            GameObject pieceInstance = Instantiate(piece, new Vector3(position.Item1, 0.1f, position.Item2), rotation);
            pieceInstance.transform.parent = this.transform;
            pieceInstance.name = piece.name + "_" + position.Item1 + "_" + position.Item2;

            this.Temp.Add(pieceInstance);
            //Debug.Log("Piece: " + piece.name + " Position: " + position.Item1 + " " + position.Item2);
        }
    }
}