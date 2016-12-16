using System;
using Java.IO;
using TestReadFile.Droid;
using TestReadFile.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(FilesImplementation))]
namespace TestReadFile.Droid
{
	public class FilesImplementation : IFiles
	{
		public FilesImplementation()
		{
		}


		public string ReadTextFile(string path, string fileName)
		{
			//throw new NotImplementedException();
			using (System.IO.StreamReader sr = new System.IO.StreamReader(System.IO.Path.Combine(path, fileName))){
				string line = sr.ReadToEnd();
				sr.Close();
				return line;
			}
		}

		private string creaFileName(string directory, string fileName) { 
			string path = RootDirectory();
			string file = System.IO.Path.Combine(path, fileName);
			return file;
		}

		public void WriteTextFile(string path, string fileName, string stringToWrite)
		{
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(path, fileName),false))
			{
				sw.WriteLine(stringToWrite);
				sw.Close();
			}
		}

		public string RootDirectory()
		{
			File path = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDcim);
			return path.AbsolutePath;
		}
	}
}
