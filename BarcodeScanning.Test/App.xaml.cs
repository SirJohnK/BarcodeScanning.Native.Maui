﻿namespace BarcodeScanning.Test;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
    
    // protected override Window CreateWindow(IActivationState? activationState)
    // {
    //     return new Window(new NavigationPage(new MainPage()));
    // }
}
