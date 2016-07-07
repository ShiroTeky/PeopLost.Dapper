using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopLost.Models
{
    /// <summary>
    /// Flux d'actualites de la personnes disparues
    /// </summary>
    public class TimeLineViewModel
    {

    }

    /// <summary>
    /// Affichage des commentaires du flux d'actualites
    /// </summary>
    public class CommentViewModel
    {

    }

    /// <summary>
    /// Affichages des personnes disparues sur une carte
    /// </summary>
    public class PeopleMapsViewModel
    {

    }

    /// <summary>
    /// Affichages des personnes disparues sur la page d'accueil 
    /// </summary>
    public class PeoplesViewModel
    {
        private ICollection<Looser> peoples { get; set; }
    }

    /// <summary>
    /// Affichages des personnes retrouvees 
    /// </summary>
    public class PeoplesFoundViewModel
    {

    }

    /// <summary>
    /// Personne disparues
    /// </summary>
    public class PeopleViewModel
    {
        [Required]
        [Display(Name = "peopleId")]
        public int peopleId { get; set; }

        [Required]
        [Display(Name = "firstname")]
        public string firstname { get; set; }

        [Required]
        [Display(Name = "lastname")]
        public string lastname { get; set; }

        [Required]
        [Display(Name = "gender")]
        public string gender { get; set; }

        [Required]
        [Display(Name = "daykidnapping")]
        public DateTime daykidnapping { get; set; }

        [Required]
        [Display(Name = "looseradress")]
        public string looseradress { get; set; }

        [Required]
        [Display(Name = "contact")]
        public string contact { get; set; }

        public byte[] photo{ get; set; }

        [Required]
        [Display(Name = "mimetype")]
        public string mimetype { get; set; }

        [Required]
        [Display(Name = "country")]
        public string country { get; set; }

        [Required]
        [Display(Name = "town")]
        public string town { get; set; }

        [Required]
        [Display(Name = "age")]
        public int age { get; set; }

        [Required]
        [Display(Name = "specifications")]
        public string specifications { get; set; }

        public override string ToString(){
            return (firstname+" "+lastname);
        }
    }
}