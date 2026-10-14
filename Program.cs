/* 
* Name: Peyton Wingo
* Course CSCI 1250, Section 002
* Assignment: Lab 04, Group Trip
* Date: 10-14-26
* Description: 
*/

// guestList, hoursWorked, hourlyRate

//Roadtrip
Console.WriteLine("What is the round trip in miles");
int roundTripMiles = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many miles per gallon?");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("what is the price of gas per gallon?");
double fuelCost = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTripMiles / (double)milesPerGallon;

double totalCost = gallonsNeeded * fuelCost;

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + totalCost.ToString("C"));

//Pizza party

Console.WriteLine("How many pizzas?");
int howManyPizza = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price per pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const int pizzaSlices = 8;


double totalSlices = howManyPizza * pizzaSlices;
double slicesPerPerson = totalSlices / guestList;
double pizzaCost = howManyPizza * pricePerPizza;


Console.WriteLine("Total slices: " + totalSlices.ToString("F1"));
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C")); 

//Paycheck

const double taxRate = .18;

double grossPay = hoursWorked * hourlyRate;
double taxWithHeld = grossPay * taxRate;
double takeHome = grossPay - taxWithHeld;

Console.WriteLine("Gross pay: " + grossPay.ToString("F2"));
Console.WriteLine("Tax withheld: " + taxWithHeld.ToString("F2"));
Console.WriteLine("Take home pay: " + takeHome.ToString("F1"));

//Whole Trip

double tripTotal = totalCost + pizzaCost;
double costPerPerson = tripTotal / guestList;
double takeHomePayPerHour = takeHome / hoursWorked;
double hoursMustWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine("Trip total: " + tripTotal.ToString("C"));  
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));  
Console.WriteLine("Take home pay: " + takeHomePayPerHour.ToString("C"));  
Console.WriteLine("Hours you must work: " + hoursMustWork.ToString("F2"));

//the complete run

System.Console.WriteLine("");
Console.WriteLine("=== Part 1: Road Trip ===");

System.Console.WriteLine("");
Console.WriteLine("Round trip miles: " + roundTripMiles.ToString("F1"));
Console.WriteLine("Miles per gallon: " + milesPerGallon.ToString("F1"));
Console.WriteLine("Price per gallon: " + fuelCost.ToString("F2"));
System.Console.WriteLine("");

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + totalCost.ToString("F2"));
System.Console.WriteLine("");

Console.WriteLine("=== Part 2: Pizza party ===");

System.Console.WriteLine("");
Console.WriteLine("How many people are going: " + guestList.ToString("F1"));
Console.WriteLine("How many pizzas: " + howManyPizza.ToString("F1"));
Console.WriteLine("Price per pizza: " + pricePerPizza.ToString("F2"));
System.Console.WriteLine("");

Console.WriteLine("Total slices: " + totalSlices.ToString("F1"));
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine("");

Console.WriteLine("=== Part 3: Paycheck ===");

System.Console.WriteLine("");
Console.WriteLine("Hours worked this week: " + hoursWorked.ToString("F1"));
Console.WriteLine("Hourly rate: " + hourlyRate.ToString("F2"));
System.Console.WriteLine("");

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithHeld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHome.ToString("C") );
System.Console.WriteLine("");

Console.WriteLine("=== Part 4: The Whole trip ===");

System.Console.WriteLine("");
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursMustWork.ToString("C"));

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon);

static double TakeHomePay(double hours, double hourlyRate, double taxRate);

static double HoursToCover(double amountOwed, double takeHomePerHour);