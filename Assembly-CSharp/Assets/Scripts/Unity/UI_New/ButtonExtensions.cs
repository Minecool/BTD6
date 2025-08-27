namespace Assets.Scripts.Unity.UI_New;

[Extension]
public static class ButtonExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public EventTriggerType type; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <AddEventTrigger>b__0(Entry trigger) { }

	}


	[Extension]
	public static void AddEventTrigger(Selectable btn, EventTriggerType type, UnityAction<BaseEventData> evt) { }

	[Extension]
	public static void RemoveEventTrigger(Selectable btn, EventTriggerType type, UnityAction<BaseEventData> evt) { }

}

