using UnityEngine;
using System.Collections;
//using System .Collections .Generic ;
public class LoadAssetbundle : MonoBehaviour {
//	private static AssetBundleManifest manifest = null;
//	private static Dictionary<string ,AssetBundle  > abDic = new Dictionary<string, AssetBundle> ();
//	public static AssetBundle  LoadAB(string abPath){
//		if (abDic.ContainsKey (abPath)) {
//			return abDic [abPath];
//		}
//		if (manifest == null) {
//			AssetBundle manifestBundle = AssetBundle.LoadFromFile (AssetbundleConfig .ASSETBUNDLE_PATH +AssetbundleConfig .ASSETBUNDLE_FILENAM );
//			manifest = (AssetBundleManifest)manifestBundle.LoadAsset ("AssetBundleManifest");
//		}
//	
//	
//		return null;
//	}
	//不同平台下StreamingAssets的路径是不同的，这里需要注意一下。


	public static  string PathURL{
		get {
			string STR;
			#if UNITY_EDITOR 
			STR = "file://" + Application.dataPath + "/StreamingAssets/";
			#elif UNITY_ANDROID
			STR ="JAR:FILE://"+Application.dataPath+"!/assets";
			#elif UNITY_IPHONE
			STR =Application.dataPath+"/Raw/";
			#else
			STR =string.Empty;
			#endif
			return STR;
		}

		}

		
	void  OnGUI(){
		if (GUILayout.Button ( "Main Assetbundle")) {
			StartCoroutine(LoadMainGameObject(PathURL + "Cube.assetbundle"));
			StartCoroutine(LoadMainGameObject(PathURL +  "Sphere.assetbundle"));
			}
	
		if(GUILayout.Button("ALL Assetbundle"))
		{
			StartCoroutine(LoadAllGameObject(PathURL + "ALL.assetbundle"));
		}




		
	}
			// 读取一个资源
			private IEnumerator  LoadMainGameObject(string path){
	
		WWW bundle = new WWW (path);
		yield return bundle;
		yield return  Instantiate (bundle.assetBundle.mainAsset);
		bundle.assetBundle.Unload (false );


			}
			private IEnumerator  LoadAllGameObject(string path){
		WWW bundle = new WWW (path);
		yield return  bundle;
		Object obj1 = bundle.assetBundle.LoadAsset  ("Cube");
		Object obj2 = bundle.assetBundle.LoadAsset  ("Sphere");
			Object obj3 = bundle.assetBundle.LoadAsset  ("Sphere (1)");
		Object obj4 = bundle.assetBundle.LoadAsset ("Capsule");


		yield return Instantiate (obj1);
		yield return Instantiate (obj2 );
			yield return Instantiate (obj3 );
			yield return Instantiate (obj4 );
		bundle.assetBundle.Unload (false);
			}
	














}
