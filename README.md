# unity-asset-bundle-builder
Builds multiple asset bundles from an FBX file.

## Setup
1. Download Unity 2019.1.0f2
2. Open unity and login

## Running
1. Copy your fbx file and associated resources to `Assets/Model/model.fbx`
2. Build the asset bundles `/path/to/Unity -projectPath . -quit -batchmode -executeMethod CreateAssetBundle.Build`

To clean up run `git clean -df`
