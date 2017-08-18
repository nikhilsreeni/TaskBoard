namespace TaskBoard.DomainModel
{
    using System;

    public partial class User
    {
        public Guid UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }
    }
}
