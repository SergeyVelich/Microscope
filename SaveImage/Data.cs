namespace SaveImage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data
    {
        public int Id { get; set; }

        public DateTime Period { get; set; }

        //public int User_Id { get; set; }
        public User User { get; set; }
        //[Required]
        //[StringLength(2)]
        public string Shift { get; set; }

        public WorkCenter WorkCenter { get; set; }

        public Pressform Pressform { get; set; }

        public Color Color { get; set; }

        //[Required]
        //[StringLength(50)]
        public string BoxNumber { get; set; }

        public byte NestNumber { get; set; }

        public int ControlType { get; set; }

        public Defect Defect { get; set; }

        public bool HasDefect { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Photo { get; set; }

        //[Column(TypeName = "text")]
        //[Required]
        public string Comments { get; set; }

        //[Column(TypeName = "text")]
        //[Required]
        public string ClosedNests { get; set; }
    }
}
