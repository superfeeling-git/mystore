using System;

namespace MyStore.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
