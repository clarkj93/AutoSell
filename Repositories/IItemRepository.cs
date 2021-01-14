using AutoSell.Data.Models;
using AutoSell.Services.Repositories.Base;

namespace AutoSell.Services.Repositories
{
    public interface IItemRepository : ISearchable<Item>
    { }
}
