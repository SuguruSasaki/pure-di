using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public interface TargetType
    {
        /// <summary>
        /// Inject Dependency and Payload parameters.
        /// </summary>
        /// <param name="dependency"></param>
        /// <param name="payload"></param>
        void Inject(TargetDepedency dependency, TargetPayload payload);
    }

    public interface TargetDepedency {

    }

    public interface TargetPayload {

    }
}
