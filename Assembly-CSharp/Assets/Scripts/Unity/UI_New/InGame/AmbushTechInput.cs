namespace Assets.Scripts.Unity.UI_New.InGame;

public class AmbushTechInput : CustomInput
{
	private AmbushTechCIData data; //Field offset: 0x28
	private UnityDisplayNode targetImage; //Field offset: 0x30
	private AbilityToSimulation ability; //Field offset: 0x38

	public AmbushTechInput() { }

	[CompilerGenerated]
	private void <EnterInputMode>b__5_0(UnityDisplayNode img) { }

	public virtual void CursorUp(Vector2 cursorPosWorld, bool isCursorInWorld) { }

	public virtual void EnterInputMode() { }

	public virtual void ExitInputMode() { }

	public virtual string GetHelperMessage() { }

	public virtual string GetId() { }

	public virtual void Init(AbilityToSimulation ability) { }

	public virtual void Update(Vector3 cursorPosUnityWorld, Vector2 cursorPosWorld, bool isCursorActive) { }

}

