namespace Assets.Scripts.Unity.Map;

public abstract class ScrollTextureBase : MonoBehaviour
{
	private List<Single> rateMultipliers; //Field offset: 0x20

	protected abstract float BaseRate
	{
		 get { } //Length: 0
	}

	protected ScrollTextureBase() { }

	public void AddRateMultiplier(float f) { }

	protected void CalcFinalRate() { }

	public abstract void FlipX(bool val) { }

	public abstract void FlipY(bool val) { }

	protected abstract float get_BaseRate() { }

	protected abstract void OnRateUpdated(float rate) { }

	public void RemoveRateMultiplier(float f) { }

}

