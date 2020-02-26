﻿using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;

namespace XamPri.ViewModels
{
    public class Page3ViewModel : ViewModelBase
    {
        #region Fields


        #endregion

        public Page3ViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = this.GetType().Name.Replace("ViewModel", "");

        }


        #region Commands

        #endregion


        #region Command methods


        #endregion


        public override void Destroy()
        {
            base.Destroy();
        }
    }
}
