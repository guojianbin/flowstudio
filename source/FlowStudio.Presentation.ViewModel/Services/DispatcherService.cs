﻿// Copyright (C) 2013 João Pedro Correia - All Rights Reserved
// Code under the terms of the GPLv2 license
// URL: https://github.com/JoaoPe/flowstudio

namespace FlowStudio.Presentation.ViewModel.Services
{
    using System;
    using System.Windows.Threading;

    public static class DispatcherService
    {
        public static void Dispatch(Action action)
        {
            var dispatcher = Dispatcher.CurrentDispatcher;

            if (dispatcher.CheckAccess())
            {
                action();
            }
            else
            {
                dispatcher.BeginInvoke(action);
            }
        }
    }
}
