using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace PixelSmith {

	public partial class AboutView : Window {

		public AboutView() {
			InitializeComponent();
			this.AddHandler(Hyperlink.RequestNavigateEvent, new RoutedEventHandler(this.HandleRequestNavigate), false);
			//versionText.Text = VersionHelper.GetVersionNumber();
			versionRun.Text = "v1.1";
		}
		
		private void HandleRequestNavigate(object sender, RoutedEventArgs e) {
			Hyperlink hl = (e.OriginalSource as Hyperlink);
			if (hl != null)
			{
				string navigateUri = hl.NavigateUri.ToString();
				Process.Start(new ProcessStartInfo(navigateUri));
				e.Handled = true;
			}
		}

		private void OK_Click(object sender, RoutedEventArgs e) {
			//  Settings.Default.Save();
			Close();
		}

		private void Cancel_Click(object sender, RoutedEventArgs e) {
			// Settings.Default.Reload();
			Close();
		}

		protected override void OnActivated(EventArgs e) {
			base.OnActivated(e);
			Mouse.Capture(this, CaptureMode.SubTree);
		}

		protected override void OnDeactivated(EventArgs e) {
			base.OnDeactivated(e);
			Mouse.Capture(null);
		}

		protected override void OnMouseMove(MouseEventArgs e) {
			//Mouse.Capture(null);
			base.OnMouseMove(e);
		}

		protected override void OnKeyUp(System.Windows.Input.KeyEventArgs e) {
			if (e.Key == Key.Escape)
			{
				// hitting "escape" is the new cancel button
				//    Settings.Default.Reload();
				Close();
			}
			else
			{
				base.OnKeyUp(e);
			}
		}
	}
}