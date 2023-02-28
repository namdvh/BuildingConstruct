using Data.DataContext;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Notificate;

namespace Application.System.Notifies
{
    public class UserConnectionManager : IUserConnectionManager
    {
        private static Dictionary<string, List<string>> userConnectionMap = new Dictionary<string, List<string>>();
        private static string userConnectionMapLocker = string.Empty;
        private readonly BuildingConstructDbContext _context;

        public UserConnectionManager(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public void KeepUserConnection(string userId, string connectionId)
        {
            lock (userConnectionMapLocker)
            {
                if (!userConnectionMap.ContainsKey(userId))
                {
                    userConnectionMap[userId] = new List<string>();
                }
                userConnectionMap[userId].Add(connectionId);
            }
        }

        public void RemoveUserConnection(string connectionId)
        {
            //Remove the connectionId of user 
            lock (userConnectionMapLocker)
            {
                foreach (var userId in userConnectionMap.Keys)
                {
                    if (userConnectionMap.ContainsKey(userId))
                    {
                        if (userConnectionMap[userId].Contains(connectionId))
                        {
                            userConnectionMap[userId].Remove(connectionId);
                            break;
                        }
                    }
                }
            }
        }
        public List<string> GetUserConnections(string userId)
        {
            var conn = new List<string>();
            lock (userConnectionMapLocker)
            {
                conn = userConnectionMap[userId];
            }
            return conn;
        }

        public async Task<bool> SaveNotification(NotificationModels noti)
        {
            Notification notification = new Notification()
            {
                Title = "",
                UserID = noti.CreateBy,
                CreateBy = noti.CreateBy,
                IsRead = false,
                LastModifiedAt = noti.LastModifiedAt,
                Message = noti.Message,
                Type = noti.NotificationType
            };
            await _context.Notifcations.AddAsync(notification);
            var rs = await _context.SaveChangesAsync();
            if (rs > 0)
            {
                return true;
            }
            return false;
        }
    }
}
