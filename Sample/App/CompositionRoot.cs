using Pure;
using Sample.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample {

    public class CompositionRoot {

        public struct Dependency {}

        public struct Payload {}

        /// <summary>
        /// 
        /// </summary>
        public Dependency dependency;

        /// <summary>
        /// 
        /// </summary>
        public Payload payload;

        public IFactory<MainPageParam> MainPageFactory() {
            Func<TargetDepedency> dependency = (() => {
                return new MainPage.Dependency();
            });
            return new Factory<MainPageParam>(dependency: dependency);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dependency"></param>
        /// <param name="payload"></param>
        private CompositionRoot(Dependency dependency, Payload payload) {
            this.dependency = dependency;
            this.payload = payload;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static CompositionRoot Resolve() {

            var dependency = new Dependency();
            var payload = new Payload();

            return new CompositionRoot(dependency: dependency, payload: payload);
        }
    }
}
