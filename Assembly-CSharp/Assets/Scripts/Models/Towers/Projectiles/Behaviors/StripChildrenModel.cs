namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(StripChildren), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class StripChildrenModel : ProjectileBehaviorWithOverlayModel
{
	internal class StripChildrenMutator : BehaviorMutator
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public BloonModel bloonModel; //Field offset: 0x10

			public <>c__DisplayClass2_0() { }

			internal bool <Mutate>b__0(Model b) { }

		}

		public StripChildrenModel stripChildrenModel; //Field offset: 0x70
		public DestroyOnDegradeModel destroyOnDegradeModel; //Field offset: 0x78

		public StripChildrenMutator(string mutationId, StripChildrenModel stripChildrenModel, DestroyOnDegradeModel destroyOnDegradeModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private StripChildrenMutator mutator; //Field offset: 0x40
	private DestroyOnDegradeModel destroyOnDegradeModel; //Field offset: 0x48

	public StripChildrenMutator Mutator
	{
		 get { } //Length: 248
	}

	public StripChildrenModel(string name, string overlayType) { }

	public virtual Model Clone() { }

	public StripChildrenMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

