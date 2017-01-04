using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.ManuelStandardLib.Scripts.Input
{
    /// <summary>
    /// Beispielimplementierung IRequireUserInput.
    /// </summary>
    public class RequireUserInputStandard : IRequireUserInput
    {

        public IUserInputProxy InputProxy
        {
            get;
            set; 
        }

        public RequireUserInputStandard()
        {
            InputProxy = new StandardInputProxy(); 
        }

    }
}
