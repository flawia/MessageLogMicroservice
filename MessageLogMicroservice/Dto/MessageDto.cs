using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.ComponentModel.DataAnnotations;

namespace MessageLoggerMicroservice.Dto
{
    public class MessageDto
    {
        [Required]
        public int? Id { get; set; }

        [BindRequired]
        public DateTime Date { get; set; }

        [StringLength(255)]
        [Required]
        public string Text { get; set; }
    }
}
