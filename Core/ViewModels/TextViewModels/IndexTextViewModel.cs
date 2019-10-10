using System.Collections.Generic;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.TextViewModels
{
    public class IndexTextViewModel 
    {
        public Text LastAddedText { get; set; }
        public List<Text> LastAddedTexts { get; set; }
    }
}