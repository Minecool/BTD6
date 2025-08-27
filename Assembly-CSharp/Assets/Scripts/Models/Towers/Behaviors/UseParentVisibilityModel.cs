namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(UseParentVisibility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class UseParentVisibilityModel : TowerBehaviorModel
{
	internal class VisibilityMutator : BehaviorMutator
	{

		public VisibilityMutator(string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "UseParentVisibility"; //Field offset: 0x0
	private VisibilityMutator mutator; //Field offset: 0x30

	public VisibilityMutator Mutator
	{
		 get { } //Length: 220
	}

	public UseParentVisibilityModel(string name) { }

	public virtual Model Clone() { }

	public VisibilityMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

