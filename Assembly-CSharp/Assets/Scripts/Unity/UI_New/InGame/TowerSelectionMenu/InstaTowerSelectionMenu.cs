namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class InstaTowerSelectionMenu : MonoBehaviour
{
	private const int animationStateClosed = 0; //Field offset: 0x0
	private const int animationStateOpenRight = 2; //Field offset: 0x0
	private const int animationStateOpenHardRight = 3; //Field offset: 0x0
	private readonly string visibleStateLabel; //Field offset: 0x20
	private bool openTest; //Field offset: 0x28
	public Animator animator; //Field offset: 0x30
	public Animator[] additionalInfoAnimatiors; //Field offset: 0x38
	public Animator roundMenuAnimator; //Field offset: 0x40

	public InstaTowerSelectionMenu() { }

	public void Close() { }

	public void Open() { }

	private void Update() { }

}

