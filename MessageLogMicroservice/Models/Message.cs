using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MessageLogMicroservice.Models
{
    public class Message
    {
        public Message(int id, string text, DateTime date)
        {
            Id = id;
            Text = text;
            Date = date;
        }

        [BindRequired]
        [Required]
        public int Id { get; }

        [BindRequired]
        [Required]
        public DateTime Date { get; }
        
        [StringLength(255)]
        [BindRequired]
        [Required]
        public string Text { get; }

        public override string ToString()
        {
            return $"{Date.ToString("yyyy-MM-dd HH:mm:ss")}: {Text}";
        }
    }
}
