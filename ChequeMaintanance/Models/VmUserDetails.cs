namespace ChequeMaintanance.Models
{
    public class VmUserDetails
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActiveUser { get; set; }
        public bool IsUserDeleted { get; set; }
        public string UserFullName { get; set; }
        public bool IsAuthenticated { get; set; }
        public string ErrorMessage { get; set; }
    }
}