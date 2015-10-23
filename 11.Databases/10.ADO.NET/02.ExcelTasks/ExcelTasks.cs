namespace _02.ExcelTasks
{
    using System;
    using System.Data.OleDb;

    class ExcelTasks
    {
        private OleDbConnection fileConnection;

        static void Main()
        {
            ExcelTasks example = new ExcelTasks();

            example.ConnectToFile();

            using (example.fileConnection)
            {
                example.GetAllScores(); //Task 6
                example.AddScore("Pesho", 3); //Task 7
            }
        }

        //6.Create an Excel file with 2 columns: name and score:Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.
        private void GetAllScores()
        {
            OleDbCommand cmdAllScores = new OleDbCommand("SELECT * FROM [scores$]", fileConnection);
            OleDbDataReader reader = cmdAllScores.ExecuteReader();


            while (reader.Read())
            {
                string name = (string)reader["Name"];
                double score = (double)reader["Score"];
                Console.WriteLine("{0}: {1}", name, score);
            }
        }

        //7.Implement appending new rows to the Excel file.
        private void AddScore(string name, double score)
        {
            OleDbCommand cmd = new OleDbCommand(
                "INSERT INTO [scores$] ([Name], [Score]) VALUES (@name, @score)", fileConnection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@score", score);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Row inserted successfully.");

        }

        private void ConnectToFile()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=..\..\Students.xls;Extended Properties='Excel 8.0;HDR=YES;'";

            fileConnection = new OleDbConnection(connectionString);
            fileConnection.Open();
        }
    }
}
