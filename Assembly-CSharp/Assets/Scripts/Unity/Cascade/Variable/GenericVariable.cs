namespace Assets.Scripts.Unity.Cascade.Variable;

public interface GenericVariable
{

	public GenericCascadingExpression Expression
	{
		 get { } //Length: 0
	}

	public Cache<GenericVariable[]> Mods
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public void AttatchToCascadeItem(CascadingItem prentable) { }

	public GenericCascadingExpression get_Expression() { }

	public Cache<GenericVariable[]> get_Mods() { }

	public string get_Name() { }

	public void ReadyEditView() { }

	public void RemoveFromCascadeItem(CascadingItem prentable) { }

}

