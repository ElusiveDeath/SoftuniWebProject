using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConnectingPeople.Web.ViewModels.Forms
{
    public class ApplyFormInputModel
    {
        private const string stringLengthErrorMessage = "Полето \"{0}\" трябва да бъде между {2} и {1} символа.";
        private const string requiredFieldErrorMessage = "Полето \"{0}\" e задължително!";

        public int HelpTaskId { get; set; }

        public string About { get; set; }

        public string TaskCreatorUsername { get; set; }

        public string TaskCreatorConnectionId { get; set; }

        public string OthersideUsername { get; set; }

        public string OthersideConnectionId { get; set; }

        [Required(ErrorMessage = requiredFieldErrorMessage)]
        [StringLength(500, ErrorMessage = stringLengthErrorMessage, MinimumLength = 10)]
        [Display(Name = "Съобщение:")]
        public string MessageText { get; set; }
    }
}
