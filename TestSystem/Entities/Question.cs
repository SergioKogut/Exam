using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem.Entities
{
    [Table("tblQuestions")]
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Text { get; set; }

        [ForeignKey("Test")]
        public int TestId { get; set; }
        public Test Test { get; set; }
        virtual public ICollection<Answer> Answers { get; set; }
    }
}
