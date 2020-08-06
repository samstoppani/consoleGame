using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string keyPressed, out int x, out int y)
    {
      switch(keyPressed)
      {
        case "LeftArrow":
          x = -1;
          y = 0;
          break;
        case "RightArrow":
          x = 1;
          y = 0;
          break;
        case "UpArrow":
          x = 0;
          y = -1;
          break;
        case "DownArrow":
          x = 0;
          y = 1;
          break;
        default:
          x = 0;
          y = 0;
          break;
      }
    }
    public new static char UpdateCursor(string keyPressed)
    {
      switch(keyPressed)
      {
        case "LeftArrow":
          return '<';
          break;
        case "RightArrow":
          return '>';
          break;
        case "UpArrow":
          return '^';
          break;
        case "DownArrow":
          return 'v';
          break;
        default:
          return '<';
          break;
      }
    }

    public new static int KeepInBounds(int coord, int maxCoord)
    {
      if (coord > maxCoord)
      {
        return maxCoord;
      }
      else if (coord < 0)
      {
        return 0;
      }
      else 
      {
        return coord;
      }
    }

    public new static bool DidScore(int charX, int charY, int fruitX, int fruitY)
    {
      if (charX == fruitX && charY == fruitY)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}



