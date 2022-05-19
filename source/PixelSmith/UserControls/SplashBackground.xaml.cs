using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTemplate.UserControls;

namespace PixelSmith {

	public partial class SplashBackground : UserControl {
		static Random ran = new Random();
		const int minPath = -150;
		const int maxPath = 300;

		public SplashBackground() {
			InitializeComponent();
			this.Loaded += RouxBackground_Loaded;
		}

		private void RouxBackground_Loaded(object sender, RoutedEventArgs e) {
			for (int i = 0; i < 15; i++)
			{

				// Create a NameScope for the page so that
				// we can use Storyboards.
				NameScope.SetNameScope(this, new NameScope());

				var rotTransform = new RotateTransform();
				var transTransform = new TranslateTransform();
				var scaleTransform = new ScaleTransform();

				// Register the transforms' names with the page
				// so that they can be targeted by a Storyboard.
				string rotateName = "AnimatedRotateTransform" + i;
				this.RegisterName(rotateName, rotTransform);
				this.RegisterName("AnimatedTranslateTransform" + i, transTransform);

				var group = new TransformGroup();
				group.Children.Add(rotTransform);
				group.Children.Add(transTransform);
				group.Children.Add(scaleTransform);

				var star = new Star();
				string fadeName = "Fade" + i;
				this.RegisterName(fadeName, star);
				star.Width = star.Height = ran.Next(20, 160);
				rotTransform.CenterX = star.Width / 2;
				rotTransform.CenterY = star.Height / 2;
				star.Opacity = ran.NextDouble();
				star.RenderTransform = group;

				// Create a Canvas to contain the star
				// and add it to the page.
				Canvas mainPanel = new Canvas();
				mainPanel.Width = 200;
				mainPanel.Height = 200;
				mainPanel.Children.Add(star);
				uGrid1.Children.Add(mainPanel);

				// Create the animation path.
				PathGeometry movePath = new PathGeometry();
				PathFigure pFigure = new PathFigure();
				pFigure.StartPoint = new Point(ran.Next(minPath, maxPath), ran.Next(minPath, maxPath));
				PolyBezierSegment pBezierSegment = new PolyBezierSegment();
				pBezierSegment.Points.Add(new Point(ran.Next(minPath, maxPath), ran.Next(minPath, maxPath)));
				pBezierSegment.Points.Add(new Point(ran.Next(minPath, maxPath), ran.Next(minPath, maxPath)));
				pBezierSegment.Points.Add(new Point(ran.Next(minPath, maxPath), ran.Next(minPath, maxPath)));

				pFigure.Segments.Add(pBezierSegment);
				movePath.Figures.Add(pFigure);

				// Freeze the PathGeometry for performance benefits.
				movePath.Freeze();

				Path p = new Path();
				p.Data = movePath;
				p.Stroke = new SolidColorBrush(Colors.Red);
		

				double length = ran.Next(8, 45);


				DoubleAnimation da = SetupRotationAnimation(i, rotateName);
				DoubleAnimation da2 = SetupFadeAnimation(i, length, fadeName);

				// Create a DoubleAnimationUsingPath to move the
				// rectangle horizontally along the path by animating
				// its TranslateTransform.
				DoubleAnimationUsingPath translateXAnimation = new DoubleAnimationUsingPath();
				translateXAnimation.PathGeometry = movePath;
				translateXAnimation.Duration = TimeSpan.FromSeconds(length);

				translateXAnimation.Source = PathAnimationSource.X;

				Storyboard.SetTargetName(translateXAnimation, "AnimatedTranslateTransform" + i);
				Storyboard.SetTargetProperty(translateXAnimation,
						new PropertyPath(TranslateTransform.XProperty));

				DoubleAnimationUsingPath translateYAnimation = new DoubleAnimationUsingPath();
				//	translateYAnimation.RepeatBehavior = RepeatBehavior.Forever;
				translateYAnimation.PathGeometry = movePath;
				translateYAnimation.Duration = TimeSpan.FromSeconds(length);

				translateYAnimation.Source = PathAnimationSource.Y;

				Storyboard.SetTargetName(translateYAnimation, "AnimatedTranslateTransform" + i);
				Storyboard.SetTargetProperty(translateYAnimation,
						new PropertyPath(TranslateTransform.YProperty));

				// Create a Storyboard to contain and apply the animations.
				Storyboard spinSB = new Storyboard();
				spinSB.Children.Add(da);
				spinSB.Begin(this);

				// Create a Storyboard to contain and apply the animations.
				Storyboard fadeSB = new Storyboard();
				fadeSB.Duration = TimeSpan.FromSeconds(length);
				fadeSB.AutoReverse = true;
				fadeSB.RepeatBehavior = RepeatBehavior.Forever;
				fadeSB.Children.Add(da2);
				fadeSB.Begin(this);

				Storyboard pathAnimationStoryboard = new Storyboard();
				pathAnimationStoryboard.RepeatBehavior = RepeatBehavior.Forever;
				pathAnimationStoryboard.AutoReverse = true;
				//	pathAnimationStoryboard.Children.Add(da2);
				pathAnimationStoryboard.Children.Add(translateXAnimation);
				pathAnimationStoryboard.Children.Add(translateYAnimation);
				pathAnimationStoryboard.Begin(this);

			}
		
		}

		private static DoubleAnimation SetupRotationAnimation(int i, string rotateName) {

			DoubleAnimation da = new DoubleAnimation();
			double durationInSeconds = ran.Next(10, 70);
			da.Duration = TimeSpan.FromSeconds(durationInSeconds);
			//da.AutoReverse = true;
			da.RepeatBehavior = RepeatBehavior.Forever;
			double speed = ran.NextDouble();
			da.AccelerationRatio = speed;
			da.DecelerationRatio = 1 - speed;
			da.To = 360;
			//Storyboard.SetTarget(da, star);
			Storyboard.SetTargetName(da, rotateName);
			Storyboard.SetTargetProperty(da, new PropertyPath(RotateTransform.AngleProperty));
			return da;
		}

		private static DoubleAnimation SetupFadeAnimation(int i, double durationInSeconds, string fadeName) {
			DoubleAnimation da = new DoubleAnimation();
			da.Duration = TimeSpan.FromSeconds(durationInSeconds / 2);
			da.AutoReverse = true;
			da.RepeatBehavior = RepeatBehavior.Forever;
			double speed = ran.NextDouble();
			da.AccelerationRatio = speed;
			da.DecelerationRatio = 1 - speed;
			da.From = 0;
			da.To = 1;
			Storyboard.SetTargetName(da, fadeName);
			Storyboard.SetTargetProperty(da, new PropertyPath(FrameworkElement.OpacityProperty));
			return da;
		}
	}
}
