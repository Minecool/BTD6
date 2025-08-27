namespace Assets.Scripts.Unity.Towers.Mutators;

public class ProjectileSizeTowerMutator : TowerMutator
{
	public float sizeModifier; //Field offset: 0xB0
	public string expSizeModifier; //Field offset: 0xB8
	public float assetSizeModifier; //Field offset: 0xC0
	public string expAssetSizeModifier; //Field offset: 0xC8
	public float lifespan; //Field offset: 0xD0
	public string expLifespan; //Field offset: 0xD8

	public virtual TowerMutatorModel Def
	{
		 get { } //Length: 358
	}

	public ProjectileSizeTowerMutator() { }

	public virtual TowerMutatorModel get_Def() { }

}

