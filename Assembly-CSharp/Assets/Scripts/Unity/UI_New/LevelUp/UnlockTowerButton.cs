namespace Assets.Scripts.Unity.UI_New.LevelUp;

internal class UnlockTowerButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ReturnCallback towerSelectedCallback; //Field offset: 0x10
		public UnlockTowerButton <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Init>b__0() { }

	}

	public Image towerImage; //Field offset: 0x20
	public GameObject selectedEffect; //Field offset: 0x28
	public Animator animator; //Field offset: 0x30
	public string towerId; //Field offset: 0x38
	private ReturnCallback towerSelectedCallback; //Field offset: 0x40
	private Button button; //Field offset: 0x48

	public UnlockTowerButton() { }

	public void Deselected() { }

	public void Init(string towerId, ReturnCallback towerSelectedCallback) { }

	public void LockTower() { }

	public void Selected() { }

	public void UnlockTower() { }

}

