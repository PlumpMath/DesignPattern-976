using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using DesignPattern.CreationalPatterns.MapSites.Abstract;

namespace DesignPattern.CreationalPatterns.AbstractFactory
{
    public class MazeGame
    {
        // 迷宫组件的种类由工厂对象决定
        public Maze CreateMaze(MazeFactory mazeFactory)
        {
            Maze maze = mazeFactory.MakeMze();
            Room room1 = mazeFactory.MakeRoom(1);
            Room room2 = mazeFactory.MakeRoom(2);
            Door door = mazeFactory.MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, mazeFactory.MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, mazeFactory.MakeWall());
            room1.SetSide(Direction.West, mazeFactory.MakeWall());

            room2.SetSide(Direction.North, mazeFactory.MakeWall());
            room2.SetSide(Direction.East, mazeFactory.MakeWall());
            room2.SetSide(Direction.South, mazeFactory.MakeWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }

        public void DbProviderFactoryDemo()
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");

            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = "connectionString";

                DbCommand command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "select top 10 * from [Table]";
                command.CommandType = CommandType.Text;

                using (DbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        // todo: get data
                    }
                }
            }
        }
    }
}
