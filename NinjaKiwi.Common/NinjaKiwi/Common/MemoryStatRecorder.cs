namespace NinjaKiwi.Common;

public class MemoryStatRecorder : MonoBehaviour
{
	internal enum MemoryUsageStat
	{
		TotalUsedMemory = 0,
		TotalReservedMemory = 1,
		GCUsedMemory = 2,
		GCReservedMemory = 3,
		GfxUsedMemory = 4,
		GfxReservedMemory = 5,
		AudioUsedMemory = 6,
		AudioReservedMemory = 7,
		VideoUsedMemory = 8,
		VideoReservedMemory = 9,
		ProfilerUsedMemory = 10,
		ProfilerReservedMemory = 11,
		SystemUsedMemory = 12,
	}

	private class StatRecorder
	{
		public ProfilerRecorder recorder; //Field offset: 0x10
		public string statAsString; //Field offset: 0x18
		public long highTide; //Field offset: 0x20

		public StatRecorder(string statName) { }

	}

	private Dictionary<MemoryUsageStat, StatRecorder> stats; //Field offset: 0x20

	public MemoryStatRecorder() { }

	public void AddRecorder(MemoryUsageStat stat) { }

	private string FormatByteCount(long byteCount) { }

	private string GetStatName(MemoryUsageStat stat) { }

	public string GetUsageAsString(MemoryUsageStat stat) { }

	private void OnDestroy() { }

	private void Update() { }

}

