namespace MineSweeper
{
    using System;

    public class Points
    {
        private string userName;
        private int userPoints;

        public Points()
        {
        }

        public Points(string name, int points)
        {
            this.userName = name;
            this.userPoints = points;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public int UserPoints
        {
            get { return userPoints; }
            set { userPoints = value; }
        }
    }
}
