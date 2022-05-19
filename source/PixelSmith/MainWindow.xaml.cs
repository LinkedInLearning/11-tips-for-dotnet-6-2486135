using PixelSmith.Effects;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace PixelSmith
{

  public partial class MainWindow : Window
  {
    bool _rippleEffectActive = false;
    bool _mirrorEffectActive = false;
    public MainWindow()
    {

      InitializeComponent();

      this.Loaded += MainWindow_Loaded;
      mainImage.MouseMove += MainImage_MouseMove;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      mainImage.MouseMove += MainImage_MouseMove;
    }

    private void MainImage_MouseMove(object sender, MouseEventArgs e)
    {

      if (_rippleEffectActive)
      {
        lineX.Visibility = Visibility.Collapsed;
        lineY.Visibility = Visibility.Collapsed;
        _rippleEffect.Frequency = 10 * (e.GetPosition(mainImage).X / mainImage.ActualWidth);

      }
      else
      {
        lineX.Visibility = Visibility.Visible;
        lineY.Visibility = Visibility.Visible;
      }

      if (_mirrorEffectActive)
      {
        lineX.Visibility = Visibility.Collapsed;
        lineY.Visibility = Visibility.Collapsed;
        var location = Math.Max(e.GetPosition(mainImage).Y / mainImage.ActualHeight, .35);
        _mirrorEffect.MirrorLocation = location;
      }
      else
      {
        lineX.Visibility = Visibility.Visible;
        lineY.Visibility = Visibility.Visible;
      }

      var positionString = String.Format("{0:#000} - {1:#000}",
                                          e.GetPosition(mainImage).X,
                                          e.GetPosition(mainImage).Y);
      PostionTextBlock.Text = positionString;


      #region lineX
      lineX.X1 = 0;
      lineX.Y1 = e.GetPosition(mainImage).Y;

      lineX.X2 = mainImage.ActualWidth;
      lineX.Y2 = lineX.Y1;
      #endregion
      #region lineY

      {

      }

      lineY.X1 = e.GetPosition(this).X;
      lineY.Y1 = 0;

      lineY.X2 = lineY.X1;
      lineY.Y2 = mainImage.ActualHeight;


      #endregion


    }

    private static Random _random = new Random();


    private void ColorToneMenu_Click(object sender, RoutedEventArgs e)
    {
      _rippleEffectActive = false;
      var effect = new PixelSmith.Effects.ColorToneEffect();

      effect.DarkColor = Colors.Orange;
      effect.LightColor = Colors.AliceBlue;

      mainImage.Effect = effect;
    }

    private void ToonMenu_Click(object sender, RoutedEventArgs e)
    {
      _rippleEffectActive = false;
      var effect = new PixelSmith.Effects.ToonShaderEffect();

      effect.Levels = 5;

      mainImage.Effect = effect;
    }

    private void MonochromeMenu_Click(object sender, RoutedEventArgs e)
    {
      _rippleEffectActive = false;
      var effect = new PixelSmith.Effects.MonochromeEffect();

      effect.FilterColor = Colors.Tan;

      mainImage.Effect = effect;
    }

    private void AboutMenu_Click(object sender, RoutedEventArgs e)
    {
      this.Effect = new BlurEffect();
      lineX.Visibility = Visibility.Collapsed;
      lineY.Visibility = Visibility.Collapsed;
      var view = new AboutView();
      view.ShowDialog();
      this.Effect = null;
      lineX.Visibility = Visibility.Visible;
      lineY.Visibility = Visibility.Visible;
    }
    private PixelSmith.Effects.RippleEffect _rippleEffect = new PixelSmith.Effects.RippleEffect();
    private void RippleMenu_Click(object sender, RoutedEventArgs e)
    {
      _rippleEffectActive = true;
      _rippleEffect.Amplitude = 1.6;
      mainImage.Effect = _rippleEffect;

    }

    private void AnimatedMenu_Click(object sender, RoutedEventArgs e)
    {
      var win = new SplashWindow();
      win.Show();
    }

    private void NoEffectMenu_Click(object sender, RoutedEventArgs e)
    {
      mainImage.Effect = null;
    }




    private MirrorHorizontalEffect _mirrorEffect = new MirrorHorizontalEffect();
    private void MirrorMenu_Click(object sender, RoutedEventArgs e)
    {
      _rippleEffectActive = false;
      _mirrorEffectActive = true;

      _mirrorEffect.MirrorLocation = .5;

      mainImage.Effect = _mirrorEffect;
    }

    private void Seashore_Click(object sender, RoutedEventArgs e)
    {
      mainImage.Source = (this.Resources["Image1"] as Image).Source;

    }

    private void Staircase_Click(object sender, RoutedEventArgs e)
    {
      mainImage.Source = (this.Resources["Image2"] as Image).Source;
    }
  }
}
