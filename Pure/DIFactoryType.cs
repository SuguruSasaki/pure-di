using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public interface DIFactoryType
    {
        /// <summary>
        /// DIModuleオブジェクトを生成
        /// </summary>
        /// <param name="payload">Payloadオブジェクト</param>
        /// <returns></returns>
        Module Create(Module.Payload payload);
    }
}
