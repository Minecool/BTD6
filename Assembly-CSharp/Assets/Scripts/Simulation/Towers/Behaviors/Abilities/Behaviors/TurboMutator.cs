namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class TurboMutator : BehaviorMutator
{
	private readonly float turboMultiplier; //Field offset: 0x70
	private readonly PrefabReference projectileDisplay; //Field offset: 0x78
	private readonly int extraDamage; //Field offset: 0x80
	private readonly float projectileRadiusScaleBonus; //Field offset: 0x84

	public TurboMutator(float turboMultiplier, PrefabReference projectileDisplay, int extraDamage, float projectileRadiusScaleBonus, string mutatorId) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

