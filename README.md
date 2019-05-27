# Unity - Basics

## Using Unity with GitHub

In order to share a Unity project on GitHub without complications there are a few things to do.

1. Show Meta-Files

   This makes hidden text files visible that contain necessary configurations for Unity-Assets and Folders.

   TODO screenshot/path

2. Force text serializing for binary files

   Unity-Scene files are binary files per default which make trouble when trying to merge. Forcing text will cause Unity-Scenes to be saved as YAML files.

   TODO screenshot path

3. Use up-to-date .gitignore file

   Unity produces many temporary files that are user specific and not necessary to have in a repository.
   An example .gitignore file can be found here:

   <https://github.com/github/gitignore/blob/master/Unity.gitignore>



## Scripting Essentials 

Scripting in Unity uses the programming language C#. Unity's scripting is very beginner friendly and a lot of things can be done without getting too deep into the matter.

### Using your favourite IDE

If you don't have a favourite C# development environment you can use the IDE Unity delivers called MonoDevelop. You can configure Unity to open C# script files with a custom editor.

TODO screenshot path.

### Creating a new Script

A new C# script can be created in the project explorer and manually assigned to a GameObject.

TODO screenshot/path

Or directly assigned when creating the script from the component view of a GameObject.

TODO screenshot/path

### Basic Script

A newly created script contains two auto-generated methods.

- Start()
  This method is executed once in the beginning when running the game. Can be used to assign variables  or instantiate objects needed in the game. 
- Update()
  This method is executed every frame.

There are other such methods like FixedUpdate, OnEnabled, OnAwake but Start and Update are the most frequently used. 

### Variables and useful Classes

In Unity public variables of certain types can be seen and edited at runtime from the Inspector.

TODO screenshot/path

TODO was noch hier?

### Accessing Objects and Components

The GameObject to which the C# script is assigned can be accessed by using ***gameObject***. 

TODO screenshot/path

Finding other GameObjects can be done in several ways. The easiest way is to use the ***Find*** method from the GameObject class. 

TODO screenshot/path

To access the component of a certain GameObject ***getComponent*** can be called on the GameObject.

TODO screenshot/path

The Transform component of a GameObject doesn't have to be accessed using *getComponent* but can be accessed just by using ***transform*** on the GameObject.

TODO screenshot/path

### Basic Scripting Actions

TODO irgendwas

### User Input

TODO irgendwas



## Building the Project

The Build Settings can be found at File > Build Settings
Different platforms can be chosen here. To build a game for PC the first option can be chosen.

TODO: screenshot

After clicking Build and choosing a destination the Application will be built. The finished build can be executed without having the Unity Editor installed.

