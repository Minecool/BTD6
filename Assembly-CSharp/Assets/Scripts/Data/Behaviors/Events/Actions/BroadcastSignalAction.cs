namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class BroadcastSignalAction : EntityAction
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <get_Model>b__6_0(string s) { }

	}

	public String[] signalIds; //Field offset: 0x28
	public string testSingalIsCommerSeperated; //Field offset: 0x30
	public bool isRepeating; //Field offset: 0x38
	public int durationSeconds; //Field offset: 0x3C
	public int iterations; //Field offset: 0x40

	public virtual Model Model
	{
		 get { } //Length: 518
	}

	public BroadcastSignalAction() { }

	public virtual Model get_Model() { }

}

