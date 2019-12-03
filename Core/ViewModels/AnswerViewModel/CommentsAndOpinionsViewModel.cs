using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.AnswerViewModel
{
    public class CommentsAndOpinionsViewModel
    {
        public List<BookComment> BookComments { get; set; }
        public List<BookOpinion> BookOpinions { get; set; }
    }

}
