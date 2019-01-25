using System;

namespace Pure
{
    public class Factory<T>: FactoryType where T : ViewModel, new()
    {
        /// <summary>
        /// 遅延実行するためにラムダ式で保持する
        /// </summary>
        private Func<ViewModel.Dependency> _dependencyClosure;

        /// <summary>
        /// コンストラクタでラムダ関数を注入
        /// </summary>
        /// <param name="dependency">依存オブジェクトを生成するラムダ関数</param>
        public Factory(Func<ViewModel.Dependency> dependency) {
            this._dependencyClosure = dependency;
        }
        
        /// <summary>s
        /// インスタンス生成、依存性の注入を実行
        /// </summary>
        /// <param name="payload">インスタンスに渡すパラメータ</param>
        /// <returns></returns>
        public ViewModel Create(ViewModel.Payload payload) {
            var viewModel = new T();
            viewModel.Inject(dependency: this._dependencyClosure(), payload: payload);
            return viewModel;
        }
    }
}
