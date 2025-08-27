namespace Assets.Scripts.Unity.Map.Triggers;

public class ScrollTextureChangeAction : MapUnityAction
{
	public List<ScrollTextureBase> scrollTextures; //Field offset: 0x28
	public bool enableScrollTexture; //Field offset: 0x30
	public bool disableScrollTexture; //Field offset: 0x31
	public bool applyMultiplier; //Field offset: 0x32
	public bool removeMultiplier; //Field offset: 0x33
	public float scrollSpeedMul; //Field offset: 0x34
	public bool flipUVX; //Field offset: 0x38
	public bool flipUVY; //Field offset: 0x39
	private bool actionPerformed; //Field offset: 0x3A
	private List<Boolean> orgEnableStates; //Field offset: 0x40

	public ScrollTextureChangeAction() { }

	public virtual void GetOriginalState() { }

	public virtual void PerformAction() { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

}

