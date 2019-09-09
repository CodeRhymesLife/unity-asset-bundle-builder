using UnityEditor;

/// <summary>
/// Creates an asset bundle for model.blend
/// </summary>
public class CreateAssetBundle {

	[MenuItem("Build/Build Asset Bundle")]
	static void Build()
	{
        // Create an asset bundle 
        BuildPipeline.BuildAssetBundles("Assets/AssetBundles/WindowsStandalone", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        BuildPipeline.BuildAssetBundles("Assets/AssetBundles/WindowsStore", BuildAssetBundleOptions.None, BuildTarget.WSAPlayer);
		BuildPipeline.BuildAssetBundles("Assets/AssetBundles/Android", BuildAssetBundleOptions.None, BuildTarget.Android);
	}
}
