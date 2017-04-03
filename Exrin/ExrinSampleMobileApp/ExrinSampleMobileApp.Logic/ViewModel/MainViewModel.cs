﻿using Exrin.Abstraction;
using Exrin.Framework;
using ExrinSampleMobileApp.Framework.Abstraction.Model;
using ExrinSampleMobileApp.Logic.Base;
using ExrinSampleMobileApp.Logic.VisualState;

namespace ExrinSampleMobileApp.Logic.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private IMainModel _model;
        public MainViewModel(IMainModel model, IExrinContainer exrinContainer)
            : base(exrinContainer, new MainVisualState(model))
        {
            _model = model;
        }

        public IRelayCommand AboutCommand
        {
            get
            {
                return GetCommand(() =>
                {
                    return Execution.ViewModelExecute(new AboutOperation());
                });
            }
        }
    }
}
