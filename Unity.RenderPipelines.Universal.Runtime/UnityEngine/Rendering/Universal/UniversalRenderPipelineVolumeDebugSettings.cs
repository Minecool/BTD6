namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineVolumeDebugSettings : VolumeDebugSettings<UniversalAdditionalCameraData>
{

	public virtual LayerMask selectedCameraLayerMask
	{
		 get { } //Length: 171
	}

	public virtual Vector3 selectedCameraPosition
	{
		 get { } //Length: 222
	}

	public virtual VolumeStack selectedCameraVolumeStack
	{
		 get { } //Length: 271
	}

	public virtual Type targetRenderPipeline
	{
		 get { } //Length: 89
	}

	public UniversalRenderPipelineVolumeDebugSettings() { }

	public virtual LayerMask get_selectedCameraLayerMask() { }

	public virtual Vector3 get_selectedCameraPosition() { }

	public virtual VolumeStack get_selectedCameraVolumeStack() { }

	public virtual Type get_targetRenderPipeline() { }

}

