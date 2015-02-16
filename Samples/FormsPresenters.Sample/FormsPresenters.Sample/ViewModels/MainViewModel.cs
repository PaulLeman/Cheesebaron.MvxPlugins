﻿using Cirrious.MvvmCross.ViewModels;

namespace FormsPresenters.Sample.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel() { Hello = "Hello, from MvvmCross"; }

        private string _hello;
        public string Hello
        {
            get { return _hello; }
            set
            {
                _hello = value; 
                RaisePropertyChanged(() => Hello);
            }
        }
    }
}
