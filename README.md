# BankHeist
## The Story

You are poor. After much, deep consideration, it occurs to you that if you were to get some money, you wouldn't be so poor.

With this insight you begin to consider where to get money... *Banks have money*, you think to yourself, *maybe I could take some of that.* Thus, your dream of a bank heist is born.

Even though you are amazing at everything you do, you realize you
cannot rob a bank alone. You'll need a team. But who should you recruit? Of course, you have a rolodex full of criminal masterminds, but you
must be selective. Invite too many and each person's take is too small.
Invite too few and your heist will fail. Also, you realize, you'll need
to take luck (random chance) into account.

Maybe you could write a C# program to help you?

## The Exercise

This program will be written in phases. Along the way you will get
some practice with classes, methods, properties, loops, lists, and
more...

### Phase One

The program should...

1. Print the message "Plan Your Heist!".
2. Create a way to store a single team member. A team member will have a *name*, a *skill Level* and a *courage factor*. The *skill Level* will be a positive integer and the *courage factor* will be a decimal between 0.0 and 2.0.
3. Prompt the user to enter a team member's name and save that name.
4. Prompt the user to enter a team member's skill level and save that skill level with the name.
5. Prompt the user to enter a team member's courage factor and save that courage factor with the name.
6. Display the team member's information.

### Phase Two

The program should be updated to...

1. Create a way to store several team members.
2. Collect several team members' information.
3. Stop collecting team members when a blank name is entered.
4. Display a message containing the number of members of the team.
5. Display each team member's information.

### Phase Three

The program should be updated to...

1. Stop displaying each team member's information.
2. Store a value for the *bank's difficulty level*. Set this value to 100.
3. Sum the skill levels of the team. Save that number.
4. Compare the number with the bank's difficulty level. If the team's
skill level is greater than or equal to the bank's difficulty level,
Display a success message, otherwise display a failure message.

### Phase Four

The program should be updated to...

1. Create a random number between -10 and 10 for the heist's *luck value*.
2. Add this number to the bank's difficulty level.
3. Before displaying the success or failure message, display a report that shows.
    - The team's combined skill level
    - The bank's difficulty level

### Phase Five

The program should be updated to...

1. Run the scenario multiple times.
2. After the user enters the team information, prompt them to enter the number of *trial runs* the program should perform.
3. Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new *luck value* each time.

### Phase Six

The program should be updated to...

1. At the beginning of the program, prompt the user to enter the difficulty level of the bank.
2. At the end of the program, display a report showing the number of successful runs and the number of failed runs.
