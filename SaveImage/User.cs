namespace SaveImage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        public int Role { get; set; }

        [Required]
        public string UriImage { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        //[Required]
        //[StringLength(50)]
        public string Password { get; set; }
    }
}
