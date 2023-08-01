# ScoreCard Plus API

API used to generate and store Golf Scorecards.

## Description

ScoreCard Plus API will allow create, update, delete scorecards made by user to be stored and retrived upon command.
A database housing these scorecards will be created using SQL/SQLlite/mySQL/etc combined with EF.
The main goal is to have a functioning API that returns what the user adds and have that info connected to the applicable subject.
Future plans outside the scope of the class project would include linking the API with a front end such as react.

***DISCLAIMER***
Originally, a project I had been working on for some weeks not using API but a MVC had developed some issues.
Working to resolve these issues ended up in some late night mistakes, instead of asking for help I thought I had it,
I did not have it... failed connection to repository resulted and after modifying the solution file it got worse,
This resulted in full deletion of project and restart with only a week to go, luckily I had partial complete API from class.
Using this I modified it and made it into a Scorecard API and made it like a recording journal that would record all the scorecards and retrive/edit when searched for.
Another few features added broke the soulution and in a scramble to fix them I messed up the git when pushing and tried to fix that
NOTE TO SELF >> Do not use commands of which you do not understand.
In doing so I somehow deleted the file, had to create a new project, remove old from repo, add new to repo got an error removed repo, deleted repo made new repo spend 
the last 3 days of class building and implementing the same features as previous API such as below while also making sure to complete at leats 5 commits, DONE. 

## Getting Started

### Features

* API
* Entity framework
* List/database
* Async
* Generics
* Json
* Multiple classes
* Inheritance
* I know theres a few more features but these are the highlights.



### Installing

* Clone from Github Link

### Executing program

* Open .sln file 
* Run Solution
* Use the POST to generate new Scorecard with "Try it out"
* Input "Course", "NumberofHoles", "ParCourseTotal", "NumberofPlayers", etc.
* Category "Holes" allows for input of yardage, Hole Number (1-18), and PAR for that hole.
* Click Execute to generate new scorecard, Json format displayed

* May also Copy Id generated at top and run GET, try it out, enter ID copied, should retrive created Scorecard's'

### Help
* May need to update the database, I usally just use powershell:
```
dotnet ef update database
```
* In case of 500 error in swagger resulting in SQL error regarding Scorecard ID, a new ID must manually be entered with each new POST.

## Authors

Contributors names and contact info

Andrew Franics



## Version History

* 1.4 
    * Rebuild of controllers, classes, and fixes applied to database functions
    * Updated README
* 1.3
    * Various bug fixes and optimizations
    * See [commit change]() or See [release history]()
* 1.2
    * Various bug fixes and optimizations
    * See [commit change]() or See [release history]()
* 1.1
    * Various bug fixes and optimizations
    * See [commit change]() or See [release history]()
* 1.0
    * Initial Release
 





