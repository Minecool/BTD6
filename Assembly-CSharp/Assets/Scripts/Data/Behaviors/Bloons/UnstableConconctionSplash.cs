namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "UnstableConconctionSplash", menuName = "BTD6/Behaviors/Bloons/UnstableConconctionSplash")]
public class UnstableConconctionSplash : EmitOnPop
{
	public float moabBloonDmg; //Field offset: 0x48
	public float bfbBloonDmg; //Field offset: 0x4C
	public float zomgBloonDmg; //Field offset: 0x50
	public float otherMoabBloonDmg; //Field offset: 0x54
	public float moabMoabDmg; //Field offset: 0x58
	public float bfbMoabDmg; //Field offset: 0x5C
	public float zomgMoabDmg; //Field offset: 0x60
	public float ddtMoabDmg; //Field offset: 0x64
	public float badMoabDmg; //Field offset: 0x68
	public float bossMoabDmg; //Field offset: 0x6C
	public float otherMoabMoabDmg; //Field offset: 0x70

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 741
	}

	public UnstableConconctionSplash() { }

	public virtual BloonBehaviorModel get_Def() { }

}

