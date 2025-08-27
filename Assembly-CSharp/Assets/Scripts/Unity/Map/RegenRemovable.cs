namespace Assets.Scripts.Unity.Map;

public class RegenRemovable : MonoBehaviour
{
	private RegenRemovableModel def; //Field offset: 0x20
	public bool isActive; //Field offset: 0x28
	public GameObject regenRemovableObject; //Field offset: 0x30
	public FormulaicCost costFormula; //Field offset: 0x38
	public bool setInactiveOnRemoved; //Field offset: 0x40
	public string popupTextLocKey; //Field offset: 0x48

	public RegenRemovableModel Def
	{
		 get { } //Length: 460
	}

	public RegenRemovable() { }

	public RegenRemovableModel get_Def() { }

	private Vector3 GetCenterPoint() { }

}

