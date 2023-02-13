# Tournament Tracker

This project was based on the tutorial "[C# Application From Start to Finish: Tournament Tracker Course](https://www.youtube.com/playlist?list=PLLWMQd6PeGY3t63w-8MMIjIyYS7MsFcCi)" by [Tim Corey on YouTube](https://www.youtube.com/@IAmTimCorey).

## Requirements for App

1. Track games played and their outcome.
2. Multiple competitors play in the tournament.
3. Creates a tournament plan (who plays in what order).
4. Schedule games.
5. A single loss eliminates a player.
6. The last player standing is the winner.

## Questions for App

1. How many players will the tournament handle? Is it _variable_?

   _Should be variable._

2. If a tournaments has less than the full complement of players (2, 4, 8, 16...), how do we handle it?

   _If less than the perfect numbers, there should be "byes", meaning that certain people randomly get to skip the first round._

3. Should the ordering of who plays each other be random or ordered by input order?

   _Random._

4. Should we schedule the game or are they just played whenever?

   _The players should be able to play whenever they want._

5. If the games are scheduled, how does the system know when to schedule games for?

   _They are not scheduled._

6. If the games are played whenever, can a game from the second round be played before the first is complete?

   _No. Each round should be completed before the next is displayed_.

7. Does the system need to store a score of some kind or just who won?

   _It would be nice to have 1 for a win and 0 for a loss._

8. What type of front-end should this system have (form, webpage, app, etc.)?

   _Should be a desktop app for now, but may be an app or site in the future._

9. Where will the data be stored?

   _Ideally in a Microsoft SQL database, but a text file should be an option._

10. Will the system handle entry fees, prizes, or other payouts?

    _Yes, there should be an option to charge an entry fee. An administrator should also be able to distribute prizes to a variable number of places. The total cash amount should not exceed the income from the tournament. A percentage-based system would be nice to specify._

11. What type of reporting is needed?

    _A simple report specifying the outcome of the games per round as well as a report that specifies who won and how much they won. These can be just displayed ona form or they can be emailed to tournament competitors and the administrator._

12. Who can fill in the results of the game?
    _Anyone using the application should be able to fill in the game scores._

13. Are there varying levels of access?

    _No. The only method of varied access is if the competitors are not allowed into the application and instead, they do everything via email._

14. Should this system contact users about upcoming games?

    _Yes, the system should email users that they are due to play in a round as well as who they are scheduled to play._

15. Is each player on their own or can teams use this tracker?

    _The tournament tracker should be able to handle the addition of other members. All members should be treated as equals in that they all get tournament emails. Teams should also be able to name their team._

## Big Picture Design

- Structure: Windows Forms application and Class Library
- Data: SQL and/or Text File
- Users: One at a time on one application
- Key Concepts:
  - Email
  - SQL
  - Custom Events
  - Error Handling
  - Interfaces
  - Random Ordering
  - Texting (Optional Extra)

## Data Mapping

### `Team`

- `TeamMembers (List<Person>)`
- `TeamName (string)`

### `Person`

- `FirstName (string)`
- `LastName (string)`
- `EmailAddress (string)`
- `CellphoneNumber (string)`

### `Tournament`

- `TournamentName (string)`
- `EntryFee (decimal)`
- `EnteredTeams (List<Team>)`
- `Prizes (List<Prize>)`
- `Rounds (List<List<Matchup>>)`

### `Prize`

- `PlaceNumber (int)`
- `PlaceName (string)`
- `PrizeAmount (decimal)`
- `PrizePercentage (double)`

### `Matchup`

- `Entries (List<MatchupEntry>)`
- `Winner (Team)`
- `MatchupRound (int)`

### `MatchupEntry`

- `TeamCompeting (Team)`
- `Score (double)`
- `ParentMatchup (Matchup)`

## UI Design

### View Tournament

![Alt text](images/Pasted%20image%2020230130130720.png)

### Create Tournament

![Alt text](images/Pasted%20image%2020230130130818.png)

### Create Team

![Alt text](images/Pasted%20image%2020230130131420.png)

### Create Prize

![Alt text](images/Pasted%20image%2020230130131731.png)

### Tournament Dashboard

![Alt text](images/Pasted%20image%2020230130131840.png)
