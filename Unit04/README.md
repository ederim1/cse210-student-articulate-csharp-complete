# Greed 
The spaceship needs to get the Gems to achieve more points and avoid the Red characters to keep the score.
The green characters add points and the red lower the points, you have to use the arrows in your keyboard to move the spaceship arround 

---
## Getting Started
Make sure you have dotnet 6.0 or newer installed on your machine. Open 
a terminal and browse to the project's root folder. Start the program 
by running the following commands.
```
dotnet build
dotnet run 
```
You can also run the program from an IDE like Visual Studio Code. 
Start your IDE and open the project folder. Select "Run and Debug" on 
the Activity Bar. Next, select the project you'd like to run from the 
drop down list at the top of the Side Bar. Lastly, click the green 
arrow or "start debugging" button.

## Project Structure
The project files and folders are organized as follows:
```
root                    (project root folder)
+-- Game                (source code folder)
    +--Casting          (contains all the folders with classes)
        +--Actor        (the "spaceship")
        +--Artifact     (the characters falling)
        +--Cast         (keeps track of a collection of actors)
        +--Color        (sets up the color in the game)
        +--Point        (Tracking the position)    
    +--Directing        (contains the director file)
        +--Director     (The risponsable of Directing the game)
+-- Program.cs          (program entry point)    
+-- README.md           (general info)
+-- Unit04.csproj       (dotnet project file)
```

## Required Technologies
* dotnet 6.0
* raylib-cs 3.7.0.1

## Authors
* Matt Manley (manleym@byui.edu)
* Scott Burton (burtons@byui.edu)
* Eder Morales (ederim@byui.edu)