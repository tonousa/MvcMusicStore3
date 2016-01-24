using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore3.Models
{
    [Bind(Exclude="OrderId")]
    public partial class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        [ScaffoldColumn(false)]
        public string UserName { get; set; }
        [Required(ErrorMessage="First Name required")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required(ErrorMessage="Last Name required")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }
        [Required(ErrorMessage="Address required")]
        [StringLength(70)]
        public string Address { get; set; }
        [Required(ErrorMessage="City required")]
        [StringLength(40)]
        public string City { get; set; }
        [Required(ErrorMessage="State required")]
        [StringLength(40)]
        public string State { get; set; }
        [Required(ErrorMessage="Postal code required")]
        [DisplayName("Postal Code")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage="Country required")]
        [StringLength(40)]
        public string Country { get; set; }
        [Required(ErrorMessage="Phone is required")]
        [StringLength(24)]
        public string Phone { get; set; }
        [Required(ErrorMessage="Email required")]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", 
            ErrorMessage="Email not valid")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }
        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}