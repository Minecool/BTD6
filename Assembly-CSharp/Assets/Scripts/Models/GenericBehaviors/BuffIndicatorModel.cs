namespace Assets.Scripts.Models.GenericBehaviors;

[Implementation(typeof(BuffIndicator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BuffIndicatorModel : TowerBehaviorModel
{
	public string buffName; //Field offset: 0x30
	public string iconName; //Field offset: 0x38
	public bool stackable; //Field offset: 0x40
	public int maxStackSize; //Field offset: 0x44
	public bool globalRange; //Field offset: 0x48
	public bool onlyShowBuffIfMutated; //Field offset: 0x49
	public bool dontShowX; //Field offset: 0x4A
	private string _fullName; //Field offset: 0x50

	public string FullName
	{
		 get { } //Length: 44
	}

	public BuffIndicatorModel(string id, string buffName, string iconName, bool globalRange = false, int maxStackSize = 0, bool onlyShowBuffIfMutated = false, bool dontShowX = false) { }

	public virtual Model Clone() { }

	public string get_FullName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void SetBuffName(string newName) { }

	public void SetIconName(string newName) { }

}

