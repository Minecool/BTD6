namespace Assets.Scripts.Models.Map;

[Implementation(typeof(RegenRemovable), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RegenRemovableModel : Model
{
	public bool isActive; //Field offset: 0x30
	public Vector3 position; //Field offset: 0x34
	public FormulaicCostModel costFormula; //Field offset: 0x40
	public ObjectId areaId; //Field offset: 0x48
	public bool setInactiveOnRemoved; //Field offset: 0x4C
	public string popupTextLocKey; //Field offset: 0x50
	public float costMultiplier; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnRemoved; //Field offset: 0x60

	public event Action OnRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public RegenRemovableModel(string name, bool isActive, Vector3 position, FormulaicCostModel costFormula, bool setInactiveOnRemoved, float costMultiplier, string popupTextLocKey) { }

	[CompilerGenerated]
	public void add_OnRemoved(Action value) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	[CompilerGenerated]
	public void remove_OnRemoved(Action value) { }

	public void Removed() { }

}

