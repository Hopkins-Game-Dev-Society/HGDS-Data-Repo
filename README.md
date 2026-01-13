# HGDS-Data-Repo
_Heist 2_, this time featuring Nolan's.

[![Screenshot-2026-01-13-at-01-52-45.png](https://i.postimg.cc/Kjxt6BXL/Screenshot-2026-01-13-at-01-52-45.png)](https://postimg.cc/hzZJxJtP)

<details>
  <summary> What We'll Do Together (click to expand) </summary>
  ---

  Use ScriptableObjects, session data, and scenes when possible.
  
</details>




<details>
  <summary> ⚠️ SPOILERS: The Task (click to expand) </summary>
  ---
  
  Add one gameplay feature that can be scaled in difficulty between levels. You can use the same feature from before if you were here from last time! Author your data with ScriptableObjects. Feel free to scale other things, like player/enemy movement speed too!

  The end goal is to have three levels, with winning each one leading to the next one. Each level should be more difficult than the one from before. In addition, you should have an ending scene (could just be a UI scene saying you won), and bonus points for having a starting menu scene too! More important things:
  - Move around the levels as much as you want to make them different!
  - Look up anything, and important code from today is below.
  - Ideally we'll have 40 minutes to do this?
  - Lmk if I can re-explain things! Data is a pretty dense topic but pretty important

</details>

## Important Code!
Put this above your ScriptableObject class so you can create it in your "Create New" menu in Unity!
- `[CreateAssetMenu(menuName = "FOLDER/NAME")]`
- Replace FOLDER with your folder name in the menu
- Replace NAME with your SO's name in the menu

Marks this GameObject as "Don't Destroy on Load", meaning it won't be destroyed when we switch scenes.
- `DontDestroyOnLoad(gameObject);`

Finds object of specified type and returns it. 
- `FindObjectOfType<TYPE>`
- Replace TYPE with the type you're looking for

Finds objects of specified type and returns an array.
- `FindObjectsOfType<TYPE>`
- Replace TYPE with the type you're looking for

Loads a scene.
- `SceneManager.LoadScene(SCENE_NAME);`
- Replace SCENE_NAME with your scene-to-load's name
- Remember to have `using UnityEngine.SceneManagement;`

Starter project by [L1Ryx](https://github.com/l1ryx).
