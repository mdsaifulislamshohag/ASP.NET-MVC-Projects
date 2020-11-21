using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabManagementSystem.Models
{
    public class BookEquipment
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int EquipmentId { get; set; }
        public DateTime BookDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool HasReturned { get; set; }
        public bool IsApproved { get; set; }
    }
}
