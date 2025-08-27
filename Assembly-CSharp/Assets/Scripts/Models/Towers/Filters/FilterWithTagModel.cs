namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterWithTag), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterWithTagModel : FilterModel
{
	public bool moabTag; //Field offset: 0x30
	public bool camoTag; //Field offset: 0x31
	public bool growTag; //Field offset: 0x32
	public bool fortifiedTag; //Field offset: 0x33
	public string tag; //Field offset: 0x38
	public bool inclusive; //Field offset: 0x40
	public bool hasMoabTag; //Field offset: 0x41

	public FilterWithTagModel(string name, string tag, bool inclusive) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

