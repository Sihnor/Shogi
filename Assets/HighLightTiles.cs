using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Enums;
using GameFigures;
using Structs;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HighLightTiles : MonoBehaviour
{
    private List<List<GameObject>> BoardTiles;

    // Start is called before the first frame update
    void Start()
    {
        EventManager.Instance.FOnPieceSelected += OnPieceSelected;
    }

    public void GetTileList(List<List<GameObject>> boardTiles)
    {
        this.BoardTiles = boardTiles;
    }

    private void OnPieceSelected(int x, int y, SFigureMovementSet movementSet, EFigureColor figureColor)
    {
        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();
        ResetHighLightBoardTile();

        if (figureColor == EFigureColor.White)
        {
            possibleMoves.AddRange(NwMove(x, y, movementSet.MovementTypeNw));
            possibleMoves.AddRange(NMove(x, y, movementSet.MovementTypeN));
            possibleMoves.AddRange(NeMove(x, y, movementSet.MovementTypeNe));
            possibleMoves.AddRange(WMove(x, y, movementSet.MovementTypeW));
            possibleMoves.AddRange(EMove(x, y, movementSet.MovementTypeE));
            possibleMoves.AddRange(SwMove(x, y, movementSet.MovementTypeSw));
            possibleMoves.AddRange(SMove(x, y, movementSet.MovementTypeS));
            possibleMoves.AddRange(SeMove(x, y, movementSet.MovementTypeSe));
        }
        else
        {
            possibleMoves.AddRange(NwMove(-x, -y, movementSet.MovementTypeNw));
            possibleMoves.AddRange(NMove(-x, -y, movementSet.MovementTypeN));
            possibleMoves.AddRange(NeMove(-x, -y, movementSet.MovementTypeNe));
            possibleMoves.AddRange(WMove(-x, -y, movementSet.MovementTypeW));
            possibleMoves.AddRange(EMove(-x, -y, movementSet.MovementTypeE));
            possibleMoves.AddRange(SwMove(-x, -y, movementSet.MovementTypeSw));
            possibleMoves.AddRange(SMove(-x, -y, movementSet.MovementTypeS));
            possibleMoves.AddRange(SeMove(-x, -y, movementSet.MovementTypeSe));
        }

        foreach (Tuple<int, int> move in possibleMoves)
        {
            if (move.Item1 > 0 && move.Item1 < 10 && move.Item2 > 0 && move.Item2 < 10)
            {
                HighLightBoardTile(move.Item1 - 1, move.Item2 - 1);
            }
        }
    }

    private List<Tuple<int, int>> NwMove(int x, int y, EMovementType figureType)
    {
        int step = x / Mathf.Abs(x);
        int xPos = Mathf.Abs(x);
        int yPos = Mathf.Abs(y);

        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:
                possibleMoves.Add(new Tuple<int, int>(xPos - step, yPos + step));
                break;
            case EMovementType.Unlimited:
                for (int i = 1; i < 9; i++)
                {
                    possibleMoves.Add(new Tuple<int, int>(xPos - i * step, yPos + i * step));
                }
                break;
            case EMovementType.Jump:
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;
    }

    private List<Tuple<int, int>> NMove(int x, int y, EMovementType figureType)
    {
        int step = x / Mathf.Abs(x);
        int xPos = Mathf.Abs(x);
        int yPos = Mathf.Abs(y);

        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:
                possibleMoves.Add(new Tuple<int, int>(xPos, yPos + step));
                break;
            case EMovementType.Unlimited:
                for (int i = 1; i < 9; i++)
                {
                    possibleMoves.Add(new Tuple<int, int>(xPos, yPos + i * step));
                }
                break;
            case EMovementType.Jump:
                possibleMoves.Add(new Tuple<int, int>(xPos - step, yPos + 2 * step));
                possibleMoves.Add(new Tuple<int, int>(xPos + step, yPos + 2 * step));
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;
    }

    private List<Tuple<int, int>> NeMove(int x, int y, EMovementType figureType)
    {
        int step = x / Mathf.Abs(x);
        int xPos = Mathf.Abs(x);
        int yPos = Mathf.Abs(y);

        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:
                possibleMoves.Add(new Tuple<int, int>(xPos + step, yPos + step));
                break;
            case EMovementType.Unlimited:
                for (int i = 1; i < 9; i++)
                {
                    possibleMoves.Add(new Tuple<int, int>(xPos + i * step, yPos + i * step));
                }
                break;
            case EMovementType.Jump:
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;

    }

    private List<Tuple<int, int>> WMove(int x, int y, EMovementType figureType)
    {
        int step = x / Mathf.Abs(x);
        int xPos = Mathf.Abs(x);
        int yPos = Mathf.Abs(y);

        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:
                possibleMoves.Add(new Tuple<int, int>(xPos - step, yPos));
                break;
            case EMovementType.Unlimited:
                for (int i = 1; i < 9; i++)
                {
                    possibleMoves.Add(new Tuple<int, int>(xPos - i * step, yPos));
                }
                break;
            case EMovementType.Jump:
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;
    }

    private List<Tuple<int, int>> EMove(int x, int y, EMovementType figureType)
    {
        int step = x / Mathf.Abs(x);
        int xPos = Mathf.Abs(x);
        int yPos = Mathf.Abs(y);

        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:
                possibleMoves.Add(new Tuple<int, int>(xPos + step, yPos));
                break;
            case EMovementType.Unlimited:
                for (int i = 1; i < 9; i++)
                {
                    possibleMoves.Add(new Tuple<int, int>(xPos + i * step, yPos));
                }
                break;
            case EMovementType.Jump:
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;
    }

    private List<Tuple<int, int>> SwMove(int x, int y, EMovementType figureType)
    {
        int step = x / Mathf.Abs(x);
        int xPos = Mathf.Abs(x);
        int yPos = Mathf.Abs(y);

        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:
                possibleMoves.Add(new Tuple<int, int>(xPos - step, yPos - step));
                break;
            case EMovementType.Unlimited:
                for (int i = 1; i < 9; i++)
                {
                    possibleMoves.Add(new Tuple<int, int>(xPos - i * step, yPos - i * step));
                }
                break;
            case EMovementType.Jump:
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;
    }

    private List<Tuple<int, int>> SMove(int x, int y, EMovementType figureType)
    {
        int step = x / Mathf.Abs(x);
        int xPos = Mathf.Abs(x);
        int yPos = Mathf.Abs(y);

        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:
                possibleMoves.Add(new Tuple<int, int>(xPos, yPos - step));
                break;
            case EMovementType.Unlimited:
                for (int i = 1; i < 9; i++)
                {
                    possibleMoves.Add(new Tuple<int, int>(xPos, yPos - i * step));
                }
                break;
            case EMovementType.Jump:
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;
    }

    private List<Tuple<int, int>> SeMove(int x, int y, EMovementType figureType)
    {
        int step = x / Mathf.Abs(x);
        int xPos = Mathf.Abs(x);
        int yPos = Mathf.Abs(y);

        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:
                possibleMoves.Add(new Tuple<int, int>(xPos + step, yPos - step));
                break;
            case EMovementType.Unlimited:
                for (int i = 1; i < 9; i++)
                {
                    possibleMoves.Add(new Tuple<int, int>(xPos + i * step, yPos - i * step));
                }
                break;
            case EMovementType.Jump:
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;
    }

    private List<Tuple<int, int>> IsMoveable(int x, int y, EMovementType figureType)
    {
        List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();

        switch (figureType)
        {
            case EMovementType.Step:

                break;
            case EMovementType.Unlimited:
                break;
            case EMovementType.Jump:
                break;
            case EMovementType.NoMove:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(figureType), figureType, null);
        }

        return possibleMoves;
    }

    private void HighLightBoardTile(int x, int y)
    {
        this.BoardTiles[x][y].GetComponent<Tile>().HighlightTile(new Color(0.523f, 0.796f, 0.445f, 1));
    }

    private void ResetHighLightBoardTile()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                this.BoardTiles[i][j].GetComponent<Tile>().ResetColor();
            }
        }
    }

}