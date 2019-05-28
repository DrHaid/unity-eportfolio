# Unity - Basics

## Contents

- [Unity - Basics](#unity---basics)
  * [Unity UI](#unity-ui)
    + [Camera movement](#camera-movement)
    + [Create a new Project](#create-a-new-project)
    + [Elements of the Unity UI](#elements-of-the-unity-ui)
  * [Basic Components](#basic-components)
    + [GameObject](#gameobject)
    + [Material](#material)
    + [Prefab](#prefab)
  * [Scripting Essentials](#scripting-essentials)
    + [Using your favourite IDE](#using-your-favourite-ide)
    + [Creating a new Script](#creating-a-new-script)
    + [Basic Script](#basic-script)
    + [Variables](#variables)
    + [Accessing Objects and Components](#accessing-objects-and-components)
    + [User Input](#user-input)
  * [Building the Project](#building-the-project)
  * [Using Unity with GitHub](#using-unity-with-github)
  * [Help](#help)


## Unity UI

### Camera movement

You can navigate in Unity by using the mouse and your keyboard.
 - when you press the right mouse button you can turn around
 - using the middle mouse button you can move in the scene in this direction
 - when you keep the right mouse button pressed and use the w/s/a/d key you can fly in the scene 

### Create a new Project

If you want to create a new Project, you have to go in the Unity Hub or start the Unity Version you want and press on "New".
After that the following Image should appear:

![](/images/CreateNewProject.png)

For our purpose you should select 3D.

### Elements of the Unity UI

![](/images/UnityUI.png)

- On the left you can see all Elements that are currently in your Scene
- On the right you see the Inspector of a current GameObject/Material/...
- On the bottom you see the project explorer
- In the middle is the view of the scene or the game

## Basic Components

### GameObject

![](/images/GameObject.png)

GameObejcts are physical things in your scene.

### Material

As you can see in the picture above the Cube has a color this color is a Material as you can see in the inspector of the Cube.

### Prefab

A Prefab is one or multiple GameObjects combined into one template.

## Scripting Essentials 

Scripting in Unity uses the programming language C#. Unity's scripting is very beginner friendly and a lot of things can be done without getting too deep into the matter.

### Using your favourite IDE

If you don't have a favourite C# development environment you can use the IDE Unity delivers called MonoDevelop. You can configure Unity to open C# script files with a custom editor.

Edit > Preferences > External Tools

![](/images/customide.PNG)

### Creating a new Script

A new C# script can be created in the project explorer and manually assigned to a GameObject.
Right Click in the Project Explorer, Create > C# Script

Or directly assigned when creating the script from the component view of a GameObject.
In the GameObject Inspector, Add Component > New script

### Basic Script

A newly created script contains two auto-generated methods.

- Start()
  This method is executed once in the beginning when running the game. Can be used to assign variables  or instantiate objects needed in the game. 
- Update()
  This method is executed every frame.

There are other such methods like FixedUpdate, OnEnabled, OnAwake but Start and Update are the most frequently used. 

### Variables

In Unity public global variables of certain types can be seen and edited at runtime from the Inspector.

`public int speed;`

![](/images/publicint.PNG)

### Accessing Objects and Components

The GameObject to which the C# script is assigned can be accessed by using ***gameObject***. 

`GameObject go = gameObject;`

Finding other GameObjects can be done in several ways. The easiest way is to use the ***Find*** method from the GameObject class. 

`GameObject go = GameObject.Find("Player");`

To access the component of a certain GameObject ***getComponent*** can be called on the GameObject.

`Collider col = go.GetComponent<Collider>();`

The Transform component of a GameObject doesn't have to be accessed using *getComponent* but can be accessed just by using ***transform*** on the GameObject.

`Vector3 position = go.transform.position; `

### User Input

The Input manager can be found at Edit > Project Settings > Input. Here you can label and configure possible Keyboard and Controller input to reference them in a script.

![](/images/inputman.PNG)

Input can be accessed from a script by using the Input class and the name of the input. Input can act as a key or an axis.

`bool keyDown = Input.GetButtonDown("Fire1");`

`float axisValue = Input.GetAxis("Horizontal") `

## Building the Project

The Build Settings can be found at File > Build Settings
Different platforms can be chosen here. To build a game for PC the first option can be chosen but before being able to build, a scene has to be added.  Click **Add Open Scenes** to add the current Unity-Scene to the build.

![](/images/buildsett.PNG)

After clicking Build and choosing a destination the Application will be built. The finished build can be executed without having the Unity Editor installed.

## Using Unity with GitHub

In order to share a Unity project on GitHub without complications there are a few things to do.

Edit > Project Settings > Editor

![](C:/Users/Luis/Documents/softwareengDEV/unity-eportfolio/images/editorsett.PNG)

1. Show Meta-Files

   Set the Version Control Mode to "Visible Meta Files".
   This makes hidden text files visible that contain necessary configurations for Unity-Assets and Folders.

2. Force text serializing for binary files

   Set the Asset Serialization Mode to "Force Text".
   Unity-Scene files are binary files per default which make trouble when trying to merge. Forcing text will cause Unity-Scenes to be saved as YAML files.

3. Use up-to-date .gitignore file

   Unity produces many temporary files that are user specific and not necessary to have in a repository.
   An example .gitignore file can be found here:

   <https://github.com/github/gitignore/blob/master/Unity.gitignore>

## Help

- <https://docs.unity3d.com/2019.2/Documentation/Manual/>
- <https://stackoverflow.com/questions/tagged/unity3d>
- <https://unity3d.com/de/learn/beginner-tutorials>
