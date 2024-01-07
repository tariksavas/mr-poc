# Introduction
Depth, room setup, wall and furniture detection and colliders were tested in the Mixed Reality environment. Meta SDKs have been tested on Meta Quest 3.

# Versions
- Unity: 2022.3.2f1
- Meta MR Utility Kit: 60.0.0
- Meta XR Core SDK: 60.0.0
- Meta XR Interaction SDK: 60.0.0
- Meta XR Interaction SDK OVR Integration: 60.0.0
- Meta XR Simulator: 60.0.0
- Meta XR Simulator Samples: 60.0.0
- Meta XR Depth API: 60.0.0

# Steps
1. Download and import Meta XR and MR SDKs from AssetStore
2. Add Depth API package with Git [URL](https://github.com/oculus-samples/Unity-DepthAPI)
3. Set the Passthrough Support value in OVRManager to **supported**.
4. Set the Enable Passthrough value in OVRManager to **true**.
5. Set the Scene Support  value in OVRManager to **supported**.
6. Create an empty object in the scene and add **OVRPassthroughLayer** component to it.
7. Set the placement value in  OVRPassthroughLayer from Overlay to **Underlay**
8. Drag and drop **OVRSceneManager** to the scene
9. Assign OVRSceneAnchor references. (I assigned InvisiblePlane and InvisibleVolume)
10. Add PrefabOverrides if you want
11. Create an empty object in the scene and add **EnvironmentDepthTextureProvider** and **EnvironmentDepthOcclusionController** components
12. Set the Occlusion Type in EnvironmentDepthOcclusionController No Occclusion to **Soft Occlusion**
13. Replace the shader of the materials you want to have depth with Depth API shaders.

# Results
1. Mixed Reality environment has been successfully provided.
2. Depth perception is not perfect but good.
3. The scene setup in native was successfully started from the developed application.
4. Walls and furnitures were successfully separated.
5. Objects were placed on the scene without any problems.
6. As a result, all requirements were met.

# Conclusion
These SDKs have very detailed features and interactions with Meta Quest 3 but Depth perception is not very stable. In depth perception, gaps occur between objects and a perfect separation is not observed.

# Links
- [Meta MR Utility Kit](https://assetstore.unity.com/packages/tools/integration/meta-mr-utility-kit-272450)
- [Meta XR Core SDK](https://assetstore.unity.com/packages/tools/integration/meta-xr-core-sdk-269169)
- [Meta XR Interaction SDK](https://assetstore.unity.com/packages/tools/integration/meta-xr-interaction-sdk-264559)
- [Meta XR Interaction SDK OVR Integration](https://assetstore.unity.com/packages/tools/integration/meta-xr-interaction-sdk-ovr-integration-265014)
- [Meta XR Simulator](https://assetstore.unity.com/packages/tools/integration/meta-xr-simulator-266732)
- [Meta XR Simulator Samples](https://assetstore.unity.com/packages/tools/integration/meta-xr-simulator-samples-269800)
- [Meta XR Depth API](https://github.com/oculus-samples/Unity-DepthAPI)
