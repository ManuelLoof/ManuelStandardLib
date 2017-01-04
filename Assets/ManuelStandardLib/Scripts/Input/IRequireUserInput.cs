using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.ManuelStandardLib.Scripts.Input
{
    /// <summary>
    /// Interface sagt aus das diese Klasse einen InputProxy benötigt. 
    /// </summary>
    public interface IRequireUserInput
    {
        IUserInputProxy InputProxy { get; set; }
    }
}
