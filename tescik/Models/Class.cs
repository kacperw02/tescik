namespace Projekt_bazy.Models
{

    using System;
    using System.ComponentModel.DataAnnotations;

    public class Equipment
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string WarehouseName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
    }

    public class Personnel
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Range(18, 65)]
        public int Age { get; set; }

        [Required]
        public string Rank { get; set; }

        [Required]
        public string AssignedWarehouse { get; set; }
    }

    public class Order
    {
        public int ID { get; set; }

        [Required]
        public string EquipmentName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
    }
}
