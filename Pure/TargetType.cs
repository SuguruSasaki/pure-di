using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public interface ITargetType
    {
        /// <summary>
        /// Inject Dependency and Payload parameters.
        /// </summary>
        /// <param name="dependency"></param>
        /// <param name="payload"></param>
        void Inject(IDepedencyType dependency, IPayloadType payload);
    }

    public interface IDepedencyType {

    }

    public interface IPayloadType {

    }
}
