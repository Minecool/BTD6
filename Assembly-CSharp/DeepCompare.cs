//Type is in global namespace

public class DeepCompare
{
	private BindingFlags bindFlags; //Field offset: 0x10
	private HashSet<Object> processedObjectsA; //Field offset: 0x18
	private HashSet<Object> processedObjectsB; //Field offset: 0x20

	public DeepCompare() { }

	public bool Compare(object a, object b) { }

	public int GetCheckCount() { }

	private bool NullCheck(object a, object b) { }

}

