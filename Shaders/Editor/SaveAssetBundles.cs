using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SaveAssetBundles : EditorWindow {

	[MenuItem("Window/Save AssetBundles")]
	// Use this for initialization
	public static void Open ()
	{
		BuildPipeline.BuildAssetBundles(@"Assets\Windows", BuildAssetBundleOptions.None,
			BuildTarget.StandaloneWindows64);
		BuildPipeline.BuildAssetBundles(@"Assets\Linux", BuildAssetBundleOptions.None,
			BuildTarget.StandaloneLinux64);
		BuildPipeline.BuildAssetBundles(@"Assets\Mac", BuildAssetBundleOptions.None,
			BuildTarget.StandaloneOSXIntel64);
		AssetDatabase.Refresh();
	}
}