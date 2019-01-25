using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public interface TargetType
    {
        void Inject(TargetDepedency dependency, TargetPayload payload);
    }

    public interface TargetDepedency {

    }

    public interface TargetPayload {

    }
}
