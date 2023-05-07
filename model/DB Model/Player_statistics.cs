namespace Game_Kursak_Admin.model.DB_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player_statistics
    {
        public int Id { get; set; }

        public int? PC_ID_And_Name_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nick_name { get; set; }

        public int Kills { get; set; }

        public int? Spent_ammo_id { get; set; }

        public int? Med_kit_id { get; set; }

        public int? Weapon_id { get; set; }

        [Required]
        public string Game_time { get; set; }

        public virtual Med_kit Med_kit { get; set; }

        public virtual PC_Name_And_ID PC_Name_And_ID { get; set; }

        public virtual Spent_ammo Spent_ammo { get; set; }

        public virtual Weapon Weapon { get; set; }
    }
}
