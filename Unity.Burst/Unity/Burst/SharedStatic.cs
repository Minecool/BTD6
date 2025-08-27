namespace Unity.Burst;

internal static class SharedStatic
{
	public class PreserveAttribute : Attribute
	{

		public PreserveAttribute() { }

	}


	[Preserve]
	public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

}

