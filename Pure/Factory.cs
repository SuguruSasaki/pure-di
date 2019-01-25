﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public interface IFactory<T> {

        T Create(TargetPayload payload);
    }


    public class Factory<Class>: IFactory<Class> where Class : TargetType, new() {

        /// <summary>
        /// 遅延実行するためにラムダ式で保持する
        /// </summary>
        private Func<TargetDepedency> _dependencyClosure;

        /// <summary>
        /// コンストラクタでラムダ関数を注入
        /// </summary>
        /// <param name="dependency">依存オブジェクトを生成するラムダ関数</param>
        public Factory(Func<TargetDepedency> dependency) {
            this._dependencyClosure = dependency;
        }

        /// <summary>s
        /// インスタンス生成、依存性の注入を実行
        /// </summary>
        /// <param name="payload">インスタンスに渡すパラメータ</param>
        /// <returns></returns>
        public Class Create(TargetPayload payload) {
            var newClass = new Class();
            newClass.Inject(dependency: this._dependencyClosure(), payload: payload);
            return newClass;
        }
    }
}
