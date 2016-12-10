using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DesignPattern.CreationalPatterns.MapSites;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.Builder
{
    public class MazeGame
    {
        // 迷宫组件的种类可以变化，创建也进行了简化
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2, Direction.West);

            return builder.GetMaze();
        }

        public void SqlConnectionStringBuilderDemo()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = ".";
            builder.InitialCatalog = "MyDB";
            builder.UserID = "SA";
            builder.Password = "123456";

            String connectionString = builder.ConnectionString;
        }
    }
}
