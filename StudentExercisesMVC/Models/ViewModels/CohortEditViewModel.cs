using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class CohortEditViewModel
    {
       

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is Required Dum! Dum!")]
        [MinLength(3, ErrorMessage = "Name should have at least 3 characters Einstein!")]
        public string Name { get; set; }


        [Display(Name = "Cohort")]
        //[Required]
        public int CohortId { get; set; }

        public List<SelectListItem> CohortOptions { get; set; }

    }
}
