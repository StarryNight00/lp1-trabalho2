# **HumansVsZombies**

## Who made the project

* __Diana Nóia__ > __a21703004__ <

* __Sara Gama__ > __a21705494__ <

* __Catarina Matias__ > __a21801693__ <
 
## Contact

* [GitHub](https://github.com/StarryNight00/lp1-trabalho2)

## Who did what

__Catarina Matias__
-> In this project, I developed mainly the Menu's base structure and the Board
and DrawBoard classes.
-> I also helped and participated in coding the Program and Game classes,
mainly the first game loop instance in the latter, and structural calls on and
from other classes related to these.
-> Along the project I tried to generally help my colleagues, although such
help focused in coding logic problems and other non coding problems.

__Diana Nóia__
-> I worked on the Board, DrawBoard, Agents, Player and Game classes, and on
the AgentType enumeration. I also helped on all the other classes development.
-> Throughout the development I participated in all discussions and tried to be
as helpful as possible, helping them fix some of the problems that appeared,
such as visibility of Methods an Classes and with where to use references.
-> I helped on the making of the flowchart, that was made by my colleague Sara.

__Sara Gama__
-> I worked on the AI, Game, Player, Board, Menu, Program and DrawBoard
classes. I also helped on all the other classes development.
-> I made the flowchart for the project and participated in all the discussions
along with my colleagues, solving any problems that they had.

## Our Solution

### Project architecture

The main data structures used in this project are classes, methods, arrays,
lists, variables and auto-implemented properties.
We created a list of agents, where we added the two types, humans and zombies.
We developed a method called Toroidal with some research and help from
colleagues.
It receives a current position of an agent that's controlled by the AI, and it
never goes off grid. When the radius goes off the grid during the check for
enemies, it will enter through the other side of the grid.
If a zombie controlled by the AI detects a human, it will move towards it,
and try to infect it. The opposite will happen if it's a human being controlled
by the AI, where it will move on the opposite direction.
If a zombie, either controlled by the AI or the player or the AI, moves into
the same spot on the grid as a human, the human becomes zombie.

### UML

![UML](https://github.com/StarryNight00/lp1-trabalho2/blob/master/UML.png)

### Flowchart

![Flowchart](https://github.com/StarryNight00/lp1-trabalho2/blob/master/Flowchart.png)

### Conclusions

__Catarina Matias__
-> Along this project I developed mainly my git skills, my group coordination
skills and solidified some of the capacities and subjects talked in class.
-> Working with Diana and Sara did better my C# coding skill to an extent,
especially because this time I had people to discuss my solutions with and
correct me.
-> In this project I did notice that my theory knowledge is good and this
allowed me to structure better the classes I developed. However, my practical
coding skills are not on the same level and this did set me back once we were
working.
-> In the future I need to focus on bettering my coding and diversify my
solutions. Also, I need to understand different coding structures better so to
not set myself back once I'm already programming.

__Diana Nóia__
-> Throughout the duration of this project, I improved upon my knowledge on the
subjects talked about in the classes and on how to better split tasks so the
work flow of a group is better.
-> I also managed to share some of my knowledge about Git with my colleagues
when some problems appeared, and on how to use the ref keyword to indicate that
an argument is passed by reference and not by value. In my opinion this was a
big advancement from previous projects.
-> Working on this project was also beneficial because we could discuss the
theoretical side of the code with one more person, and since all members are
on different knowledge levels of C#, I think these discussions helped all
members in some way. For me in particular, this allowed me to better understand
what my weaknesses and strengths are, and on what subjects I should improve
upon for future projects and endeavors.

__Sara Gama__
-> Thanks to this project I now better understand how an AI should be
structured, and this will be beneficial for future endeavors.
-> I also improved on my organization and my communication skills, and
being able to have discussions about the project with a new colleague was a
good thing.
-> This was a challenging project, but even though there were complications,
being able to overcome some of them was a big step.

### References

* [LP1_Aulas](https://github.com/VideojogosLusofona/lp1_2018_aulas): 
Powerpoints provided by the teacher
* [StackOverFlow](https://stackoverflow.com/search?q=git+abort)
* [StackOverFlow](https://stackoverflow.com/questions/101752/i-ran-into-a-merge
-conflict-how-can-i-abort-the-merge)
* [StackOverFlow](https://stackoverflow.com/questions/1646998/up-down-left-and
-right-arrow-keys-do-not-trigger-keydown-event)
* [Net-informations](http://net-informations.com/q/faq/arrowkeys.html)
* [Docs.Microsoft](https://docs.microsoft.com/pt-br/dotnet/api/system.security.
cryptography.xml.keyinfo?view=netframework-4.8)
* [DreaminCode](https://www.dreamincode.net/forums/topic/215620-a-basic-c%23-
console-game-movement-engine/)
* [SwitchCase](https://pt.switch-case.com/53481830)

### Collaborators

We would also like to thank our classmate Leandro Brás for his help on how the
toroidal algorithm should work.
