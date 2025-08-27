namespace Assets.Scripts.RichPresence;

public class RichPresenceManager
{
	[CompilerGenerated]
	private sealed class <>c__4
	{
		public static readonly <>c__4<T> <>9; //Field offset: 0x0
		public static Func<IRichPresence, Boolean> <>9__4_0; //Field offset: 0x0

		private static <>c__4`1() { }

		public <>c__4`1() { }

		internal bool <InstallProvider>b__4_0(IRichPresence x) { }

	}

	private static readonly List<IRichPresence> richPresenceProviders; //Field offset: 0x0

	private static RichPresenceManager() { }

	public RichPresenceManager() { }

	public static void ForEachProvider(Action<IRichPresence> action) { }

	public static void Initialize() { }

	private static void InstallProvider() { }

	public static void Refresh() { }

}

