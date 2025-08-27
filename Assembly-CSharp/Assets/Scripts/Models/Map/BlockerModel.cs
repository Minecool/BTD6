namespace Assets.Scripts.Models.Map;

public class BlockerModel : Model
{
	public readonly ObjectId parentId; //Field offset: 0x30
	public readonly Circle circle; //Field offset: 0x34
	public bool isDisabled; //Field offset: 0x44

	public BlockerModel(string name, ObjectId parentId, Circle circle, bool isDisabled) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

