# Assignment #2

## C♯

Fork or clone repository.

## Overleaf:

edit link: https://www.overleaf.com/3935927989fnffndqjscnd

### Classes

In a new *class library* implement a *class* `Student` with the following properties:

- Id : `int`
- GivenName : `string`
- Surname : `string`
- Status : `Status` (enum: `New`, `Active`, `Dropout`, `Graduated`)
- StartDate : `DateTime`
- EndDate : `DateTime`
- GraduationDate : `DateTime`

And the following rules:

- Status is only readable - figure out the business rules given the three dates compared to `DateTime.Now`.
- Id can only be set when the class is created
- Implement a nice `ToString()` method

**Note**: Remember to do this Test-Driven - so create an xunit test library and implement the required tests there.

### Records

(cf. CSN chapter 4 section *Records*)

Implement a new *record* `ImmutableStudent` with the same rules as above, only now all properties must be *immutable* and set through the constructor.

Write a couple of tests where you test the built-in equality comparer and to string properties of a *record*.

### Types

Consider the four different constructs in C♯:

1. Class
1. Struct
1. Record Class
1. Record Struct

Explain some of the key differences between the three and give examples of where you would use each of them.

Write your answers in the final .pdf file.

### Extension Methods

Consider the two methods you implemented last week:

```csharp
IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items);

IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate);
```

Given the following collections in scope:

```csharp
IEnumerable<int>[] xs;

int[] ys;
```

Solve the following questions with extension methods (one-liners):

1. Flatten the numbers in `xs`.
1. Select numbers in `ys` which are divisible by `7` and greater than `42`.
1. Select numbers in `ys` which are *leap years*.

Write the answers in the .pdf file with all non-code solutions.

Implement and test the following extension methods:

1. A method `IsSecure` which extends `Uri` and returns true if the `Uri` is using *Secure Hypertext Transfer Protocol*.
1. A method `WordCount` which extends `string` and returns the number of words in the string. Note a word can only contain *unicode letters* (no numbers or symbols).

Use the supplied `Extensions.cs` and `ExtensionsTests.cs` files.

### Delegates / Anonymous methods

Implement the following anonymous functions using the built-in delegates and lambda expressions:

1. A method which takes a string and prints the content in reverse order (by character)
1. A method which takes two decimals and returns the product
1. A method which takes a whole number and a string and returns `true` if they are numerically equal. Note that the string `"  0042"` should return true if the number is `42`

Write the answers in the .pdf file with all non-code solutions.

You probably want to implement a set of tests to validate the methods.

Use the supplied `DelegatesTests.cs` file.

### LINQ

Prerequisite: Extend the `Wizards.csv` file with at least 10 wizard of your choosing to enable the queries above.
Examine the `Wizard` class and its corresponding unit test class.

Then, given the supplied `Wizard` record and `WizardCollection` class, use the supplied `Queries.cs` and corresponding tests class to implement and test the following queries using LINQ:

(You need to wrap the queries in suitable methods for testing)

1. Wizards invented by *Rowling*. Only return the names.
1. The year the first *sith lord* was introduced. Let's define a *sith lord* to be one named Darth *something*.
1. Unique list of wizards from the *Harry Potter* books - only return name and year (as a value tuple).
1. List of wizard names grouped by creator in reverse order by creator name and then wizard name.

Each method *must* be implemented twice - once using only *extension methods* and once using as much *LINQ* as possible.

Also, take some time to investigate and try to understand the implementation of `WizardCollection`.


---

## Software Engineering


### Exercise 1

Describe the difference between a _scenario_ and a _use case_.
Describe for each of the two concepts when and for what they are used.


### Exercise 2


Identify and briefly describe four types of requirements that may be defined for a computer-based system.

(This is exercise 4.1. in Sommerville _"Software Engineering"_ (10th Ed.))


### Exercise 3


Draw a use case diagram for a ticket distributor for a train system.
The system includes two actors: a traveler, who purchases different types of tickets, and a central computer system, which maintains a reference database for the tariff.
Use cases should include: **Buy OneWay Ticket**, **Buy Weekly Card**, **Buy Monthly Card**, **Update Tariff**. 
Also include the following exceptional cases: **Time-Out** (i.e., traveler took too long to insert the right amount), **Transaction Aborted** (i.e., traveler selected a cancel button without completing the transaction), **Distributor Out of Change**, and **Distributor Out of Paper**.


### Exercise 4

In the following, you find a requirement that is specified for the "samlet socialfagligt it-system" (also called VUM 2.0):

  > 5.1 Brugervenlighed 
  >
  > Medarbejdere skal digitalt understøttes i udførelsen af deres kerneydelser, og derved skal den digitale understøttelse være medvirkende til, at kommunen er et attraktivt sted at arbejde. 
  >
  > Kommunen har forskellige faglige målgrupper, som møder borgerne forskellige steder, og som arbejder, hvor borgerne er. Det kan være på gaden, i borgerens eget hjem, men også på dag- og døgninstitutioner uden for kontoret. Derfor er det vigtigt, at store dele af løsningen kan afvikles på mobile enheder. 
  > 
  > Det er altafgørende, at medarbejderne føler sig godt understøttet af den nye digitale løsning. Det gælder både i forhold til at effektivisere tunge arbejdsgange via genbrug af data, deling af data og ikke mindst, at løsningen er medvirkende til god lovmedholdelighed i sagsbehandlingen, hvilket tilsammen kan understøtte en faglig stolthed. 
  > 
  > Et andet og vigtigt parameter er, at kommunen gerne vil fastholde sine dygtige medarbejdere med en løsning, der understøtter og guider dem i deres daglige opgaveløsning. En stabil og driftssikker løsning er en medvirkende faktor til større tilfredshed med ansættelsen i kommunen.
  >
  > [Samlet socialfagligt it-system](https://www.google.dk/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwjRj7uWnYD6AhWpl4sKHbtnAeIQFnoECBEQAQ&url=https%3A%2F%2Fsocialstyrelsen.dk%2Ffiler%2Ftvaergaende%2Fvum-2.0%2Fvum-2-0-kravspecifikation-september-2020.docx&usg=AOvVaw3o8j5wK3Vy5D494P6-Q3pi)


  * Discover formulations in the requirement that are ambiguous.
  * Is there any information missing in the requirement?
  * The requirement specifies a set of non-functional requirements. What is problematic about there formulation?
  * Rewrite the requirement according to what you identified as problematic in the three bullet points above.


### Exercise 5

Watch the video below in which a domain expert explains music _trackers_.
Imagine that the narrator explains only the hardware trackers he demonstrates and that there have never been any music trackers that were implemented as pure software systems.

[![Alt text](https://img.youtube.com/vi/KxNfc8YDIjI/0.jpg)](https://www.youtube.com/embed/KxNfc8YDIjI?start=44&end=452)


Based on the video above:

  * Identify actors that interact with a music tracker software system.
  * Formulate three use cases in structured language that a software music tracker system has to support.
  * Express three non-functional requirements for a music tracker software system.


### Exercise 6

For this exercise, we assume that the canteen at IT University wants to establish a new payment system.

As an example for ethnographic work, use ten to 20 minutes when going for lunch to observe how you and other customers of the canteen interact with the current payment system.

During your observations take notes.

Based on your observations and notes, write down a use case in structured language that a canteen payment system has to support.
For this use case write down three requirements and categorize them as functional or non-functional.


## Submitting the assignment

To submit the assignment you need to create a PDF document using LaTeX that contains the answers to the questions **and** a link to a public GitHub repository that contains a fork of the assignments repository with the completed code.

**Note**: You should not send a PR with your changes.

The PDF file must conform to the following naming convention: `group_<x>_<id1>_<id2>_<id3>_assignment_02.pdf`, where `<x>` is replaced by the number of your group from [README_GROUPS.md](./README_GROUPS.md) and `<id1>`, `<id2>`, and `<id3>` are your respective ITU identifiers. 

You submit via [LearnIT](https://learnit.itu.dk/mod/assign/view.php?id=164797).
