namespace Assets.Scripts.Unity.UI_New.InGame;

public class RepositionTowerInput : CustomInput
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public RepositionTowerInput <>4__this; //Field offset: 0x10
		public Vector3 towPos; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <EnterInputMode>b__0(UnityDisplayNode img) { }

	}

	private AbilityToSimulation ability; //Field offset: 0x28
	private RepositionTowerCIData data; //Field offset: 0x30
	private UnityDisplayNode targetImage; //Field offset: 0x38
	private bool enterPlacement; //Field offset: 0x40
	private bool instaExit; //Field offset: 0x41

	public RepositionTowerInput() { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual string GetHelperMessage() { }

	public virtual void Init(AbilityToSimulation ability) { }

	private void TowerPlacementSuccess(Vector2 pos) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

