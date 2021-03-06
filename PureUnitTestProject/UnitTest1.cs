﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pure;

namespace PureUnitTestProject {
    [TestClass]
    public class PureDIUnitTest {

        [TestMethod]
        public void DependencyTest() {
            var sample = this.CreateSampleModule();
            Assert.AreEqual(sample.InstanceOfdependency.Title, "Sample Module");
        }

        [TestMethod]
        public void PayloadTest() {
            var sample = this.CreateSampleModule();
            Assert.AreEqual(sample.InstanceOfpayload.Name, "sugurusasaki");
        }

        [TestMethod]
        public void FactoryTest() {
            var factory = new Factory<SampleModule>(
                dependency: () => { return new SampleModule.Dependency { Title = "Sample Module" }; }
            );
            var sample = factory.Create(payload: new SampleModule.Payload { Name = "sugurusasaki" }) as SampleModule;
            Assert.AreEqual(sample.InstanceOfdependency.Title, "Sample Module");
            Assert.AreEqual(sample.InstanceOfpayload.Name, "sugurusasaki");
        }


        private SampleModule CreateSampleModule() {
            var sample = new SampleModule();
            sample.Inject(
                dependency: new SampleModule.Dependency {
                    Title = "Sample Module"
                },
                payload: new SampleModule.Payload {
                    Name = "sugurusasaki"
                }
             );
            return sample;
        }
    }


    // Test用クラス
    class SampleModule : ITargetType {

        public struct Dependency: IDepedencyType {
            public string Title;
        }

        public struct Payload: IPayloadType {
            public string Name;
        };

        public Dependency InstanceOfdependency;
        public Payload InstanceOfpayload;

        public void Inject(IDepedencyType dependency, IPayloadType payload) {
            this.InstanceOfdependency = (Dependency)dependency;
            this.InstanceOfpayload = (Payload)payload;
        }
    }
}
