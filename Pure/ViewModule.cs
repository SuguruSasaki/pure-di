using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public class ViewModel
    {
        /// <summary>
        /// 依存オブジェクト
        /// </summary>
        public abstract class Dependency { }

        /// <summary>
        /// パラメータオブジェクト 
        /// </summary>
        public abstract class Payload { }

        /// <summary>
        /// 依存性の注入、Pure DIは依存性とパラメータを同時に渡します。
        /// </summary>
        /// <param name="dependency">依存オブジェクト</param>
        /// <param name="payload">インスタンスに渡すパラメータ</param>
        public virtual void Inject(Dependency dependency, Payload payload) { }
    }
}
