using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OwenThanhHa.Models
{
    public partial class UserMasterData
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên")]
       
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Vui lòng nhập đúng định dạng Email")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Password")]
        [StringLength(16,ErrorMessage ="Độ dài phải lớn hơn 6")]
        public string Password { get; set; }
        public Nullable<bool> isAdmin { get; set; }
    }
}