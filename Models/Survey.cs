using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SurveyWithModel.Models{
    public class Survey{

        [Required]
        [MinLength(2)]
        [Display(Name= "Name")]
        public string name{get;set;}

        [Required]
        [Display(Name= "Location:")]
        public string location{get;set;}

        [Required]
        [Display(Name= "Favorite Language:")]
        public string language{get;set;}

        [Display(Name= "Comments(Optional):")]       
        [MinLength(20)] 
        public string comments{get;set;}

    }
}