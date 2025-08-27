namespace Assets.Scripts.Models.Powers.Mods;

public class PreGamePrepModModel : MutatorModModel
{
	public float distFromEdgeOfMap; //Field offset: 0x30
	[ExtendedDrawer]
	public ProjectileModel projectileModel; //Field offset: 0x38

	public PreGamePrepModModel(string name, float distFromEdgeOfMap, ProjectileModel projMod) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

