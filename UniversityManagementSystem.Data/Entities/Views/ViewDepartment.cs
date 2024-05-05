using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data.Commons;

namespace UniversityManagementSystem.Data.Entities.Views
{
    [Keyless]
    public class ViewDepartment : GeneralLocalizableEntity
    {
        public int DID { get; set; }
        public string? DNameAr { get; set; }
        public string? DNameEn { get; set; }
        public int StudentCount { get; set; }
    }
}
