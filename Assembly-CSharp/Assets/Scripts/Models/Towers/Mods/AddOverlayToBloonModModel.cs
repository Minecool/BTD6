namespace Assets.Scripts.Models.Towers.Mods;

public class AddOverlayToBloonModModel : MutatorModModel
{
	public string overlayType; //Field offset: 0x30
	public bool excludeMoabs; //Field offset: 0x38

	public AddOverlayToBloonModModel(string name, string overlayType, bool excludeMoabs) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

