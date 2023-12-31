﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
     public class Movie
     {
          public int Id { get; set; }
          [Required]
          [StringLength(255)]
          public string Name { get; set; }
          [Required]
          public Genre Genre { get; set; }
          public Genre GenreId { get; set; }
          public DateTime ReleaseDate { get; set; }
          public DateTime DateAdded { get; set; }
          public byte NumberInStock { get; set; }
          
     }
}