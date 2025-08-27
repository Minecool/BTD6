namespace Assets.Scripts.Simulation.Objects;

public interface ISelectable : ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{

	public void Hilight() { }

	public void Selected() { }

	public void UnHighlight() { }

	public void UnSelected() { }

}

