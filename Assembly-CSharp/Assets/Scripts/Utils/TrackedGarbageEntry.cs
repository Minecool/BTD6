namespace Assets.Scripts.Utils;

internal class TrackedGarbageEntry
{
	public string name; //Field offset: 0x10
	public string group; //Field offset: 0x18
	public WeakReference target; //Field offset: 0x20

	public TrackedGarbageEntry(string name, object target, string group) { }

}

