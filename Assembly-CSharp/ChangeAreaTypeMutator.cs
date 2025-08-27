//Type is in global namespace

internal class ChangeAreaTypeMutator : BehaviorMutator
{
	public AreaType areaType; //Field offset: 0x70

	public ChangeAreaTypeMutator(AreaType areaType) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

