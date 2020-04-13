using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required Dum! Dum!")]
        [MinLength(3, ErrorMessage = "Last Name should have at least 3 characters Einstein!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required Dum! Dum!")]
        [MinLength(3, ErrorMessage = "Last Name should have at least 3 characters Einstein!")]
        public string LastName { get; set; }

        [Display(Name= "Cohort" )]
        [Required]
        public int CohortId { get; set; }

        [Display(Name = "Slack Handle")]
        [Required]
        public string SlackHandle { get; set; }
     

        public List<SelectListItem> CohortOptions { get; set; }

    }
}
// Adam talks about StudentEditViewiModel in NSS_MVC_INTRO_P11 around 6 min point