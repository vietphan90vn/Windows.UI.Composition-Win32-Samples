using Composition.WindowsRuntimeHelpers;
using System.Windows;
using Windows.System;

namespace WPFCaptureSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Required to enable WinRT Composition APIs (Windows.UI.Composition) in WPF.
        // Creates a DispatcherQueue on the UI thread before any windows are created,
        // which is necessary for Compositor and screen capture operations to work properly.
        private DispatcherQueueController _controller;

        public App()
        {
            _controller = CoreMessagingHelper.CreateDispatcherQueueControllerForCurrentThread();
        }
    }
}
