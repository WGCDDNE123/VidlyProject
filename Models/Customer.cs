﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
     public class Customer
     {
          public int Id { get; set; }
          [Required]
          [StringLength(255)]
          public string Name { get; set; }
          public bool IsSubscribedToNewsLetter { get; set; }
          public MembershipType MembershipType { get; set; }
          public byte MembershipTypeId { get; set; }
          public DateTime? BirthDate { get; set; }
     }
}