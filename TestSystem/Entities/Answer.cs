using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.Entities
{
    [Table("tblAnswer")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Text { get; set; }
        public bool IsTrue { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
