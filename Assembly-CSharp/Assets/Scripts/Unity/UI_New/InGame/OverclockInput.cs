namespace Assets.Scripts.Unity.UI_New.InGame;

public class OverclockInput : CustomInput
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public TowerToSimulation bridgeTower; //Field offset: 0x10
		public OverclockInput <>4__this; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <EnterInputMode>b__0(UnityDisplayNode img) { }

	}

	private AbilityToSimulation ability; //Field offset: 0x28
	private OverclockCIData data; //Field offset: 0x30
	private Dictionary<TowerToSimulation, UnityDisplayNode> targetImages; //Field offset: 0x38

	public OverclockInput() { }

	public virtual void CursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual string GetHelperMessage() { }

	public virtual void Init(AbilityToSimulation ability) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

