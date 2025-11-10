using Composition.WindowsRuntimeHelpers;
using System.Configuration;
using System.Data;
using System.Windows;
using Windows.System;

namespace ScreenCapture
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DispatcherQueueController _controller;

        public App()
        {
            _controller = CoreMessagingHelper.CreateDispatcherQueueControllerForCurrentThread();
        }
    }
}
