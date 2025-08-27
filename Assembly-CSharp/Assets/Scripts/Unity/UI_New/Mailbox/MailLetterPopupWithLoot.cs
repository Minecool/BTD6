namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class MailLetterPopupWithLoot : MailLetterPopup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BaseLoot, Boolean> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SetLoot>b__2_0(BaseLoot x) { }

	}

	[SerializeField]
	private LootPanel lootPanel; //Field offset: 0x138

	public MailLetterPopupWithLoot() { }

	protected virtual void Awake() { }

	public void SetLoot(LootSet displayLoot) { }

}

