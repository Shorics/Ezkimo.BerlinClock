# Ezkimo.BerlinClock
- [Description](#description)
- [Task](#task)
- [Example](#example)
- [Run Tests](#run-tests)
- [Build](#build)
- [Run App](#run-app)
  - [as commandline argument](#as-commandline-argument)
  - [with input prompt](#with-input-prompt)
  
## Description
https://fotoeins.com/2017/12/11/my-berlin-mengenlehreuhr-berlin-clock/

The Berlin Uhr (Clock) is a rather strange way to show the time. 

On the top of the clock there is a yellow lamp that blinks on/off every two seconds. The time is calculated by adding rectangular lamps. 

The top two rows of lamps are red. These indicate the hours of a day. In the top row there are 4 red lamps. Every lamp represents 5 hours. In the lower row of red lamps every lamp represents 1 hour. So if two lamps of the first row and three of the second row are switched on that indicates 5+5+3=13h or 1 pm. 

The two rows of lamps at the bottom count the minutes. The first of these rows has 11 lamps, the second 4. In the first row every lamp represents 5 minutes. In this first row the 3rd, 6th and 9th lamp are red and indicate the first quarter, half and last quarter of an hour. The other lamps are yellow. In the last row with 4 lamps every lamp represents 1 minute. 

The lamps are switched on from left to right.

## Task
Create a representation of the Berlin Clock for a given time as String (hh:mm:ss) which returns a formatted String [Y = Yellow; R = Red; O = Off] representing the current state of the clock.

## Example
Input

    13:17:02

Output

    Y
    RROO
    RRRO
    YYROOOOOOOO
    YYOO

## Run Tests
```sh
dotnet test
```

## Build
```sh
dotnet build --configuration Release 
```

## Run App
### as commandline argument
```sh
./Ezkimo.BerlinClock.exe 13:17:02
```
### with input prompt
```sh
./Ezkimo.BerlinClock.exe
```