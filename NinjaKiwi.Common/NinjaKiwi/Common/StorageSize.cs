namespace NinjaKiwi.Common;

public struct StorageSize
{
	public readonly SizeUnit sizeUnit; //Field offset: 0x0
	public readonly int value; //Field offset: 0x4

	public long TotalBytes
	{
		 get { } //Length: 9
	}

	public StorageSize(SizeUnit sizeUnit, int value) { }

	public long get_TotalBytes() { }

}

