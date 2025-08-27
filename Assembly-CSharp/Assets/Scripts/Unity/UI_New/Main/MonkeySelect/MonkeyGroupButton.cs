namespace Assets.Scripts.Unity.UI_New.Main.MonkeySelect;

public class MonkeyGroupButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public MonkeySelectMenu monkeySelectMenu; //Field offset: 0x10
		public TowerSet towerSet; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <Initialise>b__0() { }

	}

	public string groupName; //Field offset: 0x20
	private MonkeySelectMenu monkeySelectMenu; //Field offset: 0x28
	public Image icon; //Field offset: 0x30
	public Material standardMaterial; //Field offset: 0x38
	public Material lockedMaterial; //Field offset: 0x40
	public PipEventChecker paragonPip; //Field offset: 0x48
	public Button button; //Field offset: 0x50
	public GameObject highlight; //Field offset: 0x58

	public MonkeyGroupButton() { }

	public void Initialise(MonkeySelectMenu monkeySelectMenu) { }

	public void SetLocked(bool locked) { }

	public void SetSelected(bool isSelected) { }

}

