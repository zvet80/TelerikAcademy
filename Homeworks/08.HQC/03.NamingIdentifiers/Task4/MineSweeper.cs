namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

	public class MineSweeper
	{
		static void Main()
		{
			string command = string.Empty;
			char[,] field = CreateField();
			char[,] mines = PlaceMines();
			int counter = 0;
			bool isMine = false;
			List<Points> highScores = new List<Points>(6);
			int row = 0;
			int col = 0;
			bool play = true;
			const int maxPoints = 35;
			bool haveMaxPoints = false;

			do
			{
				if (play)
				{
					Console.WriteLine("Let's play MineSweeper. Try to find fields without mines." +
					" Command 'top' shows champions list, 'restart' starts a new game, 'exit' exits the game");
					PrintField(field);
					play = false;
				}
				Console.Write("Enter rows and columns: ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out col) &&
						row <= field.GetLength(0) && col <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						PrintHighScores(highScores);
						break;
					case "restart":
						field = CreateField();
						mines = PlaceMines();
						PrintField(field);
						isMine = false;
						play = false;
						break;
					case "exit":
                        Console.WriteLine("Game over!");
						break;
					case "turn":
						if (mines[row, col] != '*')
						{
							if (mines[row, col] == '-')
							{
								Move(field, mines, row, col);
								counter++;
							}
							if (maxPoints == counter)
							{
								haveMaxPoints = true;
							}
							else
							{
								PrintField(field);
							}
						}
						else
						{
							isMine = true;
						}
						break;
					default:
						Console.WriteLine("\nError! Invalid Command\n");
						break;
				}
				if (isMine)
				{
					PrintField(mines);
					Console.Write("\nYou loose with {0} points. " +
						"Enter nickname: ", counter);
					string nickname = Console.ReadLine();
                    Points user = new Points(nickname, counter);
					if (highScores.Count < 5)
					{
						highScores.Add(user);
					}
					else
					{
						for (int i = 0; i < highScores.Count; i++)
						{
							if (highScores[i].UserPoints < user.UserPoints)
							{
								highScores.Insert(i, user);
								highScores.RemoveAt(highScores.Count - 1);
								break;
							}
						}
					}
                    highScores.Sort((Points user1, Points user2) => user2.UserName.CompareTo(user1.UserName));
                    highScores.Sort((Points user1, Points user2) => user2.UserPoints.CompareTo(user1.UserPoints));
					PrintHighScores(highScores);

					field = CreateField();
					mines = PlaceMines();
					counter = 0;
					isMine = false;
					play = true;
				}
				if (haveMaxPoints)
				{
					Console.WriteLine("\nWell done! You passed 35 cells.");
					PrintField(mines);
					Console.WriteLine("Enter your name: ");
					string name = Console.ReadLine();
					Points userPoints = new Points(name, counter);
					highScores.Add(userPoints);
					PrintHighScores(highScores);
					field = CreateField();
					mines = PlaceMines();
					counter = 0;
					haveMaxPoints = false;
					play = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("You win!");
			Console.WriteLine("Well done!");
			Console.Read();
		}

		private static void PrintHighScores(List<Points> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells",
						i + 1, points[i].UserName, points[i].UserPoints);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty highscore!\n");
			}
		}

		private static void Move(char[,] field,
			char[,] mines, int row, int col)
		{
			char numberOfMines = GetNumberOfMines(mines, row, col);
			mines[row, col] = numberOfMines;
			field[row, col] = numberOfMines;
		}

		private static void PrintField(char[,] field)
		{
			int row = field.GetLength(0);
			int col = field.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < row; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < col; j++)
				{
					Console.Write(string.Format("{0} ", field[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateField()
		{
			int fieldRows = 5;
			int fieldColumns = 10;
			char[,] field = new char[fieldRows, fieldColumns];
			for (int i = 0; i < fieldRows; i++)
			{
				for (int j = 0; j < fieldColumns; j++)
				{
					field[i, j] = '?';
				}
			}

			return field;
		}

		private static char[,] PlaceMines()
		{
			int rows = 5;
			int cols = 10;
			char[,] field = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					field[i, j] = '-';
				}
			}

			List<int> randomList = new List<int>();
			while (randomList.Count < 15)
			{
				Random random = new Random();
				int randNum = random.Next(50);
				if (!randomList.Contains(randNum))
				{
					randomList.Add(randNum);
				}
			}

			foreach (int num in randomList)
			{
				int col = (num / cols);
				int row = (num % cols);
				if (row == 0 && num != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}
				field[col, row - 1] = '*';
			}

			return field;
		}

		private static void CalcPoints(char[,] field)
		{
			int col = field.GetLength(0);
			int row = field.GetLength(1);

			for (int i = 0; i < col; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (field[i, j] != '*')
					{
						char number = GetNumberOfMines(field, i, j);
						field[i, j] = number;
					}
				}
			}
		}

		private static char GetNumberOfMines(char[,] field, int row, int col)
		{
			int count = 0;
			int rows = field.GetLength(0);
			int cols = field.GetLength(1);

			if (row - 1 >= 0)
			{
				if (field[row - 1, col] == '*')
				{ 
					count++; 
				}
			}
			if (row + 1 < rows)
			{
				if (field[row + 1, col] == '*')
				{ 
					count++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (field[row, col - 1] == '*')
				{ 
					count++;
				}
			}
			if (col + 1 < cols)
			{
				if (field[row, col + 1] == '*')
				{ 
					count++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (field[row - 1, col - 1] == '*')
				{ 
					count++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (field[row - 1, col + 1] == '*')
				{ 
					count++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (field[row + 1, col - 1] == '*')
				{ 
					count++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (field[row + 1, col + 1] == '*')
				{ 
					count++; 
				}
			}
			return char.Parse(count.ToString());
		}
	}
}
