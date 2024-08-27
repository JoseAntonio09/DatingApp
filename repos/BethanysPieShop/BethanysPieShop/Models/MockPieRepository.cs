
namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new
            MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name="Stramberry Pie", Price =15.95M,
                ShortDescription="Lorem Ipsum ", LongDescription=" is simply dummy text of " +
                    "the printing and typesetting industry. Lorem Ipsum has been the industry's" +
                    " standard dummy text ever since the 1500s, when an unknown printer took a galley" +
                    " of type and scrambled it to make a type specimen book. It has survived not only " +
                    "five centuries, but also the leap into electronic typesetting, remaining essentially" +
                    " unchanged. It was popularised in the 1960s with the release of Letraset sheets " +
                    "containing Lorem Ipsum passages, and more recently with desktop publishing software " +
                    "like Aldus PageMaker including versions of Lorem Ipsum",
                    Category = _categoryRepository.AllCategories.ToList()
                    [0],ImageUrl= "https //gillcleerenpluralsight.blob.windows.net/files/bethanyspieshop/fruitpies/strawberry.jpg", InStock = true,
                    IsPieOfTheWeek= false, ImageThumbnailURL="https://" },
                new Pie {PieId = 2, Name="Cheese cake",Price=18.95M,
                }



            };

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get 
            {
                return AllPies.Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId) => AllPies.FirstOrDefault(p => p.PieId == pieId);

     
    }

}
