using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MVCApp.Hub
{
    public class CategoryHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public async Task SendCategoryUpdate(string  categoryName, int orderQuantity)
        {
            await Clients.All.SendAsync("ReceiveCategoryUpdate", categoryName, orderQuantity);
        }
    }
}
