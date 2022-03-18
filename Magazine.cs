using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2v2
{
    public class Magazine : List<Article>
    {
        private string namezh;
        private Frequency frequencyzh;
        private System.DateTime datezh;
        private int tzh;
        private List<Article> stats = new List<Article>();

        public Magazine(string NameZh, Frequency FrequencyZh, DateTime DateZh, int TZh)
        {
            namezh = NameZh;
            frequencyzh = FrequencyZh;
            datezh = DateZh;
            tzh = TZh;
        }
        public Magazine()
        {
            namezh = "Новости";
            frequencyzh = Frequency.Monthly;
            datezh = new DateTime(2013, 12, 2);
            tzh = 1000;
        }
        public string NameZh
        {
            get
            {
                return namezh;
            }
        }
        public Frequency FrequencyZh
        {
            get
            {
                return frequencyzh;
            }
        }
        public DateTime DateZh
        {
            get
            {
                return datezh;
            }
        }
        public int TZh
        {
            get
            {
                return tzh;
            }
        }

        public IReadOnlyList<Article> ArticleList
        {
            get
            {
                return stats.AsReadOnly();
            }
        }
        public void AddArticle(params Article[] article)
        {
            stats.AddRange(article);
        }
        public override string ToString()
        {
            return string.Format("\nArticle: {0}", stats);
        }
    }
}
