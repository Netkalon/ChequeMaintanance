namespace ChequeMaintanance
{
    public static class GlobalAccess
    {
        private static int userId;

        public static int GlobalUserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        private static string userFullName = "";

        public static string GlobalUserFullName
        {
            get
            {
                return userFullName;
            }
            set
            {
                userFullName = value;
            }
        }
    }
}