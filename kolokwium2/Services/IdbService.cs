using kolokwium2.Models;

namespace kolokwium2.Services;

public interface IdbService
{
    Task<Item> GetItemById(int IdItem);
    Task AddNewItem(int IdCharacter, int IdItem);
    Task<bool> DoItemsExist(List<int> ids);
    // Task<bool> CanHeHandleIt(int IdCharacter);
}