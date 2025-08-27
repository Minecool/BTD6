namespace Assets.Scripts.Utils;

public static class GarbageTracker
{
	public const string DefaultKey = "__Default_Key"; //Field offset: 0x0
	private static List<TrackedGarbageEntry> allTracked; //Field offset: 0x0
	private static Dictionary<Object, List`1<TrackedGarbageEntry>> tracked; //Field offset: 0x8

	private static GarbageTracker() { }

	public static List<Object> GetAlive(object key) { }

	private static void LogEntry(TrackedGarbageEntry entry) { }

	public static void ReportAlive(bool fullList = false) { }

	public static void ReportAlive(object key, bool fullList = false) { }

	public static void ReportAllTracked(bool fullList = false) { }

	public static void ReportDestroyed(bool fullList = false) { }

	public static void ReportDestroyed(object key, bool fullList = false) { }

	public static void ReportDuplicateEntries(bool fullList = false) { }

	public static void ReportDuplicateEntries(object key, bool fullList = false) { }

	public static void ReportTracked(object key, bool fullList = false) { }

	public static void Track(object target, string name) { }

	public static void Track(object key, object target, string name) { }

	private static void ValidateKey(object key) { }

}

