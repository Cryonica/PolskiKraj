using PolskiKraj.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PolskiKraj
{

    public class SplashPage : ContentPage
    {
        private readonly Image SplashImage;
        private readonly BoxView BackgroundLayer1;
        private readonly BoxView BackgroundLayer2;
        private readonly BoxView BackgroundLayer3;
        private readonly BoxView BackgroundLayer4;
        private readonly Grid LayoutRoot;


        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            AbsoluteLayout sub = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "new_logo.png",
                WidthRequest = 300,
                HeightRequest = 300
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(SplashImage);
            //Application.Current.Resources.TryGetValue("launcher_background", out var backgroundColor);


            LayoutRoot = new Grid
            {
                BackgroundColor = Color.FromHex("#1b1b3b")
            };
            BackgroundLayer1 = new BoxView
            {
                BackgroundColor = Color.FromHex("#1565C0")
            };
            BackgroundLayer2 = new BoxView
            {
                BackgroundColor = Color.FromHex("#1976D2"),

            };
            BackgroundLayer3 = new BoxView
            {
                BackgroundColor = Color.FromHex("#1E88E5")
            };
            BackgroundLayer4 = new BoxView
            {
                BackgroundColor = Color.FromHex("#2196F3")
            };

            LayoutRoot.Children.Add(BackgroundLayer1);
            LayoutRoot.Children.Add(BackgroundLayer2);
            LayoutRoot.Children.Add(BackgroundLayer3);
            LayoutRoot.Children.Add(BackgroundLayer4);
            LayoutRoot.Children.Add(SplashImage);

            //LayoutRoot.Children.Add(sub);

            Content = LayoutRoot;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            AnimateBackground();
            await Task.Run(() => LogoAnimation());




        }
        private void AnimateBackground()
        {

            AnimateBackgroundLayer1();
            AnimateBackgroundLayer2();
            AnimateBackgroundLayer3();
            AnimateBackgroundLayer4();
        }
        private async void AnimateBackgroundLayer1()
        {
            while (true)
            {
                _ = await BackgroundLayer1.ScaleTo(0.9, 2500, Easing.SinOut);
                _ = await BackgroundLayer1.ScaleTo(1.2, 1750, Easing.SinInOut);
            }
        }

        private async void AnimateBackgroundLayer2()
        {
            while (true)
            {
                _ = await BackgroundLayer2.ScaleTo(0.8, 2750, Easing.SinOut);
                _ = await BackgroundLayer2.ScaleTo(1, 2250, Easing.SinInOut);
            }
        }

        private async void AnimateBackgroundLayer3()
        {
            while (true)
            {
                _ = await BackgroundLayer3.ScaleTo(0.7, 3000, Easing.SinInOut);
                _ = await BackgroundLayer3.ScaleTo(0.9, 2500, Easing.SinOut);

            }
        }

        private async void AnimateBackgroundLayer4()
        {
            while (true)
            {
                _ = await BackgroundLayer4.ScaleTo(0.6, 1750, Easing.SinOut);
                _ = await BackgroundLayer4.ScaleTo(0.8, 2000, Easing.SinInOut);
            }
        }
        private void LogoAnimation()
        {
            Animation parentAnimation = new Animation();
            Animation scaleUp1Animation = new Animation(v => SplashImage.Scale = v, 0.9, 0.7, Easing.Linear);
            Animation scaleDownAnimation = new Animation(v => SplashImage.Scale = v, 0.7, 0.9, Easing.Linear);
            Animation scaleUp2Animation = new Animation(v => SplashImage.Scale = v, 0.9, 0.8, Easing.Linear);
            Animation opacityAnimation = new Animation(v => this.Opacity = v, 0.9, 0, Easing.Linear);

            parentAnimation.Add(0, 0.3, scaleUp1Animation);
            parentAnimation.Add(0.3, 0.6, scaleDownAnimation);
            parentAnimation.Add(0.6, 1, scaleUp2Animation);
            parentAnimation.Add(0.8, 1, opacityAnimation);



            parentAnimation.Commit(this, "ChildAnimations", 16, 5000, null, (v, c) =>
            {

                Application.Current.MainPage = new AppShell();

            });

        }


    }
}
