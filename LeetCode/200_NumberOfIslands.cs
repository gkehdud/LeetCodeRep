using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _200_NumberOfIslands
    {
        public void Start()
        {
            //char[][] grid = new char[4][]{
            //    new char[] {'0','1','1','1','1'},
            //    new char[] {'0','0','0','0','0'},
            //    new char[] {'1','1','1','1','0'},
            //    new char[] {'1','0','1','1','0'}
            //};

            char[] chars = "01".ToCharArray();
            Random rand = new Random();
            Random x = new Random();
            char[][] grid = new char[x.Next(4, 8)][];
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new char[] {
                chars[rand.Next(chars.Length)],
                chars[rand.Next(chars.Length)],
                chars[rand.Next(chars.Length)],
                chars[rand.Next(chars.Length)],
                chars[rand.Next(chars.Length)],
                chars[rand.Next(chars.Length)] };
            }
            NumIslands(grid);

        }
        public void NumIslands(char[][] grid)
        {
            int res = 0;
            int x = grid.Length;
            int y = grid[0].Length;


            Console.WriteLine("Q200.Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water).\nReturn the number of islands.\n");
            Console.WriteLine("MAP :");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(grid[i][j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if(grid[i][j] == '1')   res += DFS(grid,i,j);
                }
            }

            

            Console.WriteLine("Number of Islands : " +res);
        }
        public int DFS(char[][] grid, int m, int n) {
            
            if (m < 0 || n < 0 || m > grid.Length - 1 || n > grid[m].Length - 1) return 0;

            if (grid[m][n] == '0') return 0;

            grid[m][n] = '0';

            DFS(grid, m - 1, n);
            DFS(grid, m + 1, n);
            DFS(grid, m, n - 1);
            DFS(grid, m, n + 1);
            return 1;
            
        }
    }
}
