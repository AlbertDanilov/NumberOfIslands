using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static int numberOfIslands(int[][] grid) {
        if (grid == null || grid.Length == 0) { 
            return 0;
        }

        int numberOfIslands = 0;

        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) {
                    numberOfIslands++;
                    markIslands(grid, i, j);
                }
            }
        }

        return numberOfIslands;
    }

    private static void markIslands(int[][] grid, int i, int j) {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == 0) {
            return;
        }

        grid[i][j] = 0;

        markIslands(grid, i, j + 1);
        markIslands(grid, i + 1, j);
        markIslands(grid, i, j - 1);
        markIslands(grid, i - 1, j);
    }

    public static void Main()
    {
        int[][] grid = {
            new int[] { 1, 0, 0, 0 },
            new int[] { 0, 1, 0, 0 },
            new int[] { 0, 0, 0, 1 },
            new int[] { 0, 0, 0, 1 }
        };

        int count = numberOfIslands(grid);

        Console.WriteLine(count);
        Console.ReadLine();
    }
}

