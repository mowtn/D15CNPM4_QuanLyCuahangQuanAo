using OwenThanhHa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OwenThanhHa.Context
{
   
        [MetadataType(typeof(UserMasterData))]//validate: search gg, productmasterdata bị ràng buộc dữ liệu trong models
        public partial class User
        {
            
        }

        [MetadataType(typeof(ProductMasterData))]//
        public partial class Product// là class patial c
        {

            [NotMapped]
            public System.Web.HttpPostedFileBase ImageUpload { get; set; } //biến để tương tác với file ảnh
        }
        [MetadataType(typeof(OrderMasterData))]//
        public partial class Order// là class patial c
        {

        }

}