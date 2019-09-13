
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sorteio.models
{

    [Table("area")]
    public class Area
    {

        [Column("id")]
        [Required]
        public long Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("creation_date")]
        [Required]
        public DateTime CreationDate { get; set; }

        public Area() {
            this.CreationDate = DateTime.Now;
        }

        public Area(string Name) : this()
        {
            this.Name = Name;
        }

        public override string ToString() => $"{this.Id}\t{this.Name} [{this.CreationDate}]";

    }

}