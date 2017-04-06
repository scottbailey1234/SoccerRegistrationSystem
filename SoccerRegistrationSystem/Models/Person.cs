﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRegistrationSystem.Models
{
    public abstract class Person
    {
        public int ID { get; set; }


        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Display(Name = "Player First Name")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Middle name cannot be longer than 50 characters.")]
        [Display(Name = "Player Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        [Display(Name = "Player Last Name")]
        public string LastName { get; set; }

        public DateTime BirthDay;
    }
}
