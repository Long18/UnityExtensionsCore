UnityExtensionsCore
===

UnityExtensionsCore is a Package that contains the following components:

* ReadOnly
* Fuzzy Finder
* Tiny Messenger
* Action Dispatcher
* ScriptableObject Event
* Serializable ScriptableObject
* Pooling based on `IObjectPool<T>` 
* Unit Test ( `Audio`, `AssetReference`, `Serializable ScriptableObject`,... )

## Table of Contents

- [Requirement](#requirement)
- [UPM Package](#upm-package)
  - [Install via git URL](#install-via-git-url)

Requirement
---

Extension Core for project develope using Unity
This package require Unitask so install it via Package Manager
https://github.com/Cysharp/UniTask?tab=readme-ov-file#upm-package 

UPM Package
---
### Install via git URL

Requires a version of unity that supports path query parameter for git packages (Unity >= 2022.3.0f1). You can add `https://github.com/Long18/UnityExtensionsCore.git` to Package Manager

![image](https://github.com/Long18/UnityExtensionsCore/assets/28853225/f961f679-0b6c-464b-8c00-6f1827842326)

![image](https://github.com/Long18/UnityExtensionsCore/assets/28853225/5a11d3e3-7abc-466c-9089-11d23116418e)

or add `"com.long18.extensions-core": "https://github.com/Long18/UnityExtensionsCore.git"` to `Packages/manifest.json`.

If you want to set a target version, UniTask uses the `*.*.*` release tag so you can specify a version like `#0.0.1`. For example `https://github.com/Long18/UnityExtensionsCore.git#0.0.1`.
