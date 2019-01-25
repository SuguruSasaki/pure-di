using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public class ViewModel
    {
        /// <summary>
        /// Dependency class
        /// This class have dependency with ViewModel
        /// </summary>
        public abstract class Dependency { }

        /// <summary>
        /// Payload parameter class.
        /// This class have some parameters.
        /// </summary>
        public abstract class Payload { }

        /// <summary>
        /// Dependency injection, Pure DI passes dependencies and parameters at the same time.
        /// </summary>
        /// <param name="dependency">instance of Dependency</param>
        /// <param name="payload">instance of Payload</param>
        public virtual void Inject(Dependency dependency, Payload payload) { }
    }
}
