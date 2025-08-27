namespace Unity.Jobs;

public class EarlyInitHelpers
{
	internal sealed class EarlyInitFunction : MulticastDelegate
	{

		public EarlyInitFunction(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	private static List<EarlyInitFunction> s_PendingDelegates; //Field offset: 0x0

	private static EarlyInitHelpers() { }

	public static void FlushEarlyInits() { }

	public static void JobReflectionDataCreationFailed(Exception ex) { }

}

