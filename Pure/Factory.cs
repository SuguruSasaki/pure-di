using System;
using System.Collections.Generic;
using System.Text;

namespace Pure
{
    public interface IFactory<T> {
        T Create(IPayloadType payload);
    }

    public sealed class Factory<T>: IFactory<T> where T : ITargetType, new() {

        /// <summary>
        /// Create lazy function (using closure)
        /// </summary>
        private Func<IDepedencyType> _dependencyClosure;

        /// <summary>
        /// Constructor
        /// inject closure function
        /// </summary>
        /// <param name="dependency">closure function</param>
        public Factory(Func<IDepedencyType> dependency) {
            this._dependencyClosure = dependency;
        }

        /// <summary>s
        /// create object
        /// </summary>
        /// <param name="payload">payload parameters</param>
        /// <returns></returns>
        public T Create(IPayloadType payload) {
            var newClass = new T();
            newClass.Inject(dependency: this._dependencyClosure(), payload: payload);
            return newClass;
        }
    }
}
