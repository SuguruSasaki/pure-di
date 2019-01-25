using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public interface FactoryType
    {
        /// <summary>
        /// DIModuleオブジェクトを生成
        /// </summary>
        /// <param name="payload">Payloadオブジェクト</param>
        /// <returns></returns>
        ViewModel Create(ViewModel.Payload payload);
    }
}
