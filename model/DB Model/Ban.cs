namespace Game_Kursak_Admin.model.DB_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ban")]
    public partial class Ban
    {
        public int Id { get; set; }

        public int? PC_ID_And_Name_Id { get; set; }

        public virtual PC_Name_And_ID PC_Name_And_ID { get; set; }
    }
}
