using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OwenThanhHa.Models
{
    public partial class OrderMasterData
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên đơn hàng")]
        [Display(Name = "Tên đơn hàng")]
        public string Name { get; set; }
        [Display(Name = "Tên người dùng")]
        public Nullable<int> UserID { get; set; }
        [Display(Name = "Trạng thái")]
        public Nullable<int> Status { get; set; }
        [Display(Name = "Thời gian được tạo")]
        public Nullable<System.DateTime> CreatedOnUTc { get; set; }
    }
}