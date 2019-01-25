using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public interface IFactory<T> {
        T Create(TargetPayload payload);
    }

    public class Factory<T>: IFactory<T> where T : TargetType, new() {

        /// <summary>
        /// Create lazy function (using closure)
        /// </summary>
        private Func<TargetDepedency> _dependencyClosure;

        /// <summary>
        /// Constructor
        /// inject closure function
        /// </summary>
        /// <param name="dependency">closure function</param>
        public Factory(Func<TargetDepedency> dependency) {
            this._dependencyClosure = dependency;
        }

        /// <summary>s
        /// create object
        /// </summary>
        /// <param name="payload">payload parameters</param>
        /// <returns></returns>
        public T Create(TargetPayload payload) {
            var newClass = new T();
            newClass.Inject(dependency: this._dependencyClosure(), payload: payload);
            return newClass;
        }
    }
}
