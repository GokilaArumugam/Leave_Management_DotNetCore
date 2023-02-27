using System.ComponentModel.DataAnnotations;
namespace Leave_Management_DotNetCore.Data
{
    public class LeaveType:BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }  
    }
}
