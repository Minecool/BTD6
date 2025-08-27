namespace Assets.Scripts.Unity.UI_New.InGame;

public class DoorGunnerInput : CustomInput
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public TowerToSimulation bridgeTower; //Field offset: 0x10
		public DoorGunnerInput <>4__this; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal void <EnterInputMode>b__0(UnityDisplayNode img) { }

	}

	private AbilityToSimulation ability; //Field offset: 0x28
	private DoorGunnerCIData data; //Field offset: 0x30
	private Dictionary<TowerToSimulation, UnityDisplayNode> targetImages; //Field offset: 0x38

	public DoorGunnerInput() { }

	public void CheckForSelectedTower(Vector2 cursorPosWorld) { }

	private void CleanUpImages() { }

	public virtual void CursorDown(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual string GetHelperMessage() { }

	public virtual void Init(AbilityToSimulation ability) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

