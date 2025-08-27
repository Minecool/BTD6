namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class HeroXpPerRound : TowerBehavior
{
	public HeroXpPerRoundModel xpPerRoundModel; //Field offset: 0x68

	public HeroXpPerRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRoundComplete(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

