namespace Assets.Scripts.Unity.UI_New.Store;

public class LootPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public LootPanel <>4__this; //Field offset: 0x10
		public int stateId; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_1
	{
		public BaseLoot lootItem; //Field offset: 0x10
		public <>c__DisplayClass4_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass4_1() { }

		internal void <Bind>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public LootPanel <>4__this; //Field offset: 0x10
		public int stateId; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_1
	{
		public BaseLoot origItem; //Field offset: 0x10
		public BaseLoot lootItem; //Field offset: 0x18
		public <>c__DisplayClass5_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass5_1() { }

		internal void <Bind>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	public LootThemeType theme; //Field offset: 0x20
	public Transform lootContainer; //Field offset: 0x28
	private int stateId; //Field offset: 0x30
	private LootSet lootSet; //Field offset: 0x38

	public LootPanel() { }

	public void Bind(LootSet lootSet) { }

	public void Bind(LootSet origLootSet, LootSet lootSet) { }

	public void Clear() { }

}

