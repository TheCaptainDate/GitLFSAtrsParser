# GitLFSAtrsParser (Win only, sorry guys :( )
This program parse LFS settings from .gitattributes and execute them.

When you want to use Git LFS (https://git-lfs.github.com/) there is currently no way to copy settings from your last project, or some set of common settings.
If you put settings in your .gitattributes, like:

```
*.jpg filter=lfs diff=lfs merge=lfs -text
*.jpeg filter=lfs diff=lfs merge=lfs -text
*.png filter=lfs diff=lfs merge=lfs -text
*.gif filter=lfs diff=lfs merge=lfs -text
```

Nothing will happens!
Git LFS will not handle that settings before you don't actually run command - `git lfs track <*whatever*>`. I am not sure about files that already stored in git LFS, but this is absolutly true for new files that you want to store in LFS.
So, this app solves this issue. 

## How to use
First of all you need make special mark in your .gitattributes, to indicate position at which app shound start parsing. To do that just write `#LFS` on new line. 
For example full config from the one of my projects:

```
# Auto detect text files and perform LF normalization
* text=auto
# Custom for Visual Studio
*.cs     diff=csharp
# Standard to msysgit
*.doc	 diff=astextplain
*.DOC	 diff=astextplain
*.docx diff=astextplain
*.DOCX diff=astextplain
*.dot  diff=astextplain
*.DOT  diff=astextplain
*.pdf filter=lfs diff=lfs merge=lfs -text
*.PDF	 diff=astextplain
*.rtf	 diff=astextplain
*.RTF	 diff=astextplain

#LFS
*.jpg filter=lfs diff=lfs merge=lfs -text
*.jpeg filter=lfs diff=lfs merge=lfs -text
*.png filter=lfs diff=lfs merge=lfs -text
*.gif filter=lfs diff=lfs merge=lfs -text
*.psd filter=lfs diff=lfs merge=lfs -text
*.tif filter=lfs diff=lfs merge=lfs -text
*.tiff filter=lfs diff=lfs merge=lfs -text
*.ai filter=lfs diff=lfs merge=lfs -text
*.cubemap filter=lfs diff=lfs merge=lfs -text
*.prefab filter=lfs diff=lfs merge=lfs -text
*.mp3 filter=lfs diff=lfs merge=lfs -text
*.wav filter=lfs diff=lfs merge=lfs -text
*.ogg filter=lfs diff=lfs merge=lfs -text
*.mov filter=lfs diff=lfs merge=lfs -text
*.mp4 filter=lfs diff=lfs merge=lfs -text
*.fbx filter=lfs diff=lfs merge=lfs -text
*.FBX filter=lfs diff=lfs merge=lfs -text
*.obj filter=lfs diff=lfs merge=lfs -text
*.tga filter=lfs diff=lfs merge=lfs -text
*.zip filter=lfs diff=lfs merge=lfs -text
*.dll filter=lfs diff=lfs merge=lfs -text
*.aif filter=lfs diff=lfs merge=lfs -text
*.a filter=lfs diff=lfs merge=lfs -text
*.exr filter=lfs diff=lfs merge=lfs -text
*.ttf filter=lfs diff=lfs merge=lfs -text
*.reason filter=lfs diff=lfs merge=lfs -text
*.lxo filter=lfs diff=lfs merge=lfs -text
*.spt filter=lfs diff=lfs merge=lfs -text
*.c4d filter=lfs diff=lfs merge=lfs -text
```

`#LFS` comment indicate, that anything below is Git LFS settings.
After that all you need is just copy .exe to your root folder of project (where .gitattributes is) and then run it.

# Русский
`Напишу позже, куча текста на английском убила меня :)`
