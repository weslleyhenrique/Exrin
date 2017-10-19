﻿using Exrin.Abstraction;
using Exrin.Framework;
using ExrinSampleMobileApp.Logic.ViewModel;
using ExrinSampleMobileApp.Proxy;
using ExrinSampleMobileApp.View;

namespace ExrinSampleMobileApp.Logic.Stack
{
	using Framework.Locator;
	using Framework.Locator.Views;

	public class MainStack : BaseStack
    {

        public MainStack(IViewService viewService)
            : base(new NavigationProxy(new Xamarin.Forms.NavigationPage() { Title = "My Title" }), viewService, Stacks.Main, nameof(Main.Main))
        {
            ShowNavigationBar = false;
        }

        protected override void Map()
        {
			base.NavigationMap<AboutView, AboutViewModel>(nameof(Main.About));
            base.NavigationMap<MainView, MainViewModel>(nameof(Main.Main));            
            base.NavigationMap<SettingsView, SettingsViewModel>(nameof(Main.Settings));
			base.NavigationMap<View.ListView, ListViewModel>(nameof(Main.List));
			base.NavigationMap<DetailView, DetailViewModel>(nameof(Main.Detail));
		}

    }
}
