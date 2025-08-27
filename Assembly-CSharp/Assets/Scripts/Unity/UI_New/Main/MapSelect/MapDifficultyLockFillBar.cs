namespace Assets.Scripts.Unity.UI_New.Main.MapSelect;

public class MapDifficultyLockFillBar : MonoBehaviour
{
	private static readonly int ShowHash; //Field offset: 0x0
	[SerializeField]
	private Animator animator; //Field offset: 0x20
	[SerializeField]
	private Image fill; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI count; //Field offset: 0x30
	private bool isShowing; //Field offset: 0x38
	private bool isLocked; //Field offset: 0x39

	private static MapDifficultyLockFillBar() { }

	public MapDifficultyLockFillBar() { }

	public void Lock() { }

	public void Set(int completed, int required) { }

	private void Show(bool show) { }

	public void Unlock() { }

}

