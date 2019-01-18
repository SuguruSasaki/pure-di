using System;

namespace Pure
{
    public class Factory<T>: DIFactoryType where T : Module, new()
    {
        /// <summary>
        /// 遅延実行するためにラムダ式で保持する
        /// </summary>
        private Func<Module.Dependency> _dependencyClosure;

        /// <summary>
        /// コンストラクタでラムダ関数を注入
        /// </summary>
        /// <param name="dependency">依存オブジェクトを生成するラムダ関数</param>
        public Factory(Func<Module.Dependency> dependency) {
            this._dependencyClosure = dependency;
        }

        /// <summary>s
        /// インスタンス生成、依存性の注入を実行
        /// </summary>
        /// <param name="payload">インスタンスに渡すパラメータ</param>
        /// <returns></returns>
        public Module Create(Module.Payload payload) {
            var module = new T();
            module.Inject(dependency: this._dependencyClosure(), payload: payload);
            return module;
        }
    }
}
