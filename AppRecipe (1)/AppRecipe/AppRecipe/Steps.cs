using System;

namespace AppRecipe
{
    public class Steps
    {
        private string stepDescription;

        public Steps(string stepDescription)
        {
            this.stepDescription = stepDescription;
        }

        public string Description { get; set; } // gets and sets description
    }
}
