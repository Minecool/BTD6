namespace System.ComponentModel;

[DefaultMember("Item")]
public class ComponentCollection : ReadOnlyCollectionBase
{

	public override IComponent Item
	{
		 get { } //Length: 675
	}

	public override IComponent get_Item(string name) { }

}

