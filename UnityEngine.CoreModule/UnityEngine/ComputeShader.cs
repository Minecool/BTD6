namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public sealed class ComputeShader : object
{

	[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = True)]
	public void DisableKeyword(string keyword) { }

	[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = True)]
	public void EnableKeyword(string keyword) { }

	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	public int FindKernel(string name) { }

	public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = True)]
	private void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = True)]
	public void SetInt(int nameID, int val) { }

}

