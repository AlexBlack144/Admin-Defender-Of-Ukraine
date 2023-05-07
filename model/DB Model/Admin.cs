namespace Game_Kursak_Admin.model.DB_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        public int ID { get; set; }

        [Required]
        [StringLength(8)]
        public string Login { get; set; }

        [Required]
        [StringLength(8)]
        public string Password { get; set; }
    }
}
