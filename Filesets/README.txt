To debug, copy the 'For testing' xml AddIn file to %USERPROFILE%\Documents\Visual Studio 2010\Addins or it won't find it.

There is a way to get this in csharp if a build time utility written - 

Environment.GetFolderPath(Environment.SpecialFolder.Mydocuments) 