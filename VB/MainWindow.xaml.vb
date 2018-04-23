Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Windows

Namespace RichEditBindingConvertersWpf
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub reBindingSource_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			reBindingSource.LoadDocument("test.html")
		End Sub

		Private Sub tbBindingSource_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			tbBindingSource.Text = File.ReadAllText("test.html")
		End Sub
	End Class
End Namespace
