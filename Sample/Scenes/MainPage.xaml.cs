﻿using Pure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Sample.Scenes
{
    public struct MainPageParam: ITargetType {
        public MainPage.Dependency Dependency { get; set; }
        public MainPage.Payload Payload { get; set; }

        public void Inject(IDepedencyType dependency, IPayloadType payload) {
            this.Dependency = (MainPage.Dependency)dependency;
            this.Payload = (MainPage.Payload)payload;
        }
    }

    public sealed partial class MainPage : Page
    {
        public struct Dependency: IDepedencyType {
            public ICalculator CalcFunc;
        }
        
        public struct Payload: IPayloadType {
            public string Name;
        }
       
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            base.OnNavigatedTo(e);
            var param = (MainPageParam)e.Parameter;

            Debug.WriteLine(param.Payload.Name.ToString());
            Debug.WriteLine(param.Dependency.CalcFunc.Calc(10, 20));
        }
    }
}
