namespace NinjaKiwi.Common;

public class DlcFileModel
{
	public string Key; //Field offset: 0x10
	public string LastModified; //Field offset: 0x18
	public string ETag; //Field offset: 0x20
	public int Size; //Field offset: 0x28
	public string localPath; //Field offset: 0x30
	public string platform; //Field offset: 0x38
	public string url; //Field offset: 0x40

	public DlcFileModel() { }

}

