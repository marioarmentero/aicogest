﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace aicoffi.Droid.Utils
{
    public interface IPageController
    {
		
			Rectangle ContainerArea { get; set; }

			bool IgnoresContainerArea { get; set; }

			ObservableCollection<Element> InternalChildren { get; }

			void SendAppearing();

			void SendDisappearing();
		
	}
}