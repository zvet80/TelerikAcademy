namespace Task1.ClassChef
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = new Potato();
            Carrot carrot = new Carrot();
            Bowl bowl = new Bowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        
        private void Cut(Vegetable vegetable)
        {
            //...
        }

        private void Peel(Vegetable vegetable)
        {

        }

    }
}
