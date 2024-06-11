using kolokwium2.Data;
using kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Services;

public class dbService : IdbService
{
    private readonly dbContext _dbContext;

    public dbService(dbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Item> GetItemById(int IdItem)
    {
        return await _dbContext.Items.Where(i => i.IdItem == IdItem).FirstOrDefaultAsync();
    }

    public Task AddNewItem(int IdCharacter, int IdItem)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DoItemsExist(List<int> ids)
    {
        for (int i = 0; i < ids.Count; i++)
        {
            int tmp = ids.IndexOf(i);
            var item = await _dbContext.Items.FirstOrDefaultAsync(i => i.IdItem == tmp);
            if (item == null)
            {
                return false;
            }
        }

        return true;
    }

    // public async Task<bool> CanHeHandleIt(int IdCharacter, List<int> ids)
    // {
    //     
    //     for (int i = 0; i < ids.Count; i++)
    //     {
    //         int tmp = ids.IndexOf(i);
    //         var item = await _dbContext.Items.Select(i => i.Weight).Where(i => i.IdItem)
    //         
    //     }
    //     var result = await _dbContext
    // }
}