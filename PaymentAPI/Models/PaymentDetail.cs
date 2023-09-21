using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key] //Chú thích này xác định trường PaymentDetailId là trường khóa chính
        public int PaymentDetailId { get; set; }
        //Chú thích này xác định định dạng và kích thước dữ liệu 
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }
    }
}
