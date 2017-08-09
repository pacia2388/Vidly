using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /*Custom Validaion
         * Other than PayAsYouGo
         * Customer must be 18 years and above*/
        [Display(Name = "Date of Birth")]
        [Min18YearsOfAgeIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        //Implicitly Required
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}