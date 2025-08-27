namespace Assets.Scripts.Unity.UI_New.Rewards;

public abstract class BaseRewardPanel : MonoBehaviour
{
	public Animator panelAnimator; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnClosed; //Field offset: 0x28
	[HideInInspector]
	public bool interactable; //Field offset: 0x30

	public event Action OnClosed
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected BaseRewardPanel() { }

	[CompilerGenerated]
	public void add_OnClosed(Action value) { }

	public abstract void Bind(BaseLoot loot) { }

	public void Close() { }

	[CompilerGenerated]
	public void remove_OnClosed(Action value) { }

	public override void Update() { }

}

