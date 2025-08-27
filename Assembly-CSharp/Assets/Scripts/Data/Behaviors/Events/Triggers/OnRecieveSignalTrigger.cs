namespace Assets.Scripts.Data.Behaviors.Events.Triggers;

public class OnRecieveSignalTrigger : EntityTrigger
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
	public bool requireAllSignals; //Field offset: 0x38
	public int resetWaitAfterSeconds; //Field offset: 0x3C
	public bool allowDuplicateFrameTriggers; //Field offset: 0x40

	public virtual Model Model
	{
		 get { } //Length: 519
	}

	public OnRecieveSignalTrigger() { }

	public virtual Model get_Model() { }

}

