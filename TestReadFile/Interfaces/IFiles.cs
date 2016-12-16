using System;
namespace TestReadFile.Interfaces
{
	public interface IFiles
	{
//		void CreateDirectory(string path);
		string ReadTextFile(string path, string fileName);
		void WriteTextFile(string path, string filename, string stringToWrite);
		string RootDirectory();
	}
}
