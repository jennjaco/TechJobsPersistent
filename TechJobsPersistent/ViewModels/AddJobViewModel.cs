using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }
        public List<Skill> Skills { get; set; }

        public AddJobViewModel(List<Employer> possibleEmployers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();


            Skills = skills;

            foreach (var employer in possibleEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }


        public AddJobViewModel()
        {
        }
    }
}
