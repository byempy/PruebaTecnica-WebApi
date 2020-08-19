namespace ApiHotels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelDetail")]
    public partial class HotelDetail
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Ciudad { get; set; }

        [StringLength(150)]
        public string Imagen { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [StringLength(200)]
        public string Caracteristicas { get; set; }

        public int? IdHotel { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}
