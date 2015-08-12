namespace Task2.IfStatements
{
    using System;

    class IfStatements
    {
        static void Main()
        {
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                if (potato.isPeeled && !potato.isRotten)
                {
                    potato.Cook();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }

            ///second if to refactor
            const int minX = 0;
            const int maxX = 1;
            const int minY = 2;
            const int maxY = 3;

            int x = 1;
            int y = 5;

            bool visitCell = true;

            if (isInRange(x, minX, maxX) &&
                isInRange(y, minY, maxY) &&
                visitCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        public static bool isInRange(int value, int min, int max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            return false;
        }        
    }
}
