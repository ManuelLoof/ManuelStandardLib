using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.ManuelStandardLib.Scripts.Input
{
    /// <summary>
    /// Setzt in jedes MonoBehavier mit IRequireUserInput den StandardInputProxy.
    /// </summary>
    public class ArrangeStandardUserInput : MonoBehaviour
    {
        public MonoBehaviour Player;
        public IUserInputProxy _proxy;

        void Start()
        {

            SetProxy(); 
            AppendProxyToAllNeeded(_proxy); 

        }

        protected virtual void SetProxy()
        {
            _proxy = new StandardInputProxy(); // -> StandardInputProxy für die normale Steuerung; TouchControlInputProxy für TouchSteuerung
        }


        protected void AppendProxyToAllNeeded(IUserInputProxy proxy)
        {
            var components = GameObject.FindObjectsOfType<MonoBehaviour>();
            var dependents = components.Where(c => c is IRequireUserInput)
            .Cast<IRequireUserInput>();
            foreach (IRequireUserInput dependent in dependents)
                dependent.InputProxy = proxy;

        }
    }
}
