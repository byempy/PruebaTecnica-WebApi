namespace ApiHotels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hotel")]
    public partial class Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            HotelDetail = new HashSet<HotelDetail>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? Categoria { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [StringLength(150)]
        public string foto { get; set; }

        public bool Destacado { get; set;  }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelDetail> HotelDetail { get; set; }
    }
}
