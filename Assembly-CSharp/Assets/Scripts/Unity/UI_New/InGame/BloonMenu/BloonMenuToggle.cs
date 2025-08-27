namespace Assets.Scripts.Unity.UI_New.InGame.BloonMenu;

public class BloonMenuToggle : MonoBehaviour
{
	private const int animationStateClosed = 0; //Field offset: 0x0
	private const int animationStateOpen = 1; //Field offset: 0x0
	public Animator bloonsButtonAnimator; //Field offset: 0x20
	private readonly string visibleStateLabel; //Field offset: 0x28

	public BloonMenuToggle() { }

	public void ToggleBloonMenu() { }

	private void Update() { }

}

