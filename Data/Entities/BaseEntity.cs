namespace Data.Entities
{
    public class BaseEntity
    {
        public DateTime LastModifiedAt { get; set; } = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById("Asia/Bangkok"));

        public Guid CreateBy { get; set; }
    }
}