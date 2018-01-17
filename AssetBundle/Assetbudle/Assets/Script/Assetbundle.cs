using UnityEngine;
using System.Collections;
using UnityEditor  ;

public class Assetbundle : MonoBehaviour {
	[MenuItem ("Assets/Get AssetBundle names")]
	static void GetAssetBundleNames(){
		var names = AssetDatabase.GetAllAssetBundleNames ();
		foreach (var  name in names) {
			Debug.Log ("AssetBundle:"+name );

		}
	
	}
	[MenuItem ("AssetBundle/Buile AssetBundles Main")]
	static  void BuildAssets(){
		BuildPipeline.BuildAssetBundles (AssetbundleConfig.ASSETBUNDLE_PATH.Substring (AssetbundleConfig.PROJECT_PATH.Length),
			BuildAssetBundleOptions.UncompressedAssetBundle, BuildTarget.StandaloneWindows64);

	}


	[MenuItem ( "AssetBundle/Buile AssetBundle All")]
	static void BuileAssetBundleAll(){
//		Caching.ClearCache ();
//		string Paht =Application .dataPath +"/StreamingAssets/ALL.assetbundle";
//		Object[] selectedAsset = Selection.GetFiltered (typeof(Object), SelectionMode.DeepAssets);
//		foreach (Object  obj in selectedAsset) {
//			Debug.Log ("create Assetbundle name :" + obj);
//		}
//		if (BuildPipeline.BuildAssetBundle (null, selectedAsset, Paht, BuildAssetBundleOptions.CollectDependencies, BuildTarget.StandaloneWindows64)) {
//			AssetDatabase.Refresh ();
//		}
//	
	}
	[MenuItem ("Test/Code")]
	static void testcode(){
//		Debug.Log (Application.persistentDataPath  );
//		const string outputDir ="Assets/StreamingAssets";
//		string plat = EditorUserBuildSettings.activeBuildTarget.ToString ();
//		Debug.Log (plat );
		BuildPipeline.BuildAssetBundles (AssetbundleConfig.ASSETBUNDLE_PATH.Substring (AssetbundleConfig.PROJECT_PATH.Length),
			BuildAssetBundleOptions.UncompressedAssetBundle, BuildTarget.StandaloneWindows64);
	}
	

}
