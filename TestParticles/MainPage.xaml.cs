namespace TestParticles;

public partial class MainPage : ContentPage
{
    // Started a new .NET MAUI Projet (.NET 7 - same result with .NET 6)
    // Added the NuGet Particle.MAUI 1.0.3
    // Added the .UseSkiaSharp() in the MauiProgram.cs
    // Added the namespace to the mainpage.xaml : xmlns:particle="clr-namespace:Particle.Maui;assembly=Particle.Maui"
    // Added the particle viewport
    /*
        <particle:ParticleView x:Name="MyParticleCanvas"
                                  FallingParticlesPerSecond="25.0"
                                  IsActive="True"
                                  IsRunning="True"
                                  HasFallingParticles="True"
                                  Margin="0, 20"
                                  VerticalOptions="FillAndExpand"
                                  HorizontalOptions="FillAndExpand"
                                  InputTransparent="True"/>
    */
    public MainPage()
	{
		InitializeComponent();
	}
}

