# 100 Days Of Code Log
**<i>Format inspired by <a href="https://github.com/GarnettGrant/diliGentt-100-days-of-code/blob/main/log.md#100-days-of-code---log">Diligentt</a>, <a href="https://github.com/DragoScript/100-DOC-Journal#100-days-of-code---journal">DragoScript</a></i>**

### Day 1: Wednesday, April 27, 2022

**Today's Progress :**
Started a new Calculator application with C#. Created a new folder called 100DaysOfCode and added a Git Watch to it.

**Thoughts :**
Seems pretty easy. Simple C# code. Made a class for the classic operations (add, subtract, multiplication, division). Most of the stuff we learnt from Programming during our classes in Programming 2 course. Would like to add more complicated functions though. And also convert it into a WinForms app later as well.
<hr>

### Day 2: Thursday, April 28, 2022

**Today's Progress :**
Worked with .gitignore file.

**Thoughts :**
Sheesh! Should have started with the VisualStudio .gitignore template. Totally forgot about it when creating the project. So I had to look up so many places to carefully add the .gitignore file and implement it without accidentally deleting the whole repo. Found an answer on Stack Overflow. Had to make git "forget" the temp files for it to stop tracking the files. Even if the temp files were to be excluded due to the .gitignore, git always tracks what it already started tracking. So had to use the <a href="https://stackoverflow.com/questions/1274057/how-can-i-make-git-forget-about-a-file-that-was-tracked-but-is-now-in-gitign">Stack Overflow answer</a>
```
git rm -r --cached .
git add .
git commit -am "Remove ignored files
```
*****<i>answered by Matt Frear, edited by Peter Mortensen</i>*****<br>
I had to use the terminal in gitkraken to execute these git commands. I'm totally new to git commands. I've seen them before, but I've just learned about Linux commands. Just realized they look very similar (only an observation).

### Day 3: Friday, April 29, 2022

**Today's Progress :**
Just figured out how to add images to github files.
<p align=left>
<img src="https://user-images.githubusercontent.com/93150595/165970055-df0ffd05-fdb7-4111-b0eb-8fe51e5d6eb1.png" alt="Image" width=250>
</p> 
**Thoughts :**
Just trying to make my log.md look a little better than it was. Technically writing HTML code with the tags

### Day 4: Saturday, April 30, 2022

**Today's Progress :**
Cleaned up the main method. Created a loop for the main menu.

**Thoughts :**
This was pretty simple. Just took some time to clean up the general look of the start menu. I need to transfer this into Winforms. Probably will do that by the next day. I tweaked the addition method in the Operations class to make it accept list of numbers to add; iterating through the list to add each element to the next one. So then the element becomes the new sum, and then gets added to the next number. So like cumulative addition within the list.

## Day 5: Sunday, May 1, 2022

**Today's Progress :**
Worked with the subtraction method.

**Thoughts :**
This was pretty much the same as the addition method. The way it takes in a list, and then returns cumulative difference of the elements. Also tuned the main menu to be a little more user-friendly (kinda). I made some adjustments to make it a little more customized. Like, instead of saying 'What would you like to do?' all the time, it only says that for the first time the program is started up, after which, when the loop comes back, it says 'What else would you like to do?'. It's a pretty small change, but a cool one nonetheless.
