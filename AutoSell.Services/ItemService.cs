using AutoSell.Data.Context;
using AutoSell.Data.Models;
using AutoSell.Services.Repositories;

namespace AutoSell.Services
{
    public class ItemService : ModelService<Item>, IItemRepository
    {
        /// <summary>
        /// The service used to query the Items table
        /// </summary>
        /// <param name="autoSellContext"></param>
        public ItemService(AutoSellContext autoSellContext) : base(autoSellContext, autoSellContext.Items)
        { }
    }
}
