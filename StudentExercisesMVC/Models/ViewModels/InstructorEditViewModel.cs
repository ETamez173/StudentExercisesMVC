using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class InstructorEditViewModel
    {
        public int Id { get; set; }

     

        [Display(Name = "Instructor Id")]
        public int InstructorId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required Dum! Dum!")]
        [MinLength(3, ErrorMessage = "First Name should have at least 3 characters Einstein!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required Dum! Dum!")]
        [MinLength(3, ErrorMessage = "Last Name should have at least 3 characters Einstein!")]
        public string LastName { get; set; }

        [Display(Name = "Slack Handle")]
        [Required]
        public string SlackHandle { get; set; }


        [Display(Name = "Specialty")]
        [Required]
        public string Specialty { get; set; }

        [Display(Name = "Cohort")]
        [Required]
        public int CohortId { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }



        public List<SelectListItem> CohortOptions { get; set; }

    }
}
// Adam talks about StudentEditViewiModel in NSS_MVC_INTRO_P11 around 6 min point