using System;
using TestReadFile.ViewModels;
using Xamarin.Forms;

namespace TestReadFile.Pages
{
	public class PageMain : ContentPage
	{
		public PageMain()
		{

			this.BindingContext = new PageMainViewModel();

			Label labelLocalStorageName = new Label { };
			labelLocalStorageName.SetBinding(Label.TextProperty,new Binding("LocalStorageName", stringFormat:"Local storage name: {0}"));
			Label labelLocalStoragePath = new Label { };
			labelLocalStoragePath.SetBinding(Label.TextProperty, new Binding("LocalStoragePath", stringFormat:"Local storage path: {0}"));
			Label labelRoamingStorageName = new Label { };
			labelRoamingStorageName.SetBinding(Label.TextProperty, new Binding("RoamingStorageName", stringFormat: "Roaming storage name: {0}"));
			Label labelRoamingStoragePath = new Label { };
			labelRoamingStoragePath.SetBinding(Label.TextProperty, new Binding("RoamingStoragePath", stringFormat: "Roaming storage path: {0}"));

			Label labelRootDirectory = new Label { };
			labelRootDirectory.SetBinding(Label.TextProperty, new Binding("RootDirectory", stringFormat:"{0} is the RootDirectory where file is written"));

			Entry entryDirectoryName = new Entry() {Placeholder = "Directory..." };
			entryDirectoryName.SetBinding(Entry.TextProperty, new Binding("DirectoryName"));
			Entry entryFileName = new Entry() { Placeholder = "Filename..."};
			entryFileName.SetBinding(Entry.TextProperty,new Binding("Filename"));
			Entry entryTextToWriteString = new Entry {Placeholder="Text to write" };
			entryTextToWriteString.SetBinding(Entry.TextProperty, new Binding("StringToWrite"));
			Entry entryTextToWriteNumeric = new Entry { Placeholder = "Text to write numeric", Keyboard = Keyboard.Numeric };
			entryTextToWriteNumeric.SetBinding(Entry.TextProperty, new Binding("StringToWriteNumeric"));


			Button buttonWrite = new Button { Text = "Write"};
			buttonWrite.SetBinding(Button.CommandProperty, new Binding("WriteFileCommand"));

			Button buttonRead = new Button { Text = "Read"};
			buttonRead.SetBinding(Button.CommandProperty, new Binding("ReadFileCommand"));

			Label labelStringRead = new Label { };
			labelStringRead.SetBinding(Label.TextProperty, new Binding( "StringRead", stringFormat:"Read {0}"));
			StackLayout sl = new StackLayout() {Children = {
					labelLocalStorageName,
					labelLocalStoragePath,
					labelRoamingStorageName,
					labelRoamingStoragePath,
					labelRootDirectory,
					entryDirectoryName,
					entryFileName,
					entryTextToWriteString,
					entryTextToWriteNumeric,
					buttonWrite,
					buttonRead,
					labelStringRead
				} };
			ScrollView sv = new ScrollView { Content = sl  };
			Content = new StackLayout
			{
				Children = {sv}
			};
		}
	}
}

