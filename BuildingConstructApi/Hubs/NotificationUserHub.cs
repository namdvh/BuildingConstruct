using Application.System.Notifies;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace BuildingConstructApi.Hubs
{
    public class NotificationUserHub : Hub
    {
        private readonly IUserConnectionManager _userConnectionManager;
        private IHttpContextAccessor _accessor;

        public NotificationUserHub(IUserConnectionManager userConnectionManager, IHttpContextAccessor accessor)
        {
            _userConnectionManager = userConnectionManager;
            _accessor = accessor;
        }
        public string GetConnectionId()
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            _userConnectionManager.KeepUserConnection(userID, Context.ConnectionId);

            return Context.ConnectionId;
        }

        public async override Task OnDisconnectedAsync(Exception exception)
        {
            //get the connectionId
            var connectionId = Context.ConnectionId;
            _userConnectionManager.RemoveUserConnection(connectionId);
            var value = await Task.FromResult(0);//adding dump code to follow the template of Hub > OnDisconnectedAsync
        }
    }
}
