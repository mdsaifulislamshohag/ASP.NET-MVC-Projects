using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabManagementSystem.Models
{
    public class LabEquipmentRelation
    {
        [Key]
        public int Id { get; set; }
        public int LabId { get; set; }
        public int EquipmentId { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
