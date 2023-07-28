# ScoreCard Plus API

API used to generate and store Golf Scorecards from various courses.

## Description

ScoreCard Plus API will allow create, update, delete scorecards made by user to be stored and retrived upon command.
A database housing these scorecards will be created using SQLlite/mySQL/etc.
The main goal is to have a functioning API that returns what the user adds and have that info connected to the applicable subject.
Future plans outside the scope of the class project would include linking the API with a front end such as react.

## Getting Started

### Dependencies

* Windows, VisualStudio, SwaggerUI, EF Core

### Installing

* Clone from Github Link

### Executing program

* Open .sln file 
* Run Solution
* Use the POST to generate new Scorecard with "Try it out"
* Input "CourseName", "Hole", "PAR Score", "Username", etc.
* Category "Holes" allows for input of yardage, Hole Number (1-18), and PAR for that hole.
* Click Execute to generate new scorecard, Json format displayed

* May also Copy Id generated at top and run GET, try it out, enter ID copied, should retrive created Scorecard's'

### Help
* May need to run new build before starting
```
dotnet build
```


## Authors

Contributors names and contact info

Andrew Franics



## Version History

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
 





