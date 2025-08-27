namespace Assets.Scripts.Utils;

public class ObjectCache
{
	internal class Id
	{
		public readonly string dataFolder; //Field offset: 0x10
		public readonly string fileName; //Field offset: 0x18

		public Id(string dataFolder, string fileName) { }

		public virtual string ToString() { }

	}

	public DateTime creationTime; //Field offset: 0x10
	public object deserializedObject; //Field offset: 0x18
	public bool isDownloading; //Field offset: 0x20
	public readonly Id id; //Field offset: 0x28

	public ObjectCache(string dataFolder, string fileName) { }

}

