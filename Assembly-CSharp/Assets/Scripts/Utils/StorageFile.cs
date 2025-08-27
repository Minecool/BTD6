namespace Assets.Scripts.Utils;

public class StorageFile
{
	public readonly string dataFolder; //Field offset: 0x10
	public readonly string fileName; //Field offset: 0x18
	public readonly Type dataType; //Field offset: 0x20

	public StorageFile(string dataFolder, int fileName, Type dataType) { }

	public StorageFile(string dataFolder, string fileName, Type dataType) { }

}

