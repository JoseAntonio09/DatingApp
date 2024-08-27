using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

namespace BethanysPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; }
        public string? CurrentCategory { get; }

        public PieListViewModel(IEnumerable<Pie> pies, string? currentCategory)
        {
            Pies = pies;
            CurrentCategory = currentCategory;  
        
        }

        //public PieListViewModel(IEnumerable<Pie> allPies, string v)
        //{
        //}
    }
}
