namespace NinjaKiwi.Common;

public class LanguageResource
{
	[LocFileReference]
	public string locsLocation; //Field offset: 0x10
	[FontFolderReference]
	public string fontsLocation; //Field offset: 0x18

	public LanguageResource() { }

}

