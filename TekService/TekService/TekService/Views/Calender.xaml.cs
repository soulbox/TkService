﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekService.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calender : ContentPage
	{
		public Calender ()
		{
			InitializeComponent ();
            txtstatus.Text =  MasterPage.CurrentPage != null ? MasterPage.CurrentPage.Title :"Takvim" ;
		}
	}
}