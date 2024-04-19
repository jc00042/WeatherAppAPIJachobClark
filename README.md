# MIST 353 Assignment 5

## Web Pages and Functions

### Jachob Clark Razor Pages

"PlayerInfo" <br/>
* Purpose: This page displays the information of a desired player in the Premier League.
* Input: The ID number of a player on any team. 
* Output: The desired player's name, number, position, and the ID of the team they play for. 
* Explanation: This page prompts the user to enter a player's ID number, alongside a search bar and search button. The user will type in a player's ID number and click 
 search. The input is then taken and the name, position, and number of the desired player will be displayed. This action is done by using my API which uses my stored precedure from our SQL database.

<br/>

"TeamInfo" <br/>
* Purpose: This page displays the teams that are in the same location in the Premier League. The naming convention is off because of misinterpretation.
* Input: The location of any Premier League soccer team. 
* Output: A list of all the different teams that are located in the same location. Each team in the list will also display team name, location, and team ID. 
* Explanation: Similar to my previous page, this page prompts the user to enter a location of any Premier League soccer team. The user will insert the location into a search
* bar and then click a search button to see a list of the teams in the same location. The input is then taken and the team name, location, and team ID of the teams in the same location will be displayed.
* This action is done by using my API which uses my stored precedure from our SQL database.


### Braelynne Sandreth Razor Pages

"MatchResults"
* Purpose: This Razor page provides a user interface to retrieve match results for a specific player.
* Input: It takes the player ID as input through a form submission.
* Output: It displays the match results associated with the provided player ID.
* Explanation: Users can input a player ID into the form, and upon submission, the page triggers a request to the server. The MatchResultsModel retrieves match results for the specified player ID using the IMatchResultsService. The fetched results are then displayed on the page.

<br/>

"NewPlayer" <br/>
*	Purpose: This Razor page provides a user interface to add a new player into the system.
*	Input: It takes the player's name as input through a form submission. 
*	Output: It confirms the successful addition of the new player. 
*	Explanation: Users can input the name of a new player into the form, and upon submission, the page triggers a request to the server. The NewPlayerModel inserts the new player into the system using the INewPlayerServices. It then displays a success message confirming the addition of the new player. 


### Andrew Forman Razor Pages

"GetTeamMatchResults"<br/>
* Purpose: This page displays the match results from a desired team inputted by the user.
* Input: The team name of the user's desired team. 
* Output: The match results of desired team in table format. 
* Explanation: This page presents the user with a prompt to enter a team name, alongside a search bar and submit button. The user will type in a team name and click 
 submit. They will then be shown all match results for the given team in a table form. This action is done by using my API which uses my stored precedure from our SQL database.

"AllMatchResults"<br/>
*	Purpose: This page displays the match results of all teams in the database.
* Input: Reference button on the "GetTeamMatchResults" page. 
* Output: The match results of all teams in table format. 
* Explanation: This page allows the user to see all match results from everyteam in the database. 
 This action is done by using another API which uses my stored precedures from our SQL database. 

<br/>

## API's Used
1. NewPlayerService
2. TeamService
3. NewPlayerServices
4. MatchResultsService
5. Matches
6. Team Match Results

<br/>

## References
### Chat GPT Prompts
* "Here is my code for my razor pages, fix any errors."

* "Help me implement a search bar and function to this snippet of code:"

* "What am I missing in this code that causes my program not to run?"

### Class Lecture Videos
