namespace _02.TradeCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Article : IComparable<Article>
    {
        public Article(string barcode, string title, string vendor, double price)
        {
            this.Barcode = barcode;
            this.Title = title;
            this.Vendor = vendor;
            this.Price = price;
        }

        public string Barcode { get; set; }

        public string Title { get; set; }

        public string Vendor { get; set; }

        public double Price { get; set; }

        public int CompareTo(Article article)
        {
            return this.Price.CompareTo(article.Price);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3:F2}", this.Barcode, this.Title, this.Vendor, this.Price);
        }
    }
}
