using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OwenThanhHa.Models
{
    public partial class ProductMasterData
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tên sản phẩm")]
        [Display(Name ="Tên Sản Phẩm")]
        public string Name { get; set; }
        [Display(Name = "Hình Ảnh")]

        public string Avartar { get; set; }
        [Display(Name = "Danh mục sản phẩm")]

        public Nullable<int> CategoryId { get; set; }
        [Display(Name = "Tên gọi chung ")]

        public string ShortDes { get; set; }
        [Display(Name = "Mô tả của săn phẩm")]

        public string FullDes { get; set; }
        [Display(Name = "Giá trước khuyến mãi")]

        public Nullable<double> Price { get; set; }
        [Display(Name = "Giá được hiển thị")]

        public Nullable<double> PriceDiscount { get; set; }
        [Display(Name = "Danh mục hiển thị")]

        public Nullable<int> TypeID { get; set; }
        [Display(Name = "Thương hiệu")]

        public Nullable<int> BranId { get; set; }
        [Display(Name = "Xóa")]

        public Nullable<bool> Deleted { get; set; }
        [Display(Name = "Hiển thị trang chủ")]

        public Nullable<bool> ShowOnHomePage { get; set; }
        

        public Nullable<int> DisplayOrder { get; set; }
        [Display(Name = "Thời gian tạo")]

        public Nullable<System.DateTime> CreateOnUtc { get; set; }
        [Display(Name = "Thời gian cập nhật")]

        public Nullable<System.DateTime> UpdateOnUtc { get; set; }
        

        public Nullable<int> TypeProduct { get; set; }
        [Display(Name = "Tên gọi chung")]

        public string HderProduct { get; set; }

    }
}