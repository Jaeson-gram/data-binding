﻿using DataBinding.Pages;

namespace DataBinding;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}
}
