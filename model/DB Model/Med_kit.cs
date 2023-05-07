namespace Game_Kursak_Admin.model.DB_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Med_kit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Med_kit()
        {
            Player_statistics = new HashSet<Player_statistics>();
        }

        public int ID { get; set; }

        public int Med_kit_picked_up { get; set; }

        public int HP_replenishment_amount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player_statistics> Player_statistics { get; set; }
    }
}
