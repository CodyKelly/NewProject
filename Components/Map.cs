using Nez;
using Microsoft.Xna.Framework;

namespace NewProject
{
  class Map
  {
    public int Width { get; set; } = 100;
    public int Height { get; set; } = 100;

    public int TileSize { get; } = 32;

    public int[,] Tiles { get; set; }

    public void Generate()
    {
      Tiles = new int[Width, Height];
      for (int y = 0; y < Height; y++)
      {
        for (int x = 0; x < Width; x++)
        {
          int tileValue = 0;
          float randValue = Random.NextFloat();
          if (randValue > 0.95f)
          {
            tileValue = Random.Range(1, 7);
          }
          Tiles[x, y] = tileValue;
        }
      }
    }

    public int WorldToTilePositionX(float x) => (int)(x / TileSize);
    public int WorldToTilePositionY(float y) => (int)(y / TileSize);
  }
}